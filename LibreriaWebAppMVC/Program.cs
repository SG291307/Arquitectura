using Libreria.LogicaAccesoDatos;
using Libreria.LogicaAccesoDatos.Repositorios;
using Libreria.LogicaAplicacion.CasosUso.CUPais;
using Libreria.LogicaAplicacion.ICasosUso.ICUPais;
using Libreria.LogicaNegocio.IRepositorios;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configurar la cadena de conexión (desde appsettings.json)
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//DefaultConnection debe coincidir con el nombre designado en el JSON.
// Registrar el DbContext en el contenedor de servicios
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));


// Add services to the container.
builder.Services.AddControllersWithViews();


//Inyeccion dependencias REPOS
builder.Services.AddScoped<IRepositorioPais, RepositorioPais>();


//Inyeccion de Dependencias - Casos de uso
builder.Services.AddScoped<ICUAltaPais, CUAltaPais>();
builder.Services.AddScoped<ICUObtenerPaises, CUObtenerPaises>();
builder.Services.AddScoped<ICUObtenerPaisXCodigo, CUObtenerPaisXCodigo>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
