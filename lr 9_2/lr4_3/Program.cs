using lr4_3.Repositories.Implementations;
using lr4_3.Repositories.Interfaces;
using lr4_3.Services.Implementations;
using lr4_3.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);







// Repositories
builder.Services.AddSingleton<IRestaurantRepository, RestaurantRepository>();
builder.Services.AddSingleton<IMenuItemRepository, MenuItemRepository>();
builder.Services.AddSingleton<IUserRepository, UserRepository>();
builder.Services.AddSingleton<IOrderRepository, OrderRepository>();

// Services
builder.Services.AddScoped<IRestaurantService, RestaurantService>();
builder.Services.AddScoped<IMenuItemService, MenuItemService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IOrderService, OrderService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
var port = Environment.GetEnvironmentVariable("PORT") ?? "5000";
app.Urls.Add($"http://0.0.0.0:{port}");
app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(Int32.Parse(port));
});