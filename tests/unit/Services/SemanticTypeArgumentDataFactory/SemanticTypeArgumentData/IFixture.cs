namespace Paraminter.Arguments.Semantic.Type.SemanticTypeArgumentData;

using Microsoft.CodeAnalysis;

using Moq;

internal interface IFixture
{
    public abstract ISemanticTypeArgumentData Sut { get; }

    public abstract Mock<ITypeSymbol> SymbolMock { get; }
}
