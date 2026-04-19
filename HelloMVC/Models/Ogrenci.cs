namespace HelloMVC.Models
{

    public class Ogrenci
    {

        public int Id { get; set; }
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public override string ToString() =>$"{this.Ad} {this.Soyad}";
        

    }
}
