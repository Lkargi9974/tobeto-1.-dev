using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tobeto_ödev
{
    internal class ödev2
    {
        static void Main()
        {
            Console.WriteLine("Kaç ürün almak istiyorsunuz?");
            int urunSayisi = Convert.ToInt32(Console.ReadLine());

            double toplamTutar = 0;

            for (int i = 1; i <= urunSayisi; i++)
            {
                Console.WriteLine("Ürün {0} seçenekler:", i);
                Console.WriteLine("1. Bilgisayar - 5000 TL");
                Console.WriteLine("2. Telefon - 3000 TL");
                Console.WriteLine("3. Tablet - 2000 TL");
                Console.WriteLine("4. Kulaklık - 100 TL");

                Console.WriteLine("Ürün {0} seçeneklerinden birini seçin:", i);
                int secilenUrun = Convert.ToInt32(Console.ReadLine());

                double urunFiyati = 0;
                switch (secilenUrun)
                {
                    case 1:
                        urunFiyati = 5000;
                        break;
                    case 2:
                        urunFiyati = 3000;
                        break;
                    case 3:
                        urunFiyati = 2000;
                        break;
                    case 4:
                        urunFiyati = 100;
                        break;
                    default:
                        Console.WriteLine("Geçersiz ürün seçimi!");
                        continue;
                }
                toplamTutar += urunFiyati;
            }

            Console.WriteLine("Toplam alışveriş tutarı: {0}", toplamTutar);
        }
    }

}




