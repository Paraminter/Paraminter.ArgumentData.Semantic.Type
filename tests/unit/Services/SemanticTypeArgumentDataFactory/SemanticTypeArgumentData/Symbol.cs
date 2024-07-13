namespace Paraminter.Arguments.Semantic.Type.SemanticTypeArgumentData;

using Microsoft.CodeAnalysis;

using Xunit;

public sealed class Symbol
{
    private readonly IFixture Fixture = FixtureFactory.Create();

    [Fact]
    public void ReturnsSymbol()
    {
        var result = Target();

        Assert.Equal(Fixture.SymbolMock.Object, result);
    }

    private ITypeSymbol Target() => Fixture.Sut.Symbol;
}
