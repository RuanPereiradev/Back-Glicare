using Aviator.Application;
using Aviator.Infrastruct;
using Aviator.Infrastruct.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configuração dos serviços
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructServices(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configuração do pipeline de requisições HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    
    // Aplica migrações automaticamente apenas em desenvolvimento
    using (var scope = app.Services.CreateScope())
    {
        var dbContext = scope.ServiceProvider.GetRequiredService<BlogDbContext>();
        dbContext.Database.Migrate(); // Aplica migrações pendentes
    }
}

app.UseAuthorization();
app.MapControllers();

app.Run();