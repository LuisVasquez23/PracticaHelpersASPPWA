using Microsoft.EntityFrameworkCore;
using WebMVC_PWA.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


// TODO: Agregar la conexion a la DB
const string CONNECTION_NAME = "equiposDB";

// Obtener la cadena de conexion del appsetting
var connectionString = builder.Configuration.GetConnectionString(CONNECTION_NAME);

// Agregar contexto
builder.Services.AddDbContext<EquipoContext>(options => options.UseSqlServer(connectionString));


var app = builder.Build();

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
    pattern: "{controller=equipo}/{action=Index}/{id?}");

app.Run();
