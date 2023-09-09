using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace katilimciliste1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            katılımcılar k = new katılımcılar();

            uye uye1 = new uye();
            uye1.Isim = "Erkan";
            uye1.Soyisim = "Uysal";
            uye1.Sehir = "Afyonkarahisar";
            uye1.Uyemi = "h";
            k.uyeEkle(uye1);

            uye uye2 = new uye();
            uye2.Isim = "Ahmet";
            uye2.Soyisim = "Can";
            uye2.Sehir = "Eskişehir";
            uye2.Uyemi = "e";
            k.uyeEkle(uye2);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("*-*-*UYGULAMAYA HOŞGELDİNİZ*-*-*");

            string secenek = "e";
            while (secenek == "e")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemin Numarasını Giriniz");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1) Katılımcıları Listele");
                Console.WriteLine("2) Katılımcı Ekle");
                secenek = Console.ReadLine();
                Console.Clear();
                if (secenek == "1")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Lütfen Listeleme Türünü Seçiniz");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("1) Tüm Katılımcıları Listele\n2) Üye Katılımcıları Listele\n3) Üye Olmayan Katılımcıları Listele\n4) Şehre Göre Listele");
                    Console.ForegroundColor = ConsoleColor.White;
                    secenek = Console.ReadLine();
                    Console.Clear();
                    if (secenek == "1")
                    {
                        k.listele();
                       
                    }
                    else if (secenek == "2")
                    {
                        k.uyegetir();
                    }
                    else if (secenek == "3")
                    {
                        k.katılımcı();
                    }
                    else if (secenek == "4")
                    {
                        k.sehir();
                    }


                }
                else if (secenek == "2")
                {
                    k.veriGetir();
                }
               

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Başka Bir İşlem Yapmak İstiyor musunuz? e/h = ");
                Console.ForegroundColor = ConsoleColor.White;
                secenek = Console.ReadLine();
                Console.Clear();
                if ( secenek == "h")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Çıkış Yapılıyor...");
                   
                }





            }
        }
    }
}
