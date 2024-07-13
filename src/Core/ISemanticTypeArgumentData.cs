namespace Paraminter.Arguments.Semantic.Type;

using Microsoft.CodeAnalysis;

/// <summary>Represents semantic data about a type argument.</summary>
public interface ISemanticTypeArgumentData
{
    /// <summary>The symbol associated with the type argument.</summary>
    public abstract ITypeSymbol Symbol { get; }
}
