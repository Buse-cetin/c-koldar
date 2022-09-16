using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201307037_BuseÇetin_6._1
{
    class Program
    {

        static void deneme1() //static olarak tanımlanan metotları çağırmak için nesne tanımlamaya gerek yoktur.Direk sınıf ismiyle çağrılır.
        {
            Console.WriteLine("Deneme static..."); 
        }

        void deneme2()
        {
            Console.WriteLine("Deneme non-static...");
            deneme1(); //non-static metotların içine static metotları çağırabiliriz.
        }

        static void deneme3()
        {
            Console.WriteLine("Deneme3 static...");
            deneme1(); // static metotların içine static metotları çağırabiliriz.
            //deneme2(); yanlış kullanımdır!!! static metotların içine non-static metotları çağıramayız..
        }


        static int topla(int a, int b) //geridönüş değeri olan metotlar static olarak tanımlanır.
        {
            return a + b;
        }
        
        static void Main(string[] args)
        {
            //Program p1 = new Program();
           // p1.deneme1;          static tanımlı metotlara nesne üzerinden ulaşılamaz.
            Program.deneme1();   //static tanımlı metotlara sınıfın üzerinden direk ulaşılabilir.
            int sonuç = Program.topla(5, 4);
            Console.WriteLine("toplama işleminin sonucu:" + sonuç);
        }
    }
}
