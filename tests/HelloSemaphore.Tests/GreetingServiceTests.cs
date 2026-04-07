using HelloSemaphore.Core;
using Xunit;

namespace HelloSemaphore.Tests;

public sealed class GreetingServiceTests
{
    [Fact]
    public void CreateGreeting_IncludesApplicationAndEnvironment()
    {
        var service = new GreetingService();
        var timestamp = new DateTimeOffset(2026, 3, 27, 10, 15, 30, TimeSpan.Zero);

        var result = service.CreateGreeting("HelloSemaphore", "ci", timestamp);

        Assert.Contains("HelloSemaphore", result);
        Assert.Contains("ci", result);
        Assert.Contains("2026-03-27T10:15:30.0000000+00:00", result);
    }

    [Fact]
    public void CreateGreeting_ThrowsWhenApplicationNameMissing()
    {
        var service = new GreetingService();

        Assert.Throws<ArgumentException>(() => service.CreateGreeting("", "ci", DateTimeOffset.UtcNow));
    }

    [Fact]
    public void CreateGreeting_ThrowsWhenEnvironmentMissing()
    {
        var service = new GreetingService();

        Assert.Throws<ArgumentException>(() => service.CreateGreeting("HelloSemaphore", "", DateTimeOffset.UtcNow));
    }
}
