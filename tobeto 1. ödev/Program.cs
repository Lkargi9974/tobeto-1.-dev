using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Sipariş numaranızı girin:");
        int siparisNo = Convert.ToInt32(Console.ReadLine());

        switch (siparisNo)
        {
            case 1:
                Console.WriteLine("Siparişiniz: Bilgisayar");
                break;
            case 2:
                Console.WriteLine("Siparişiniz: Telefon");
                break;
            case 3:
                Console.WriteLine("Siparişiniz: Tablet");
                break;
            case 4:
                Console.WriteLine("Siparişiniz: Kulaklık");
                break;
            default:
                Console.WriteLine("Geçersiz sipariş numarası!");
                break;
        }
    }
}
