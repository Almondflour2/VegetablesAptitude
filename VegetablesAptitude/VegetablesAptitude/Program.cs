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
                    newTaker.Questions();
                    newTaker.Result();
                }
                else if (entry == 2) // exit
                {
                    i = 0;
                }
                else if (entry == 3)
                {
                    Console.WriteLine("Search for other results.");

                    if (_takers.Count == 0)
                    {
                        Console.WriteLine("No one has taken it yet");
                    }
                    else
                    {
                        Console.WriteLine("Here are the takers:");
                        for (int x = 0; x < _takers.Count; x++)
                        {

                            Console.WriteLine($"{_takers[x].Taker}");


                        }
                        Console.WriteLine("Enter the taker name: ");
                        string searchTaker = Console.ReadLine();

                        // use a linq query to find someone
                        var taker = _takers.FirstOrDefault(x => x.Taker == searchTaker);

                        // do they exist?
                        if (taker != null)
                        {
                            // user isnt null and runs their greeting function
                            taker.Result();
                        }
                        else
                        {
                            // user is null
                            Console.WriteLine($"{searchTaker} not found");

                        }

                  

                    
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






