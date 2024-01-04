var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "librosIndex",
    pattern: "{controller=Libros}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "AgregarLibros",
    pattern: "{controller=Libros}/{action=AgregarLibros}/{id?}");

app.MapControllerRoute(
    name: "QuitarLibros",
    pattern: "{controller=Libros}/{action=QuitarLibros}/{id?}");

app.MapControllerRoute(
    name: "editarLibro",
    pattern: "{controller=Libros}/{action=EditarLibros}/{id?}");


app.Run();
