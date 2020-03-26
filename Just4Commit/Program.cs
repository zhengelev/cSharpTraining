using System;

namespace Just4Commit
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstSpeech = "Hello, let me tell you what i'm going to do here.";

            var actionSpeech = "Type 'y' to continue or type 'n' to close app and be sorry for not seeing the best app ever made.";

            Console.WriteLine(firstSpeech);

            Console.WriteLine(actionSpeech);

            var userAnswer = Console.ReadLine();

            while (userAnswer != "y" & userAnswer != "n")
            {
                Console.WriteLine("Incorrect input");

                var actionSpeech2 = "Type 'y' to continue or type 'n' to close app";

                Console.WriteLine(actionSpeech2);
                                
                if (userAnswer == "y")
                {
                    Console.WriteLine("It does absolutely nothing");
                }
                
                if (userAnswer == "n")
                {
                    Console.WriteLine("So, you will be sorry for that...");
                }
                
            }
        }
    }
}
