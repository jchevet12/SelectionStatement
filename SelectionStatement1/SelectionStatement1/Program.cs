using System;

namespace SelectionStatement1
{
    class Program
    {
        static void Main(string[] args)
        {
            int FavNumber = 3;
            {
                Console.WriteLine("guess the favorite number, go low");
                var userInput = int.Parse(Console.ReadLine());

                if (userInput < FavNumber)
                {
                    Console.WriteLine("ahh, but too low-- go higher");

                }

                else if (userInput > FavNumber)
                {
                    Console.WriteLine("whoops, too high. Come down some");
                }

                else (userInput = FavNumber)

                        {
                    Console.WriteLine("BNGO!");
                }
            }

             
        }
    }
}
