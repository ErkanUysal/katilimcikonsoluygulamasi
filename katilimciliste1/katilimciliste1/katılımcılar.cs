using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace katilimciliste1
{
    public class katılımcılar
    {
        uye[] uyeler;
        public katılımcılar()
        {
            uyeler = new uye[0];

        }
        public void uyeEkle(uye uye1)
        {
            uye[] yenidizi = new uye[uyeler.Length + 1];
            Array.Copy(uyeler, yenidizi, uyeler.Length);
            yenidizi[uyeler.Length] = uye1;
            uyeler = yenidizi;
        }
        public void veriGetir()
        {
            string secenek = "e";
            while (secenek == "e")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("*-*-*kATILIMCI KAYIT EKRANINA HOŞGELDİNİZ*-*-*");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Yeni Katılımcı İsmi = ");
                Console.ForegroundColor = ConsoleColor.White;
                string ka = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Yeni Katılımcı Soyismi = ");
                Console.ForegroundColor = ConsoleColor.White;
                string ks = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Yeni Katılımcının Şehri = ");
                Console.ForegroundColor = ConsoleColor.White;
                string ki = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Yeni Katılımcı Üyelik Durumu e / h = ");
                Console.ForegroundColor = ConsoleColor.White;
                string ku = Console.ReadLine();
                uye uye12 = new uye
                {
                    Isim = ka,
                    Soyisim = ks,
                    Sehir = ki,
                    Uyemi = ku

                };
                uyeEkle(uye12);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Devam Etmek İstiyor musunuz? e / h = ");
                Console.ForegroundColor = ConsoleColor.White;
                secenek = Console.ReadLine();
                Console.Clear();
               


            }

        }
        public void listele()
        {
            int a = 0;
            Console.WriteLine("*-*-*BÜTÜN KATILIMCILAR*-*-*");
            for (int i = 0; i < uyeler.Length; i++)
            {
                a++;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{a}. Katılımcı");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Üye İsmi = ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{uyeler[i].Isim}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Katılımcı Soyismi = ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{uyeler[i].Soyisim}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Katılımcı Şehiri = ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(uyeler[i].Sehir);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Katılımcının Üyelik Durumu = ");
                Console.ForegroundColor = ConsoleColor.White;
                if (uyeler[i].Uyemi == "e")
                {
                    Console.WriteLine("Aktif\n");
                }
                else { Console.WriteLine("Pasif\n"); }
               
            }
           
        }
        public void uyegetir()
        {
            int a = 0;
            Console.WriteLine("*-*-*ÜYE KATILIMCILAR*-*-*");
            for (int i = 0; i < uyeler.Length; i++)
            {
                if (uyeler[i].Uyemi == "e")
                {
                    a++;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write($"ÜYE OLAN {a}. KATILIMCI\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Üye İsmi = ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{uyeler[i].Isim}");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Üye Soyismi = ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{uyeler[i].Soyisim}");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Üye Şehir= ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(uyeler[i].Sehir + "\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
            }
                
        }
        public void katılımcı()
        {
            int a = 0;
            Console.WriteLine("*-*-*ÜYE OLMAYAN KATILIMCILAR*-*-*");
            for (int i = 0; i < uyeler.Length; i++)
            {
                if (uyeler[i].Uyemi != "e")
                {
                    a++;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write($"Üye Olmayan {a}. Katılımcı\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Katılımcı İsmi = ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{uyeler[i].Isim}");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Katılımcı Soyismi = ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{uyeler[i].Soyisim}");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Katılımcı Şehir= ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(uyeler[i].Sehir + "\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
               

            }
        }
        public void sehir()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Lütfen Hangi Şehirdeki Katılımcıları Görmek İstediğinizi Seçiniz = ");
            Console.ForegroundColor = ConsoleColor.White;
            string secenek = Console.ReadLine();
            Console.Clear();
            int a = 0;
            Console.WriteLine("*-*-*"+ secenek + " Şehrinden Katılımcılar*-*-*");
            for (int i = 0; i < uyeler.Length; i++)
            {
                if (secenek == uyeler[i].Sehir)
                {

                    a++;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"{a}. Katılımcı");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Üye İsmi = ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{uyeler[i].Isim}");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Katılımcı Soyismi = ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{uyeler[i].Soyisim}");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Katılımcının Üyelik Durumu = ");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (uyeler[i].Uyemi == "e")
                    {
                        Console.WriteLine("Aktif\n");
                    }
                    else { Console.WriteLine("Pasif\n"); }
                }

            }

        }

    }
}
