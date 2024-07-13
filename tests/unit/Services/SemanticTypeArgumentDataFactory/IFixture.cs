namespace Paraminter.Arguments.Semantic.Type;

using Paraminter.Arguments.Semantic.Type.Queries;
using Paraminter.Queries.Handlers;

internal interface IFixture
{
    public abstract IQueryHandler<IGetSemanticTypeArgumentDataQuery, ISemanticTypeArgumentData> Sut { get; }
}
