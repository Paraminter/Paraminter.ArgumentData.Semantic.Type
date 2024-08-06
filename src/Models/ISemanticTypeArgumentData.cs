namespace Paraminter.Arguments.Semantic.Type.Models;

using Microsoft.CodeAnalysis;

using Paraminter.Arguments.Models;

/// <summary>Represents semantic data about a type argument.</summary>
public interface ISemanticTypeArgumentData
    : IArgumentData
{
    /// <summary>The symbol associated with the type argument.</summary>
    public abstract ITypeSymbol Symbol { get; }
}
