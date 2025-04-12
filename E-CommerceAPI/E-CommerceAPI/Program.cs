using System.Security.Cryptography.X509Certificates;
using E_CommerceAPI.Context;
using Microsoft.AspNetCore.Components.Forms;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

//Swagger
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<EcommerceContext, EcommerceContext>();

var app = builder.Build();

//Swagger 
app.UseSwagger();

app.UseSwaggerUI();

app.MapControllers();

app.Run();




























// Passo a passo da API

// 1 - Instalar os pacotes do Entity Framework <Core.Design> <Core.SqlServer> <Core.Tools>

// 2 - Realizar o Scaffold <dotnet tool install --global dotnet-ef>
// dotnet ef dbcontext scaffold "Data Source=NOTE-VINICIO\SQLEXPRESS;Initial Catalog=ECommerce;
// User Id=sa;Password=Senai@134;TrustServerCertificate=true;" Microsoft.EntityFrameworkCore.SqlServer
// --context-dir Context --output-dir Models

// 3 - Criar as pastas <Interfaces> <Repositories> <Controllers>

// 4 - Criar a interface, de cada model

// 5 - Criar a repository, de cada model

// 6 - Criar o Controller, de cada model