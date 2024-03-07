using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsPerfectNumber(number))
        {
            Console.WriteLine(number + " mükemmel bir sayıdır.");
        }
        else
        {
            Console.WriteLine(number + " mükemmel bir sayı değildir.");
        }
    }

    static bool IsPerfectNumber(int number)
    {
        int sum = 0;

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }

        return sum == number;
    }
}

