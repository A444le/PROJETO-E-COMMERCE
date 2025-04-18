using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using E_CommerceAPI.Context;
using E_CommerceAPI.Interfaces;
using E_CommerceAPI.Repositorios;
using Microsoft.AspNetCore.Components.Forms;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

//Swagger
builder.Services.AddSwaggerGen();

//O .NET vai criar os objetos (Injecao de dependencia)

//AddTransient - o C# cria uma instancia nova, toda vez quando o metodo e chamado.
//AddScoped - O C# cria uma instancia nova, toda vez quando ele criar um controller.
//Addsingleton - 

builder.Services.AddScoped<EcommerceContext>();
builder.Services.AddTransient<IProdutoRepository, ProdutoRepository>();
builder.Services.AddTransient<IClienteRepository, ClienteRepository>();
builder.Services.AddTransient<IpagamentoRepository, PagamentoRepository>();


var app = builder.Build(); //O C# cosntroi o site por meio desse codigo

//Swagger 
app.UseSwagger();

app.UseSwaggerUI();

app.MapControllers();

app.Run(); //E o iniciar do site, aplicativo





























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