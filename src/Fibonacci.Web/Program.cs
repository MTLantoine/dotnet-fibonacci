using Fibonacci;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

using var fibonacciDataContext = new FibonacciDataContext();

app.MapGet("/", () => "Hello Man!");
app.MapGet("/Fibonacci",
    async () => await new Compute(fibonacciDataContext).ExecuteAsync(new[] {"1", "2", "3", "4", "5", "6"}));

app.Run();
