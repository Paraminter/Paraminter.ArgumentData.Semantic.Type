namespace Paraminter.Arguments.Semantic.Type.Queries;

using Microsoft.CodeAnalysis;

using Paraminter.Queries;

/// <summary>Represents a query for semantic data about a type argument.</summary>
public interface IGetSemanticTypeArgumentDataQuery
    : IQuery
{
    /// <summary>The symbol associated with the type argument.</summary>
    public abstract ITypeSymbol Symbol { get; }
}
