using CoreRazorPages.Repository;
using CoreRazorPages.Services.Implementation;
using CoreRazorPages.Services.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
builder.Services.AddDbContext<ApplicaionDbContext>(option =>
    option.UseSqlServer(builder.Configuration.GetConnectionString("AzureDBConnection")));

builder.Services.AddTransient<IEmployee, EmployeeService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
