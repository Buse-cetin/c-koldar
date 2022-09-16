using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201307037_BUSE_ÇETİN
{
    class Program
    {
        public static void Fibo(int sayi)
        {
            int x = 0;
            int y = 1, z;
            int toplam = 0;
            Console.WriteLine();
            Console.WriteLine("\n");
            for (int i = 0; i < sayi - 1; i++)
            {
                z = x + y;
                x = y;
                y = z;
            }
            toplam = toplam + y;
            Console.WriteLine(toplam);
        }

        static int Fibonacci(int k)
        {
            if (k < 1)
            {
                return 0;
            }
            else if (k == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(k - 1) + Fibonacci(k - 2);
            }

        }
        static int usalma(int taban, int us)
        {
            if (us == 0)
                return 1;
            else
                return taban * usalma(taban, us - 1);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("*************************");
            Console.WriteLine("BuseÇETİN,201307037, Odev4, Ozyinelemeli Fonk.");
            Console.WriteLine("1-Fibonacci Hesaplama(iteratif");
            Console.WriteLine("2-Fibonacci Hesaplama(Özyinelemeli");
            Console.WriteLine("3-Üs Alma(özyinelemeli");
            Console.WriteLine("lütfen yapmak istediğiniz işlemi giriniz");
            Console.WriteLine("*************************");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b == 1)
            {
                Console.WriteLine("ilk olarak hangi sıradaki değeri görmek istersiniz?");
                int c = Convert.ToInt32(Console.ReadLine());
                Fibo(c);
                Console.WriteLine("Devam etmek istiyormusunuz?(E/H)");

            }
            if (b == 2)
            {
                Console.WriteLine("ilk olarak hangi sıradaki değeri görmek istersiniz?");
                int e = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Fibonacci(e));
                Console.WriteLine("Devam etmek istiyormusunuz?(E/H)");
            }
            if (b == 3)
            {
                Console.WriteLine("taban kaç olsun");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("üs kaç olsun");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(m + " üzeri " + n + ": " + usalma(m, n));
                Console.WriteLine("Devam etmek istiyormusunuz?(E/H)");

            }
            if (b == 4)
            {
                Console.WriteLine("çıkış");
            }
        }
        }
}
