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
using base_dao_api.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Claims;
using base_dao_api.Utilities.Interceptors;
using Microsoft.Extensions.Options;

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

// Conigure Fluent Validations and Validators
builder.Services.AddFluentValidation();
builder.Services.AddTransient<FaqPayloadValidator>();
builder.Services.AddTransient<LoginPayloadValidator>();
builder.Services.AddTransient<PoolPayloadValidator>();
builder.Services.AddTransient<PoolStatusPayloadValidator>();
builder.Services.AddTransient<PoolFunderPayloadValidator>();


// Setting Up JWT Authentication
builder.Services.Configure<TokenSettings>(configuration.GetSection("TokenSettings"));
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidIssuer = configuration.GetSection("TokenSettings").GetValue<string>("Issuer"),
            ValidateIssuer = true,
            ValidAudience = configuration.GetSection("TokenSettings").GetValue<string>("Audience"),
            ValidateAudience = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration.GetSection("TokenSettings").GetValue<string>("Key"))),
            ValidateIssuerSigningKey = true
        };
    });


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<FaqQuery>();
builder.Services.AddScoped<FaqMutation>();
builder.Services.AddScoped<LoginMutation>();
builder.Services.AddScoped<PoolMutation>();
builder.Services.AddScoped<PoolFunderMutation>();
builder.Services.AddGraphQLServer()
    .RegisterService<IUnitOfWork>()
    //.AddHttpRequestInterceptor<HttpRequestInterceptor>()
    .AddQueryType()
    .AddMutationType()
    .AddTypeExtension<FaqQuery>()
    .AddTypeExtension<FaqMutation>()
    .AddTypeExtension<LoginMutation>()
    .AddTypeExtension<PoolMutation>()
    .AddTypeExtension<PoolFunderMutation>()
    .AddAuthorization()
    .AddProjections()
    .AddFiltering()
    .AddSorting()
    .AddFluentValidation(o =>
    {
        o.UseDefaultErrorMapper();
    });
//AUTO MAPPER
builder.Services.AddSingleton(mapper);

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

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.MapGraphQL("/graphql");

app.Run();
