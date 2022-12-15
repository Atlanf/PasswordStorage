using PasswordStorage.Data.Extensions;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.RegisterServices(builder.Configuration);

app.Run();