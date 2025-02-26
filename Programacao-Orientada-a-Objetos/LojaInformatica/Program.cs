using LojaInfo.Data;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
//Add services to the container.
builder.Services.AddControllersWithViews();
var conexao = builder.Configuration.GetConnectionString("StringConexao");
builder.Services.AddDbContext<ContextoDB>(options => options.UseMySQL(conexao));
var app = builder.Build();
//Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    //The default HSTS value is 30 days. You may eant to change this for productions scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
