
using Application.Services;
using AsdWebApi.Configuration;
using Domain.Token;
using Microsoft.AspNetCore.Authentication.Negotiate;
using Repository.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthentication(NegotiateDefaults.AuthenticationScheme)
   .AddNegotiate();

builder.Services.Configure<CustomTokenOption>(builder.Configuration.GetSection("TokenOptions"));
builder.Services.AddScoped<ITokenService, TokenService>();
//SPECIAL CONFIGURES
builder.Services.ConfigureDatabase(builder.Configuration);
builder.Services.ConfigureSwaggerSetting();
builder.Services.ConfigureAuthentication(builder.Configuration);
builder.Host.ConfigureDependency();


builder.Services.AddAuthorization(options =>
{
    options.FallbackPolicy = options.DefaultPolicy;
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
