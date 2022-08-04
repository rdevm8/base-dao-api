using Microsoft.EntityFrameworkCore;
using base_dao_api.Data;
using base_dao_api.GraphQl;
using AutoMapper;
using base_dao_api.Utilities.MapperConfiguration;
using base_dao_api.Repositories.UnitOfWork.Interfaces;
using base_dao_api.Repositories.UnitOfWork;
using base_dao_api.GraphQl.Queries;
using base_dao_api.GraphQl.Mutations;
using FluentValidation.AspNetCore;
using AppAny.HotChocolate.FluentValidation;
using base_dao_api.GraphQl.Validators;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

// AutoMapper Configuration
var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new AutoMapperProfile());
});

var mapper = config.CreateMapper();

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder =>
        {
            builder.WithOrigins("*")
                   .AllowAnyHeader();
        });
});

// Conigure Fluent Validations
builder.Services.AddFluentValidation();
builder.Services.AddTransient<FaqPayloadValidator>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddTypeExtension<FaqQuery>()
    .AddTypeExtension<FaqMutation>()
    .AddProjections()
    .AddFiltering()
    .AddSorting()
    .AddFluentValidation(o =>
    {
        o.UseDefaultErrorMapper();
    });

//AUTO MAPPER
builder.Services.AddSingleton(mapper);

//builder.Services.AddPooledDbContextFactory<ApplicationDbContext>(options =>
//options.UseSqlServer(configuration.GetConnectionString("SqlServer")));

builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(configuration.GetConnectionString("SqlServer")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.MapGraphQL("/graphql");

app.Run();
