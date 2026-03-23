namespace HelloMVC.Models
{
    public class Ogretmen
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public override string ToString()
        {
            return $"{this.Ad} {this.Soyad}";
        }
    }
}
