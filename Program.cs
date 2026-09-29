var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => new
{
    status = "OK",
    application = "DeployTestApi2",
    version = "1.0.0",
    message = "API TEST 2 - DEPLOY AUTOMÁTICO FUNCIONANDO!"
});

app.MapGet("/health", () => new
{
    status = "Healthy V2",
    application = "DeployTestApi2 V2",
    version = "1.0.1"
});

app.Run();