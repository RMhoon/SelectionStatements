using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            int favNumber = r.Next(1, 1000);

            Console.WriteLine("Enter in a number.  Try and guess my favorite number 1 to 1,000.  Enter exit to end game.");
            var input = Console.ReadLine();

            while (input.ToLower() != "exit")
            {
                var userNumber = int.Parse(input);

                if (userNumber > favNumber)
                    Console.WriteLine("The number is too high.");
                else if (userNumber < favNumber)
                    Console.WriteLine("The number is too low.");
                else
                    Console.WriteLine("Nevermind");

                Console.WriteLine("Enter in another number or enter exit to end game.");
                input = Console.ReadLine();
            }

            Console.WriteLine("You have exited the game. Good bye.");

        }
    }
}
