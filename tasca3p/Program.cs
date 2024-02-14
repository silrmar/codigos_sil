using Microsoft.EntityFrameworkCore;
using tasca3p.Context;
using tasca3p.Repositories;
using tasca3p.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configurar o contexto da base de dados
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// o container nativo ir� criar uma inst�ncia da classe e injet�-la do reposit�rio para o controlador

builder.Services.AddTransient<ILanchesRepository, LanchesRepository>();
builder.Services.AddTransient<ICategoriaRepository, CategoriaRepository>();

var app = builder.Build();



// Adicionar outros servi�os
/*builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IMeuServico, MeuServico>();*/
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
    //adicionei esta linha para ver se resolvia.
app.MapRazorPages();

app.Run();
