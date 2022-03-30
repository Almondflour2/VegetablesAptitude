using System;
using System.IO;

namespace VegetablesAptitude
{
    class Program
    {
        private static List<Quiz> _takers = new List<Quiz>(); //creates list of takers - instances of Quiz 
        static void Main(string[] args) //main method
        {
            //startup text
            string ascii = @"

                      (`-')(`-')  _          (`-')  _(`-')    (`-')  _ <-.(`-')         (`-')  _ (`-').-> 
                     _(OO )( OO).-/    .->   ( OO).-/( OO).-> (OO ).-/  __( OO)   <-.   ( OO).-/ ( OO)_   
                ,--.(_/,-.(,------. ,---(`-'|,------./    '._ / ,---.  '-'---.\ ,--. ) (,------.(_)--\_)  
                \   \ / (_/|  .---''  .-(OO )|  .---'|'--...__) \ /`.\ | .-. (/ |  (`-')|  .---'/    _ /  
                 \   /   /(|  '--. |  | .-, (|  '--. `--.  .--'-'|_.' || '-' `.)|  |OO ||  '--. \_..`--.  
                _ \     /_)|  .--' |  | '.(_/|  .--'    |  | (|  .-.  || /`'.  (|  '__ ||  .--' .-._)   \ 
                \-'\   /   |  `---.|  '-'  | |  `---.   |  |  |  | |  || '--'  /|     |'|  `---.\       / 
                    `-'    `------' `-----'  `------'   `--'  `--' `--'`------' `-----' `------' `-----'  
                         (`-')  _  _  (`-')(`-')      _     (`-')                _(`-')   (`-')  _                
                         (OO ).-/  \-.(OO )( OO).->  (_)    ( OO).->       .->  ( (OO ).->( OO).-/                
                         / ,---.   _.'    \/    '._  ,-(`-')/    '._  ,--.(,--.  \    .'_(,------.                
                         | \ /`.\ (_...--''|'--...__)| ( OO)|'--...__)|  | |(`-')'`'-..__)|  .---'                
                         '-'|_.' ||  |_.' |`--.  .--'|  |  )`--.  .--'|  | |(OO )|  |  ' (|  '--.                 
                        (|  .-.  ||  .___.'   |  |  (|  |_/    |  |   |  | | |  \|  |  / :|  .--'                 
                         |  | |  ||  |        |  |   |  |'->   |  |   \  '-'(_ .'|  '-'  /|  `---.                
                         `--' `--'`--'        `--'   `--'      `--'    `-----'   `------' `------'";
            Console.WriteLine(ascii);

            Console.WriteLine("\n \n hey sprout...!");

            //menu loop
            int i = 1;
            while (i > 0)
            {
                Console.WriteLine(" Would you like to know what vegetable you'll grow into?");
                Console.WriteLine(" 1: Continue");
                Console.WriteLine(" 2: No I do not.");
                Console.WriteLine(" 3: Search for previous results");

                int entry = Convert.ToInt32(Console.ReadLine()); //turns string response into integer to read
                
                if (entry == 1) //initializes the quiz
                {
                    Console.WriteLine("\n Okay...let's start...");

                    Console.WriteLine("\n Adding new user! Name: ");
                    string Taker = Console.ReadLine();
                    _takers.Add(new Quiz() { Taker = Taker });
                    var newTaker = _takers.FirstOrDefault(x => x.Taker == Taker);
                    newTaker.Questions();
                    newTaker.Result();
                }
                else if (entry == 2) //exit
                {
                    i = 0;
                }
                else if (entry == 3) //prints list of previous results and uses linq query to find taker
                {
                    Console.WriteLine("\n Search for other results.");

                    if (_takers.Count == 0)
                    {
                        Console.WriteLine("\n No one has taken it yet");
                    }
                    else
                    {
                        Console.WriteLine("\n Here are the previous takers:\n");
                        for (int x = 0; x < _takers.Count; x++)
                        {
                            Console.WriteLine($"\n {_takers[x].Taker}\n");
                        }
                        Console.WriteLine("\n Enter the taker name: \n");
                        string searchTaker = Console.ReadLine();

                        //use a linq query to find taker
                        var taker = _takers.FirstOrDefault(x => x.Taker == searchTaker);

                        //do they exist?
                        if (taker != null)
                        {
                            //taker isnt null and runs their result
                            taker.Result();
                        }
                        else
                        {
                            //taker is null
                            Console.WriteLine($"\n {searchTaker} not found");
                        }
                    
                    }
                }
                else
                {
                    Console.WriteLine("\n Not a valid entry."); //re-start search taker loop

                }
            }

        }
    }
}






