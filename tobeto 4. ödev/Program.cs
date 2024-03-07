using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 11);
        int guess = 0;
        int attempts = 0;

        Console.WriteLine("1 ile 10 arasında bir sayı tahmin edin.");

        while (guess != randomNumber)
        {
            Console.Write("Tahmininizi girin: ");
            guess = Convert.ToInt32(Console.ReadLine());
            attempts++;

            if (guess < randomNumber)
            {
                Console.WriteLine("Daha büyük bir sayı girin.");
            }
            else if (guess > randomNumber)
            {
                Console.WriteLine("Daha küçük bir sayı girin.");
            }
        }

        Console.WriteLine("Tebrikler! " + attempts + " denemede doğru tahmin ettiniz.");
    }
}

