using System.Collections;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Collections

            //Non-Genecric Collections: Object tipinde veri tutarlar. Tip güvenliği yoktur. Performans düşüklüğü vardır. Boxing-Unboxing işlemi yapılır.Elaman sayısı limiti yoktur.Bu acıdan dizilere kıyasla daha mantıklıdır.

            // var dizi = new int[2]; // Tip güvenliği vardır. Performans yüksektir. Boxing-Unboxing işlemi yapılmaz.
            // dizi[0] = 1;
            // dizi[1] = 2;

            // int sayi1 = 10 ,sayi2 = 20;
            // ArrayList list= new ArrayList();
            // list.Add("Gazi");
            // list.Add(10);//Boxing
            // list.Add(15);
            // list.Add(true);
            // list.Capacity = list.Count;
            // Console.WriteLine(list.Capacity);

            // Console.WriteLine((int)list[1]+ (int)list[2]);//Unboxing

            // Console.WriteLine(dizi[0] + dizi[1]);//Unboxing yapmamıza gerek yoktur.


            // //Generic Collections: Tip güvenliği vardır. Performans yüksektir. Boxing-Unboxing işlemi yapılmaz. Elaman sayısı limiti yoktur. Bu acıdan dizilere kıyasla daha mantıklıdır.

            // List<int> list2= new List<int>();
            // list2.Add(sayi1);
            // list2.Add(sayi2);

            // Console.WriteLine(list2[0] + list2[1]);//Unboxing yapmamıza gerek yoktur.Castinge gerek yoktur.

            // var test = new Test<int>();
            // test.value1 = 10;
            // test.value2 = 20;
            //Console.WriteLine(test.value1 + test.value2);

            // var test2 = new Test<string>();
            // test2.value1 = "Gazi";
            // test2.value2 = "Üniversitesi";

            ITest d = new Deneme();
            d.Yazdir("Gazi Üniversitesi");
            //t.Denemesayi = 10;


            //Deneme d = new Deneme();
            //d.Yazdir("Gazi Üniversitesi");
            //d.Denemesayi = 10;

            d=new Deneme2();
            d.Yazdir("Gazi Üniversitesi");
        }
    }

    //Generic class: Tip güvenliği vardır. Performans yüksektir. Boxing-Unboxing işlemi yapılmaz.
    class Test<T> 
    {
        public T value1;
        public T value2;

        //public void Yazdir()
        //{
        //    Console.WriteLine(value1 + value2);
        //}


        void Ekleme(T value) {
        
            //DBye ekleme işlemi yapılır.
        }




    }

    interface ITest
    {
        void Yazdir(string value);
    }

    class Deneme : ITest
    {

        public int Denemesayi { get; set; }
        public void Yazdir(string value)
        {
           Console.WriteLine(value);
        }
    }

    class Deneme2 : ITest
    {

        public int Deneme2sayi { get; set; }
        public void Yazdir(string value)
        {
            Console.WriteLine(value);
        }
    }


}


//Interface'ler bir class'ın base'i olarak kullanıldıklarında, calss içerisinde base interface'in gövdesi olmayan tüm üyeleri bulmak zorundadır.
//Farklı class!larda aynı interface'ler base olarak kullanılırsa,bu interface referansı ile bu classların nesneleri temsil edilebilir.
//Bu açılardan,Interface'ler classlar arası kullanılan bir standart gibi düşünülebilir.
