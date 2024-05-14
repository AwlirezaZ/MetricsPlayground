using Prometheus;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseMetricServer();
app.UseHttpMetrics();
app.MapGet("/test", () =>
{
    return "hey dude! i'm waiting fo yo cookin here";
});

app.Run();

