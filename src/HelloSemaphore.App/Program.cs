using HelloSemaphore.Core;

var applicationName = Environment.GetEnvironmentVariable("DEMO_APP_NAME") ?? "HelloSemaphore";
var environmentName = Environment.GetEnvironmentVariable("DEMO_ENVIRONMENT") ?? "local";

var greetingService = new GreetingService();
var message = greetingService.CreateGreeting(applicationName, environmentName, DateTimeOffset.UtcNow);

Console.WriteLine(message);

