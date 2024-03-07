using System;

class Program
{
    static void Main()
    {
        Console.Write("Öğrenci sayısını girin: ");
        int studentCount = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= studentCount; i++)
        {
            Console.WriteLine($"Öğrenci {i} bilgilerini girin:");

            Console.Write("Adı: ");
            string firstName = Console.ReadLine();

            Console.Write("Soyadı: ");
            string lastName = Console.ReadLine();

            Console.Write("1. Sınav Notu: ");
            double exam1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2. Sınav Notu: ");
            double exam2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("3. Sınav Notu: ");
            double exam3 = Convert.ToDouble(Console.ReadLine());

            double average = (exam1 + exam2 + exam3) / 3;

            Console.WriteLine($"Ortalama: {average}\n");
        }
    }
}

