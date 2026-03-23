using System.Collections;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Collections

            //Non-Genecric Collections: Object tipinde veri tutarlar. Tip güvenliği yoktur. Performans düşüklüğü vardır. Boxing-Unboxing işlemi yapılır.Elaman sayısı limiti yoktur.Bu acıdan dizilere kıyasla daha mantıklıdır.

            var dizi = new int[2]; // Tip güvenliği vardır. Performans yüksektir. Boxing-Unboxing işlemi yapılmaz.
            dizi[0] = 1;
            dizi[1] = 2;

            int sayi1 = 10 ,sayi2 = 20;
            ArrayList list= new ArrayList();
            list.Add("Gazi");
            list.Add(10);//Boxing
            list.Add(15);
            list.Add(true);
            list.Capacity = list.Count;
            Console.WriteLine(list.Capacity);

            Console.WriteLine((int)list[1]+ (int)list[2]);//Unboxing

            Console.WriteLine(dizi[0] + dizi[1]);//Unboxing yapmamıza gerek yoktur.


            //Generic Collections: Tip güvenliği vardır. Performans yüksektir. Boxing-Unboxing işlemi yapılmaz. Elaman sayısı limiti yoktur. Bu acıdan dizilere kıyasla daha mantıklıdır.

            List<int> list2= new List<int>();
            list2.Add(sayi1);
            list2.Add(sayi2);

            Console.WriteLine(list2[0] + list2[1]);//Unboxing yapmamıza gerek yoktur.Castinge gerek yoktur.

            var test = new Test<int>();
            test.value1 = 10;
            test.value2 = 20;
           Console.WriteLine(test.value1 + test.value2);

            var test2 = new Test<string>();
            test2.value1 = "Gazi";
            test2.value2 = "Üniversitesi";
        }
    }

    class Test<T> 
    {
        public T value1;
        public T value2;

        //public void Yazdir()
        //{
        //    Console.WriteLine(value1 + value2);
        //}

    }
}
