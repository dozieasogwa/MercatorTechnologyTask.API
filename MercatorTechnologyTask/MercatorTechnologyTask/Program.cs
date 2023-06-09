using Mercator.Core.MerchantServices.Interface;
using Mercator.Core.MerchantServices.Services;
using Mercator.Core.TerminalServices.Interface;
using Mercator.Core.TerminalServices.Services;
using Mercator.Core.TransactionServices.Interface;
using Mercator.Core.TransactionServices.Services;
using Mercator.Data.Domain.AggregateModel.Entities;
using Mercator.Data.Domain.Infrastructure;
using Mercator.Data.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IMerchantServices, MerchantServices>();
builder.Services.AddScoped<ITerminalServices, TerminalServices>();
builder.Services.AddScoped<ITransactionServices, TransactionServices>();
builder.Services.AddTransient<IGenericRepository<Merchant>, GenericRepository<Merchant>>();
builder.Services.AddTransient<IGenericRepository<Terminal>, GenericRepository<Terminal>>();
builder.Services.AddTransient<IGenericRepository<Transaction>, GenericRepository<Transaction>>();
builder.Services.AddDbContext<MercatorContext>(options =>
options.UseSqlServer((builder.Configuration.GetConnectionString("Mercator"))));

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
