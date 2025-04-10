using System.Security.Cryptography.X509Certificates;
using E_CommerceAPI.Context;
using Microsoft.AspNetCore.Components.Forms;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddTransient<EcommerceContext, EcommerceContext>();

var app = builder.Build();

app.MapControllers();

app.Run();