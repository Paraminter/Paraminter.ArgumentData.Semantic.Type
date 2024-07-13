namespace Paraminter.Arguments.Semantic.Type;

using Paraminter.Arguments.Semantic.Type.Queries;
using Paraminter.Queries.Handlers;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        SemanticTypeArgumentDataFactory sut = new();

        return new Fixture(sut);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IQueryHandler<IGetSemanticTypeArgumentDataQuery, ISemanticTypeArgumentData> Sut;

        public Fixture(
            IQueryHandler<IGetSemanticTypeArgumentDataQuery, ISemanticTypeArgumentData> sut)
        {
            Sut = sut;
        }

        IQueryHandler<IGetSemanticTypeArgumentDataQuery, ISemanticTypeArgumentData> IFixture.Sut => Sut;
    }
}
