using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello Man!");
app.MapGet("/Fibonacci",
    async () => await Fibonacci.Compute.ExecuteAsync(new[] {"1", "2", "3", "4", "5", "6"}));

app.Run();
