using System;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int a = rand.Next(1, 100);
            Console.WriteLine("Please, enter the number: ");
            string b = Console.ReadLine();
            int guess = int.Parse(b);
            while (guess != a)
            {
                if (guess > a)
                {
                    Console.WriteLine("The number is too high");
                }
                else
                {
                    Console.WriteLine("The number is too small");
                }
                guess = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Congratulations!");
        }
    }
}
