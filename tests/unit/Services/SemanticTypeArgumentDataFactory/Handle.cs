namespace Paraminter.Arguments.Semantic.Type;

using Moq;

using Paraminter.Arguments.Semantic.Type.Queries;

using System;

using Xunit;

public sealed class Handle
{
    private readonly IFixture Fixture = FixtureFactory.Create();

    [Fact]
    public void NullQuery_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidQuery_ReturnsAssociatedArgumentData()
    {
        var result = Target(Mock.Of<IGetSemanticTypeArgumentDataQuery>());

        Assert.NotNull(result);
    }

    private ISemanticTypeArgumentData Target(
        IGetSemanticTypeArgumentDataQuery query)
    {
        return Fixture.Sut.Handle(query);
    }
}
