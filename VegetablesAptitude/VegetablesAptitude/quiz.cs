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
            // creates array with questions read from file
            string[] Qs = System.IO.File.ReadAllLines(@"..\text files\Questions.txt");

            //System.Console.WriteLine("Contents of WriteLines2.txt = ");
            while (Qs.Length > 0)
            {
                Random rnd = new Random();
                int number = rnd.Next(0, (Qs.Length));

                var questionsList = new List<string>(Qs);
                questionsList.RemoveAt(number);
                Console.WriteLine("\t" + Qs[number]);
                Qs = questionsList.ToArray();


               

               
                //Console.WriteLine(Qs.Length);

               

            }
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