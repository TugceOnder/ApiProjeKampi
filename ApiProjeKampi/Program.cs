using ApiProjeKampi.Entities;
using ApiProjeKampi.WebApi.Context;
using ApiProjeKampi.WebApi.ValidationRules;
using ApiProjeKampi.WebUI.Dtos.CategoryDtos;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApiContext>();
builder.Services.AddControllers();
builder.Services.AddScoped<IValidator<Product>, ProductValidator>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// AutoMapper
builder.Services.AddAutoMapper(cfg =>
{
    cfg.CreateMap<CreateCategoryDto, Category>();
    cfg.CreateMap<UpdateCategoryDto, Category>();
}, typeof(Program));

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