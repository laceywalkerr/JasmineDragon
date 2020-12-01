using System;

namespace JasmineDragon
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Welcome to the Jasmine Dragon!");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            ZukoSays("Here is your tea, I hope you enjoy!");

            Question("Would you like my uncle to tell you a proverb with your tea? He's very good at them.", "Ok great! I'll go get him for you.", "Alright, well please enjoy your tea and have a nice day. Thank you for visiting the Jasmine Dragon!");
        }
        static void Question(string question, string trueResponse, string falseResponse)
        {
            bool answer = ZukoAsks(question);
            if (answer)
            {
                ZukoSays(trueResponse);
            }
            else
            {
                ZukoSays(falseResponse);
            }
        }
        static bool ZukoAsks(string question)
        {
            Console.Write($"{question} (Y/N): ");
            string answer = Console.ReadLine().ToLower();

            while (answer != "y" && answer != "n")
            {
                Console.Write($"{question} (Y/N): ");
                answer = Console.ReadLine().ToLower();
            }

            if (answer == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void ZukoSays(string message)
        {

            Console.WriteLine($@"
                    (  )   (   )  )
                ) (   )  (  (
                ( )  (    ) )
                 _____________
                <_____________> ___
                |             |/ _ \   {message}
                |               | | |
                |               |_| |
             ___|             |\___/
            /    \___________/    \
            \_____________________/       

                        ");

        }
    }
}