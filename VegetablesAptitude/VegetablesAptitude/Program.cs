using System;
using System.IO;

namespace VegetablesAptitude
{
    class Program
    {
        private static List<Quiz> _takers = new List<Quiz>();
        static void Main(string[] args)
        {
            // Menu Loop
            Console.WriteLine("hey sprout...!");

            int i = 1;
            while (i > 0)
            {
                Console.WriteLine("Would you like to know what vegetable you'll grow into?");
                Console.WriteLine("1: Continue");
                Console.WriteLine("2: No I do not.");
                Console.WriteLine("3. Search for previous results");

                int entry = Convert.ToInt32(Console.ReadLine()); // turns string response into integer to read
                
                if (entry == 1) // initializes the quiz
                {
                    Console.WriteLine("Okay...let's start...");

                    Console.WriteLine("Adding new user! Name: ");
                    string Taker = Console.ReadLine();
                    _takers.Add(new Quiz() { Taker = Taker });
                    var newTaker = _takers.FirstOrDefault(x => x.Taker == Taker);
                    //newTaker.Response();
                    newTaker.Questions();
                }
                else if (entry == 2) // exit
                {
                    i = 0;
                }
                else if (entry == 3)
                {
                    Console.WriteLine("Search for other results.");
                    string searchTaker = Console.ReadLine();

                    // use a linq query to find someone
                    var taker = _takers.FirstOrDefault(x => x.Taker == searchTaker);

                    // do they exist?
                    if (taker != null)
                    {
                        // user isnt null and runs their greeting function
                        taker.Response();
                    }
                    else
                    {
                        // user is null
                        Console.WriteLine($"{searchTaker} not found");
                    }
                }
                else
                {
                    Console.WriteLine("Not a valid entry."); // re-start loop

                }
            }

        }
    }
}






