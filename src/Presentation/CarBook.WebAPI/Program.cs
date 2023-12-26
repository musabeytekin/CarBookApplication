using CarBook.Application.Interfaces;
using CarBook.Application.Services;
using CarBook.Persistence.Context;
using CarBook.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<CarBookContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CarBookDB")));
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
// builder.Services.AddScoped<GetAboutQueryHandler>();
// builder.Services.AddScoped<GetAboutByIdQueryHandler>();
// builder.Services.AddScoped<CreateAboutCommandHandler>();
// builder.Services.AddScoped<UpdateAboutCommandHandler>();
// builder.Services.AddScoped<DeleteAboutCommandHandler>();
//
// builder.Services.AddScoped<GetBannerQueryHandler>();
// builder.Services.AddScoped<GetBannerByIdQueryHandler>();
// builder.Services.AddScoped<CreateBannerCommandHandler>();
// builder.Services.AddScoped<UpdateBannerCommandHandler>();
// builder.Services.AddScoped<DeleteBannerCommandHandler>();

builder.Services.AddApplicationService(builder.Configuration);

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();