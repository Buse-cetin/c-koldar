using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201307037_BuseÇetin_Odev5
{
    class Dortgen
    {
        static void Main(string[] args)
        {
            Console.WriteLine("en değerini giriniz");
            int en = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("boy değerini giriniz");
            int boy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*****************");
            Console.WriteLine("en değeri: " + en);
            Console.WriteLine("boy değeri: " + boy);
            int alan = en * boy;
            Console.WriteLine("Alan: " + alan);
            Dortgen dortgen2 = new Dortgen();
            if (en == boy)
            {
                Console.WriteLine("Bu bir karedir!");
            }
            else
                Console.WriteLine("Bu bir kare değildir!!!");
            Console.WriteLine("*****************************");
            Console.WriteLine("*****************************");
        }
    }
}
