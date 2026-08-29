using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);

builder.Configuration.AddUserSecrets<Program>(optional: true, reloadOnChange: true);

var appSettings = builder.Configuration.GetSection("AppSettings").Get<AppSettings>() ?? new AppSettings();

Console.WriteLine($"Environment: {appSettings.EnvironmentName}");
Console.WriteLine($"Greeting: {appSettings.Greeting}");
Console.WriteLine($"Password: {appSettings.Password}");
Console.WriteLine($"Max Num: {appSettings.MaxNumber}");

var P = new Person();
P.ID = 100;
P.Age = 25;
P.FirstName = "Ali";
P.LastName = "Ahmed";
P.DateOfBirth = new DateOnly(2008, 1, 1);

Console.WriteLine($"DoB: {P.DateOfBirth}");

public sealed class AppSettings
{
    public string Password { get; set; } = string.Empty;
    public string EnvironmentName { get; set; } = string.Empty;
    public string Greeting { get; set; } = string.Empty;
    public int MaxNumber {get; set; }
}