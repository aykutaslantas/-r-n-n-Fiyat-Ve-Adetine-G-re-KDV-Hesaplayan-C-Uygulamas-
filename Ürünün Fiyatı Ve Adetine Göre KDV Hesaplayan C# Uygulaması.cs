using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDV_ile_Ürün_Fiyatı_Ve_Adeti_Hesaplayan_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. Ürünün Fiyatını Giriniz :");
            int  f1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("1. Ürünün Adetini Giriniz :");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Ürünün Fiyatını Giriniz :");
            int f2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Ürünün Adetini Giriniz :");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. Ürünün Fiyatını Giriniz :");
            int f3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. Ürünün Adetini Giriniz :");
            int a3 = Convert.ToInt32(Console.ReadLine());
            int toplam = f1 * a1 + f2 * a2 + f3 * a3;
            if (toplam >= 200) 
            {
                Console.Write("Ödenecek Tutar {0} TL'dir. KDV Ücreti Ödenmeyecektir.", toplam);

            }
            else
            {
                double kdv = 0.02;
                double odenecektutar = toplam + kdv;
                Console.Write("Toplam Fiyat 200 TL'den Fazla Olduğu İçin KDV Fiyata Dahildir Ödenecek Tutar {0}", odenecektutar);

            }
            Console.ReadKey();

        }
    }
}
