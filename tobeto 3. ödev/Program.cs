using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int minNumber = 1;
        int maxNumber = 100;
        int targetNumber;
        int guess;
        int attempts;
        string answer;

        do
        {
            targetNumber = random.Next(minNumber, maxNumber + 1);
            guess = 0;
            attempts = 0;

            Console.WriteLine("1 ile 100 arasında bir sayı tahmin edin.");

            while (guess != targetNumber)
            {
                attempts++;
                Console.Write("Tahmininiz: ");
                guess = int.Parse(Console.ReadLine());

                if (guess < targetNumber)
                {
                    Console.WriteLine("Daha büyük bir sayı girin.");
                }
                else if (guess > targetNumber)
                {
                    Console.WriteLine("Daha küçük bir sayı girin.");
                }
                else
                {
                    Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");
                }
            }

            Console.WriteLine($"Doğru sayıyı {attempts} denemede buldunuz.");

            Console.Write("Tekrar oynamak ister misiniz? (Evet/Hayır): ");
            answer = Console.ReadLine().ToLower();
        } while (answer == "evet");
    }
}
