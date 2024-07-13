namespace Paraminter.Arguments.Semantic.Type.SemanticTypeArgumentData;

using Microsoft.CodeAnalysis;

using Moq;

using Paraminter.Arguments.Semantic.Type.Queries;
using Paraminter.Queries.Handlers;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        Mock<ITypeSymbol> symbolMock = new();

        Mock<IGetSemanticTypeArgumentDataQuery> queryMock = new();

        queryMock.Setup(static (query) => query.Symbol).Returns(symbolMock.Object);

        IQueryHandler<IGetSemanticTypeArgumentDataQuery, ISemanticTypeArgumentData> factory = new SemanticTypeArgumentDataFactory();

        var sut = factory.Handle(queryMock.Object);

        return new Fixture(sut, symbolMock);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly ISemanticTypeArgumentData Sut;

        private readonly Mock<ITypeSymbol> SymbolMock;

        public Fixture(
            ISemanticTypeArgumentData sut,
            Mock<ITypeSymbol> symbolMock)
        {
            Sut = sut;

            SymbolMock = symbolMock;
        }

        ISemanticTypeArgumentData IFixture.Sut => Sut;

        Mock<ITypeSymbol> IFixture.SymbolMock => SymbolMock;
    }
}
