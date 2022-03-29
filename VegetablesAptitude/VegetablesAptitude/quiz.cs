using System;
using System.IO;

namespace VegetablesAptitude
{
	public class Quiz
	{
        public string Taker { get; set; } //name variable. new instance of Quiz is called Taker

        //score integers
        public int ScoreInterface = 0;
        public int ScoreEthics = 0;
        public int ScoreEssence = 0;

        //score strings
        public string Interface;
        public string Ethics;
        public string Essence;

        //vegetable generation
        public string veggie = Vegetable();
        //get random vegetable from text file
        public static string Vegetable()
        {
            string[] Veggie = System.IO.File.ReadAllLines(@"..\text files\Vegetables.txt");

            //randomizes integer from 0 - length of array 
            Random rnd = new Random();
            return Veggie[rnd.Next(0, (Veggie.Length))];

        } 
        
        public void Questions()
        {
           
            //creates array with questions read from file
            string[] Qs = System.IO.File.ReadAllLines(@"..\text files\Questions.txt");

            while (Qs.Length > 0)
            {
                //randomizes integer from 0 - length of array 
                Random rnd = new Random();
                int number = rnd.Next(0, (Qs.Length));

                //reduces array of questions by one after printing one
                var questionsList = new List<string>(Qs);
                questionsList.RemoveAt(number);

                //converts first character of array to correspond to category of question into an integer for use in switch case
                int questionType = Convert.ToInt32(Qs[number].Substring(0, 1));

                string questionPrompt = Qs[number].Remove(0, 2); //removes 2 characters starting at 0 (1,)

                //clear console and write new question
                Console.Clear();
                
                //exception handling bool
                bool isReplyValid;

                do //exception handling do/while loop that repeats question until isReplyValid = true;
                {
                    Console.WriteLine($"\n {Taker}, {questionPrompt}");
                    Console.WriteLine(" Type 1 for yes \n Type 2 for no");
                    string reply = Console.ReadLine();
                    if (reply == "1")
                    {
                        switch (questionType) //applies scores to different categories of questions
                        {
                            case 1:
                                ScoreInterface++;
                                break;
                            case 2:
                                ScoreEthics++;
                                break;
                            case 3:
                                ScoreEssence++;
                                break;
                        }
                        isReplyValid = true;
                    }
                    else if (reply == "2") {
                        isReplyValid = true;
                    }
                    else //throws error
                    {
                        isReplyValid = false;
                        Console.WriteLine("invalid input, press enter");
                        Console.ReadLine();
                    }
                    
                    Console.Clear();

                } while (!isReplyValid); //false response throws back to beginning of do/while 

                Qs = questionsList.ToArray(); //convert list to array which feeds back into the use of Qs array at the beginning of while loop
            }

        }
        public string ScoreStringify() //converts scores from different categories into strings for the result output 
        {
            if (ScoreInterface <= 1) Interface = "thoughtful";
            if (ScoreInterface == 2) Interface = "intimate";
            if (ScoreInterface == 3) Interface = "confident";

            if (ScoreEthics <= 1) Ethics = "restrictive";
            if (ScoreEthics == 2) Ethics = "sturdy";
            if (ScoreEthics == 3) Ethics = "malleable";

            if (ScoreEssence <= 1) Essence = "practical";
            if (ScoreEssence == 2) Essence = "out of bounce";
            if (ScoreEssence == 3) Essence = "existential";

            return $"{Interface},\n {Ethics},\n and {Essence}\n {veggie}! \n \n Press any key...";
        }

        public void Result() // result output with name, 3 scores, and vegetable
        {
            Console.WriteLine($"\n {Taker} is a\n {ScoreStringify()}");
            Console.ReadLine();
            Console.Clear();
        }

    }
}