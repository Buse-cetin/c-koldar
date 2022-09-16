using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201307037_BuseÇETİN
{
    class Öğrenci
    {
        string öğrenciadisoyadi;
        string bölüm;
        string TCno;
        string cinsiyet;
        string ders1;
        string ders2;
        string ders3;
        double not1;
        double not2;
        double not3;
        double başarınotu;
        public void OgrenciBilgileri(double başarınotu, string öğrenciadisoyadi, string ders1, string ders2, string ders3, double not1, double not2, double not3, string bölüm, string cinsiyet, string TCno)
        {

            this.öğrenciadisoyadi = öğrenciadisoyadi;
            this.bölüm = bölüm;
            this.cinsiyet = cinsiyet;
            this.TCno = TCno;
            this.ders1 = ders1;
            this.ders2 = ders2;
            this.ders3 = ders3;
            this.not1 = not1;
            this.not2 = not2;
            this.not3 = not3;
            this.başarınotu = başarınotu;
        }

       
        public void BaşarıNotu()
        {
            double sonuç = (not1 + not2 + not3) / 3;
        }


        public void Yazdir()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Öğrenci adı: " + öğrenciadisoyadi);
            Console.WriteLine("Öğrencinin okuduğu bölüm: " + bölüm);
            Console.WriteLine("Öğrencinin cinsiyeti: " + cinsiyet);
            Console.WriteLine("TC No: " + TCno);
            Console.WriteLine("Alınan dersler: " + (ders1, ders2, ders3));
            Console.WriteLine("Ders notları: " + (not1, not2, not3));
            Console.WriteLine("Başarı notu: " + başarınotu);
        }
        public Öğrenci()
        {
            Console.WriteLine("parametresiz kurucu çalıştı");

        }
        public Öğrenci(int a)
        {
            Console.WriteLine("bir parametreli kurucu çalıştı");
        }

        public Öğrenci(int g, int u)
        {
            Console.WriteLine("iki parametreli kurucu çalıştı");

        }

        public Öğrenci(Öğrenci OB)
        {
            Console.WriteLine("kopyalayıcı metod çalıştı..");
        }
        static void Main(string[] args)
        {
            void Bilgi()
            {
                string[] öğrenciadisoyadi = new string[3];
                string[] bölüm = new string[3];
                string[] TCno = new string[3];
                string[] cinsiyet = new string[3];
                string[] ders1 = new string[3];
                string[] ders2 = new string[3];
                string[] ders3 = new string[3];
                double[] not1 = new double[3];
                double[] not2 = new double[3];
                double[] not3 = new double[3];

                Kayıt();
                void Kayıt()
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine((i + 1) + ".Öğrenci Bİlgileri");
                        Console.WriteLine("Öğrencinin adını-soyadını giriniz: ");
                        öğrenciadisoyadi[i] = Console.ReadLine();
                        Console.WriteLine("Bölümü giriniz: ");
                        bölüm[i] = Console.ReadLine();
                        Console.WriteLine("TC kimlik numarasını giriniz:");
                        TCno[i] = Console.ReadLine();
                        Console.WriteLine("cinsiyetini belirtiniz:");
                        cinsiyet[i] = Console.ReadLine();
                        Console.WriteLine("Ders1:");
                        ders1[i] = Console.ReadLine();
                        Console.WriteLine("Ders2:");
                        ders2[i] = Console.ReadLine();
                        Console.WriteLine("ders3:");
                        ders3[i] = Console.ReadLine();
                        Console.WriteLine("not1:");
                        not1[i] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("not2:");
                        not2[i] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("not3:");
                        not3[i] = Convert.ToDouble(Console.ReadLine());

                    }
                }
                Öğrenci öğrenci1 = new Öğrenci();
                öğrenci1.OgrenciBilgileri(öğrenciadisoyadi, bölüm, TCno, cinsiyet, ders1, ders2, ders3); ; ; ; ;
                öğrenci1.Yazdir();

                Öğrenci öğrenci2 = new Öğrenci();
                
                öğrenci2.Yazdir();

                Öğrenci öğrenci3 = new Öğrenci();
               
                öğrenci3.Yazdir();
            }   
        
            Console.WriteLine();
            Console.ReadLine();
        }
        ~Öğrenci()
        {
            Console.WriteLine("yıkıcı çalıştı...");
        }
        
    }
   
}

    

