using HelloMVC.Data;
using HelloMVC.Models;
using HelloMVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{
    public class BaseController : Controller
    {
        // EF Core veritabanı oturumu için DbContext referansı
        private readonly AppDbContext _context;

        // DI container constructor injection ile DbContext'i sağlar
        public BaseController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var lst = new List<Ogrenci>
            {
                 new Ogrenci(){ Ad = "Ali", Soyad = "Veli", Numara = 1 },
                 new Ogrenci(){ Ad = "Ayşe", Soyad = "Fatma", Numara = 2 },
            };

            return View("index", lst);
        }

        public ViewResult Detay()
        {
            // dynamic ogr = new Ogrenci(); bu kısım önemli çünkü viewbag dinamik tanımlıdır. 
            // Runtime sırasında çözümlenir. object tipinde veri tutar.
            var ogr = new Ogrenci();
            ogr.Ad = "Ali";
            ogr.Soyad = "viewdata";

            var ogrt = new Ogretmen();
            ogrt.Ad = "Ahmet";
            ogrt.Soyad = "Akınkoç";

            var vm = new DetayVM();
            vm.Ogrenci = ogr;
            vm.Ogretmen = ogrt;

            // ViewData veri taşıma yöntemidir, Key-Value Pair şeklinde çalışır. Object tipinde veri tutar.
            ViewData["Ogrenci"] = ogr;

            // ViewBag ViewData koleksiyonunu kullanır, dinamik tanımlıdır runtime sırasında çözümlenir.
            ViewBag.Student = ogr;

            // VİEW önce action isminde dosya arar (Views/Base/Detay.cshtml), sonra Shared klasöründe arar. 
            // Bulamazsa hata verir. Bu yüzden view adını açıkça belirtmek bazı durumlarda daha sağlıklı olabilir.
            return View("Detay", vm); // Tek bir nesne (vm) gönderiliyor.
        }

        public ViewResult OgrenciEkle(Ogrenci fc)
        {
            List<Ogrenci> list = null;
            list = _context.Ogrenciler.ToList();

            return View(list);
        }


        public ViewResult OgrenciDetay(int id)
        {
            Ogrenci ogr = null;
            ogr = _context.Ogrenciler.Find(id);
            return View(ogr);
        }
    }

}






//viewdata veri taşıma yöntemdir Key-Value Pair şeklinde çalışır. object tipinde veri tutar.
            //viewbag view data koleksiyonunu kullanır key-value pair şeklinde çalışır.dinamik tanımlıdır runtime sırasında çözümlenir. Object tipinde veri tutar.
            //Object tipinde veri taşırlar ancak içindeki veriler runtime sırasında çözümlenir. Veri tipleri belli olur.

            //VİEW önce classın isminde dosya arar views icinde sonra shared klasöründe arar. eger bulamazsa hata verir. bu yüzden view adını vermek daha sağlıklı olur. eğer view adı verilmezse class adıyla aynı olan view dosyası aranır. bu yüzden view adını vermek daha sağlıklı olur.
        