using System.ComponentModel.DataAnnotations;

namespace HelloMVC.Models
{
    public class Ogrenci : Object
    {
        public int OgrenciId { get; set; }

        [Display(Name = "Adı")]
        public string Ad { get; set; }

        [Display(Name = "Soyadı")]
        public string Soyad { get; set; }

        [Display(Name = "Numarası")]
        public int Numara { get; set; }

        public override string ToString()
        {
            return $"Ad:{this.Ad} Soyad:{this.Soyad}";
        }
    }
}