

//MASTER LOOP
string answer = "";
do
{

    Console.WriteLine("Vegetables: Aptitude");

    Console.WriteLine("would you like to know what vegetable you are?");

    Console.WriteLine("type no to exit");
    answer = Console.ReadLine();

    Console.Clear();
    Console.WriteLine($"{answer}");

    string[] questions = { "Are you nervous at parties?", "Do you get scared at car dealerships?", "Does it overwhelm you to be in large open spaces filled with people?" };
    string questionReply = "";
    int percentage = questionReply.Length;


    int score = 0;

    foreach (string question in questions)
    {

        Console.WriteLine($"{question}", "\n");
        questionReply = Console.ReadLine();
        if (questionReply == "yes")
        {
            score++;
        }

    }

    /*string shyResult = shyCalculator(score);*/

    Console.WriteLine($"{shyCalculator(score)}... type no to exit");
    answer = Console.ReadLine();


} while (answer != "no"); //END MASTER LOOP
  //END PROGRAM TEXT
  Console.WriteLine("Okay, goodbye.");

static string shyCalculator(int score)
{
    string result = "You are not shy.";
    switch (score)
    {
        case 1:
            result = "You are a little shy..";
            break;
        case 2:
            result = "your pretty shy";
            break;
        case 3:
            result = "cry baby cant go outside call 911 for help ordering a sandwich";
            break;
    }
    return result;
}




