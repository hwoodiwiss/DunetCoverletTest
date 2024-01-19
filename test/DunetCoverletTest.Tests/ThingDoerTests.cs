
using DunetCoverletTest;

public sealed class ThingDoerTests
{
    [Fact]
    public void ThingDoerDoesThing()
    {
        ThingDoer.DoThing().ShouldBeTrue();
    }
}
