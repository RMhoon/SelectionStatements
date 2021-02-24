using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            int favNumber = r.Next(1, 1000);

            Console.WriteLine("Enter in a number.  Try and guess my favorite number 1 to 1,000");
            var userNumber = int.Parse(Console.ReadLine());

            if (userNumber > favNumber)
                Console.WriteLine("The number is too high.");
            else if (userNumber < favNumber)
                    Console.WriteLine("The number is too low.");
            else if (userNumber == favNumber)
                Console.WriteLine("You won.  You have guessed my number");
            else
                Console.WriteLine("Nevermind");

        }
    }
}
