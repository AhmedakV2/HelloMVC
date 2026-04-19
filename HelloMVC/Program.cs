using Microsoft.EntityFrameworkCore;

namespace HelloMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<Data.AppDbContext>(options =>
                options.UseSqlServer(connectionString));



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
//kestrel sunucularý ASP.NET Core uygulamalarýný barýndýrmak için kullanýlan yüksek performanslý, çapraz platformlu web sunucularýdýr. Kestrel, ASP.NET Core'un varsayýlan web sunucusudur ve hem Windows hem de Linux üzerinde çalýþabilir. Kestrel, HTTP/1.x, HTTP/2 ve HTTP/3 protokollerini destekler ve genellikle ters proxy sunucularý (örneðin Nginx veya Apache) ile birlikte kullanýlýr. Kestrel, düþük gecikme süresi ve yüksek verimlilik saðlamak için optimize edilmiþtir, bu da onu modern web uygulamalarý için ideal bir seçim haline getirir.

//IIS internet information services, Microsoft tarafýndan geliþtirilen ve Windows iþletim sistemi üzerinde çalýþan bir web sunucusudur. IIS, ASP.NET uygulamalarýný barýndýrmak için yaygýn olarak kullanýlýr ve HTTP/1.x protokolünü destekler. IIS, güvenlik, yönetim ve performans özellikleri sunar ve genellikle Kestrel gibi bir ters proxy sunucusu ile birlikte kullanýlýr. IIS, özellikle Windows tabanlý sunucularda ASP.NET uygulamalarýný barýndýrmak için tercih edilen bir seçenektir.

//MVC (Model-View-Controller) yazýlým mimarisi desenidir. MVC, uygulamalarý üç ana bileþene ayýrarak geliþtirme sürecini düzenler: Model, View ve Controller. Model, uygulamanýn veri yapýsýný ve iþ mantýðýný temsil eder. View, kullanýcý arayüzünü ve kullanýcýya gösterilen içeriði temsil eder. Controller ise kullanýcý etkileþimlerini yönetir, Model ve View arasýnda iletiþimi saðlar. MVC, uygulama geliþtirmeyi daha modüler ve sürdürülebilir hale getirir, çünkü her bileþen kendi sorumluluklarýna odaklanýr ve birbirlerinden baðýmsýz olarak geliþtirilebilir. ASP.NET Core MVC, Microsoft'un ASP.NET Core framework'ü üzerinde MVC desenini uygulayan bir web uygulama geliþtirme platformudur.