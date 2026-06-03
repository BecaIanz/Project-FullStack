var builder = WebApplication.CreateBuilder(args);

builder.Services.AddServices();
builder.Services.AddUseCases();
builder.Services.ConfigureDb();

var app = builder.Build();
await app.Migrate();
app.Run();