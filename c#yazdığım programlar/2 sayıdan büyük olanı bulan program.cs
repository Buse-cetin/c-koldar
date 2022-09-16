using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iki_sayıdan_büyük_olanı_bulan_program
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("ilk sayıyı giriniz");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayıyı giriniz");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
                Console.WriteLine("ilk girilen sayı daha büyük" + a);
            else
                Console.WriteLine("2.girilen sayı daha büyük" + b);


        }
    }
}
