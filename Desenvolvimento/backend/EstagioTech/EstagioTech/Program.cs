using EstagioTech.Data;
using EstagioTech.Repositorios;
using EstagioTech.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace EstagioTech
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<DBContex>(options =>
                          options.UseNpgsql(connectionString));

            builder.Services.AddTransient<ITipoEstagioRepositorio, TipoEstagioRepositorio>();
            builder.Services.AddTransient<ICursoRepositorio, CursoRepositorio>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}