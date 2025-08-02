// -----------------------------------------------------------------------------
// 📄 Arquivo: Program.cs
// 📦 Raiz do projeto (Aviator.Api)
//
// 🧠 O que ele representa:
// Ponto de entrada da aplicação ASP.NET Core. Configura todos os serviços,
// como controllers, Swagger, MediatR, DbContext e aplica as migrations.
//
// 🛠️ Etapas principais:
// - Configura injeção de dependência (Application, Infra)
// - Adiciona controllers e Swagger
// - Aplica migrations automaticamente no dev
// - Inicia o servidor com MapControllers
//
// 🧪 Onde pode ser usado:
// - Para iniciar a API
// - Para debugar erros de inicialização
// --
using Aviator.Application;
using Aviator.Domain.Interface;
using Aviator.Infrastruct;
using Aviator.Infrastruct.Data;
using Aviator.Infrastruct.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Registra o DbContext e os repositórios em um único lugar (infraestrutura)
builder.Services.AddInfrastructServices(builder.Configuration);

// Registra outros serviços da camada Application (como MediatR, AutoMapper, etc)
builder.Services.AddApplicationServices();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    // Aplica migrações automaticamente no dev
    using (var scope = app.Services.CreateScope())
    {
        var dbContext = scope.ServiceProvider.GetRequiredService<BlogDbContext>();
        dbContext.Database.Migrate();
    }
}

app.UseAuthorization();
app.MapControllers();

app.Run();