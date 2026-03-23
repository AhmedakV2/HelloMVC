using HelloMVC.Models;
using HelloMVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{
    public class BaseController : Controller
    {
        public IActionResult Index()
        {


            return View();
        }
        public ViewResult Detay()
        {

            //dynamic ogr = new Ogrenci(); bu kısım önemli çünkü viewbag dinamik tanımlıdır. runtime sırasında çözümlenir. object tipinde veri tutar.
            var ogr = new Ogrenci();
            ogr.Ad = "Ali";
            ogr.Soyad = "viewdata";

            var ogrt = new Ogretmen();
            ogrt.Ad = "Ahmet";
            ogrt.Soyad = "Akınkoç";

            var vm = new DetayVM();
            vm.Ogrenci = ogr;
            vm.Ogretmen = ogrt;

            ViewData["Ogrenci"] = ogr;
            ViewBag.Student = ogr;

            return View("Detay", vm);  
            
            
            
        }

        //viewdata veri taşıma yöntemdir Key-Value Pair şeklinde çalışır. object tipinde veri tutar.
        //viewbag view data koleksiyonunu kullanır key-value pair şeklinde çalışır.dinamik tanımlıdır runtime sırasında çözümlenir. Object tipinde veri tutar.
        //Object tipinde veri taşırlar ancak içindeki veriler runtime sırasında çözümlenir. Veri tipleri belli olur.

        //VİEW önce classın isminde dosya arar views icinde sonra shared klasöründe arar. eger bulamazsa hata verir. bu yüzden view adını vermek daha sağlıklı olur. eğer view adı verilmezse class adıyla aynı olan view dosyası aranır. bu yüzden view adını vermek daha sağlıklı olur.
    }
}
