namespace Paraminter.Arguments.Semantic.Type;

using Microsoft.CodeAnalysis;

using Paraminter.Arguments.Semantic.Type.Queries;
using Paraminter.Queries.Handlers;

using System;

/// <summary>Handles creation of <see cref="ISemanticTypeArgumentData"/>.</summary>
public sealed class SemanticTypeArgumentDataFactory
    : IQueryHandler<IGetSemanticTypeArgumentDataQuery, ISemanticTypeArgumentData>
{
    /// <summary>Instantiates a <see cref="SemanticTypeArgumentDataFactory"/>, handling creation of <see cref="ISemanticTypeArgumentData"/>.</summary>
    public SemanticTypeArgumentDataFactory() { }

    ISemanticTypeArgumentData IQueryHandler<IGetSemanticTypeArgumentDataQuery, ISemanticTypeArgumentData>.Handle(
        IGetSemanticTypeArgumentDataQuery query)
    {
        if (query is null)
        {
            throw new ArgumentNullException(nameof(query));
        }

        return new SemanticTypeArgumentData(query.Symbol);
    }

    private sealed class SemanticTypeArgumentData
        : ISemanticTypeArgumentData
    {
        private readonly ITypeSymbol Symbol;

        public SemanticTypeArgumentData(
            ITypeSymbol symbol)
        {
            Symbol = symbol;
        }

        ITypeSymbol ISemanticTypeArgumentData.Symbol => Symbol;
    }
}
