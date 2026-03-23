using System.Diagnostics;
using HelloMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

//Controller : uygulamaya gelen istekleri karþýlayan ve gerekli cevaplarý hazýrlayarak geri dönderen yapýlardýr. Bu istekler controller classlarý içinde bulunan metodlar(action) tarafýndan iþletilir.
//Controller classlarý genellikle "Controllers" klasöründe bulunur ve "Controller" kelimesi ile biterler. Örneðin: HomeController, ProductController gibi. Controller classlarý, gelen istekleri karþýlamak için action metodlarý içerir. Bu metodlar, genellikle IActionResult türünde dönerler ve bu sayede farklý türde cevaplar döndürebilirler (örneðin: View(), Json(), Redirect() gibi). Controller classlarý, uygulamanýn iþ mantýðýný ve kullanýcý arayüzünü birbirinden ayýrarak daha düzenli ve bakýmý kolay bir yapý saðlarlar.