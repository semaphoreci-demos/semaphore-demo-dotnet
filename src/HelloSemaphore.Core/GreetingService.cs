namespace HelloSemaphore.Core;

public sealed class GreetingService
{
    public string CreateGreeting(string applicationName, string environmentName, DateTimeOffset timestamp)
    {
        if (string.IsNullOrWhiteSpace(applicationName))
        {
            throw new ArgumentException("Application name is required.", nameof(applicationName));
        }

        if (string.IsNullOrWhiteSpace(environmentName))
        {
            throw new ArgumentException("Environment name is required.", nameof(environmentName));
        }

        return $"Hello from {applicationName} on {environmentName} at {timestamp:O}";
    }
}

