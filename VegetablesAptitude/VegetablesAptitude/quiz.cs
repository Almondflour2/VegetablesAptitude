using System;
using System.IO;

namespace VegetablesAptitude
{
	public class Quiz
	{
        public string Taker { get; set; } //name variable
        
        public void Response() // result output
            {
                Console.WriteLine($"{Taker} is an octillery bean sprout!");
            }
        public void Questions()
        {
            //score integers
            int ScoreInterface = 0;
            int ScoreEthics = 0;
            int ScoreEssence = 0;

            // creates array with questions read from file
            string[] Qs = System.IO.File.ReadAllLines(@"..\text files\Questions.txt");

            //System.Console.WriteLine("Contents of WriteLines2.txt = ");
            while (Qs.Length > 0)
            {
                Random rnd = new Random();
                int number = rnd.Next(0, (Qs.Length));

                var questionsList = new List<string>(Qs);
                questionsList.RemoveAt(number);
                //

               
                /*//score interface
                if (Qs[number].Contains("1,"))
                {
                    string reply = Console.ReadLine();
                    if (reply.Contains("yes"))
                    {
                        ScoreInterface++;
                        Console.WriteLine(ScoreInterface);
                    }
                    
                }
                //score ethics
                if (Qs[number].Contains("2,"))
                {
                    string reply = Console.ReadLine();
                    if (reply.Contains("yes"))
                    {
                        ScoreEthics++;
                        Console.WriteLine(ScoreEthics);
                    }

                }
                //score essence
                if (Qs[number].Contains("3,"))
                {
                    string reply = Console.ReadLine();
                    if (reply.Contains("yes"))
                    {
                        ScoreEssence++;
                        Console.WriteLine(ScoreEssence);
                    }

                }*/


                string questionPrompt = Qs[number];

                
                questionPrompt = questionPrompt.Remove(0, 2); // removes 2 characters starting at 0 (1,)

                Console.Clear();

                Console.WriteLine(questionPrompt);
                
                string reply = Console.ReadLine();
                if (reply.Contains("yes"))
                {
                    if (Qs[number].Contains("1,"))
                    { ScoreInterface++; }
                    else if (Qs[number].Contains("2,"))
                    { ScoreEthics++; }

                }

                

                //



                Qs = questionsList.ToArray();

                      
                //Console.WriteLine(Qs.Length);

               

            }

            Console.WriteLine($"interface: {ScoreInterface} ethics: {ScoreEthics}");
            Console.ReadLine();
            Console.Clear();

        }


        public Quiz()
		{
            /*//QUESTIONS
            //creates array with questions read from file
            string[] questions = System.IO.File.ReadAllLines(@"..\text files\Questions.txt");
            *//*PrintArray(questions);*//*

            Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string question in questions)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + questions);
            }*/

        }

        

    }
}