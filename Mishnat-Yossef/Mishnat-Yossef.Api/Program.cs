using Microsoft.EntityFrameworkCore;
using mishnat_yossef.data.repository;
using Mishnat_Yossef.Core.Entities;
using Mishnat_Yossef.Core.InterfaceRepository;
using Mishnat_Yossef.Core.InterfaceService;
using Mishnat_Yossef.Data;
using MIshnat_Yossef.Service.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddSingleton<IdataContext, DataContext>();
builder.Services.AddDbContext< DataContext>(option =>
{
    option.UseSqlServer("Data Source = sqlsrv; Initial Catalog = Mishnat-Yossef; Integrated Security = true; ");
    //  "User ID = shuli; Password = 1234; TrustServerCertificate = True; Encrypt = False");
});
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IUserService, UserServicse>();
builder.Services.AddScoped<ISellingService, SellingServicse>();
builder.Services.AddScoped<IStationService, StationServicse>();

builder.Services.AddScoped<IRepository<,Repository<T>>, Repository();
builder.Services.AddScoped<IRepository<Order>, OrderRepository>();
builder.Services.AddScoped<IRepository<Product>, ProductRepository>();
builder.Services.AddScoped<IRepository<Selling>, SellingRepositoty>();
builder.Services.AddScoped<IRepository<Station>, StationRepository>();


builder.Services.AddControllers();




// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
