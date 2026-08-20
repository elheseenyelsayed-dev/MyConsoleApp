using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);

var appSettings = builder.Configuration
    .GetSection("AppSettings")
    .Get<AppSettings>();

Console.WriteLine($"Environment: {appSettings?.EnvironmentName}");
Console.WriteLine($"Greeting: {appSettings?.Greeting}");
Console.WriteLine($"Password: {appSettings?.Password}");

public sealed class AppSettings
{
    public string Password { get; set; } = string.Empty;
    public string EnvironmentName { get; set; } = string.Empty;
    public string Greeting { get; set; } = string.Empty;
}