using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace o220902019_İsmail_Karaçal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Soru4:
            //1 ile 10 arasındaki sayıların toplamını wile ve for dongüleri ile ayrı ayrı bulup ekrana yazdırınız.
            int toplam = 0;
            // For döngüsü ile
            for (int i = 1; i <= 10; i++)
            {
                toplam += i;
            }
            Console.WriteLine("For döngüsü ile toplam: " + toplam);
            // While döngüsü ile
            toplam = 0;
            int j = 1;
            while (j <= 10)
            {
                toplam += j;
                j++;
            }
            Console.WriteLine("While döngüsü ile toplam: " + toplam);
        }

        //Soru3
        static int SesliHarfSayisi(string cumle)
        {
            char[] sesliHarfler = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'İ', 'O', 'U' };
            int sayac = 0;
            foreach (char karakter in cumle)
            {
                if (sesliHarfler.Contains(karakter))
                {
                    sayac++;
                }
            }
            return sayac;
        }

        //Soru5:
        //iki sayıyı toplayan ve sayıların bölümünün sonucunu geri döndüren,parametre olarak da bu iki sayıyı alan bir fonksiyon yazarak çalıştırınız.
        static double BolumVeToplam(int sayi1, int sayi2, out int toplam)
        {
            toplam = sayi1 + sayi2;
            if (sayi2 != 0)
            {
                return (double)sayi1 / sayi2;
            }
            else
            {
                Console.WriteLine("Bölme işlemi için ikinci sayı sıfır olamaz.");
                return 0;
            }
        }
        //Soru7:
        //4,4 boyutunda bir kare matris oluşturunuz.Ardından matrisin düz köşegenindeki değerler toplamını bulunuz.
        static void MatrisKosegenToplami()
        {
            int[,] matris = new int[4, 4]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12},
                {13, 14, 15, 16}
            };
            int toplam = 0;
            for (int i = 0; i < 4; i++)
            {
                toplam += matris[i, i];
            }
            Console.WriteLine("Köşegen toplamı: " + toplam);
        }

        //Soru6  

       //Asal sayıların adedini bularak ekrana yazdıran programı yazınız.
        static int AsalSayiAdedi(int baslangic, int bitis)
        {
            int asalSayilarinAdedi = 0;
            for (int sayi = baslangic; sayi <= bitis; sayi++)
            {
                if (sayi < 2) continue;
                bool asalMi = true;
                for (int i = 2; i <= Math.Sqrt(sayi); i++)
                {
                    if (sayi % i == 0)
                    {
                        asalMi = false;
                        break;
                    }
                }
                if (asalMi)
                {
                    asalSayilarinAdedi++;
                }
            }
            return asalSayilarinAdedi;
        }


    }
}
