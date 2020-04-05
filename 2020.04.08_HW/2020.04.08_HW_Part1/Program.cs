using System;

namespace _2020._04._08_HW_Part1
{
    class Program
    {
        public static bool ChooseTheRightSymbol(string inputNumber, string [] weekDayNumber)
        {
            bool result = false;
            for (int i = 0; i < (weekDayNumber.Length - 1); i++)
            {
                bool a = inputNumber == weekDayNumber[i];
                bool b = inputNumber == weekDayNumber[i + 1];
                result |= a | b;

            }
            return result;
        }
        public static void WriteTheDayName(string inputNumber, string[] weekDayNumber, string[] weekDayName)
        {

            bool resultForTheCycle = ChooseTheRightSymbol(inputNumber, weekDayNumber);

            while (resultForTheCycle | !resultForTheCycle )
            {
                if (resultForTheCycle)
                {
                    switch (inputNumber)
                    {
                        case "1":
                            Console.WriteLine(weekDayName[0]);
                            Console.WriteLine(string.Empty);
                            Console.WriteLine("Input another number");
                            inputNumber = Console.ReadLine();

                            break;
                    }
                    switch (inputNumber)
                    {
                        case "2":
                            Console.WriteLine(weekDayName[1]);
                            Console.WriteLine(string.Empty);
                            Console.WriteLine("Input another number");
                            inputNumber = Console.ReadLine();
                            break;
                    }
                    switch (inputNumber)
                    {
                        case "3":
                            Console.WriteLine(weekDayName[2]);
                            Console.WriteLine(string.Empty);
                            Console.WriteLine("Input another number");
                            inputNumber = Console.ReadLine();
                            break;
                    }
                    switch (inputNumber)
                    {
                        case "4":
                            Console.WriteLine(weekDayName[3]);
                            Console.WriteLine(string.Empty);
                            Console.WriteLine("Input another number");
                            inputNumber = Console.ReadLine();
                            break;
                    }
                    switch (inputNumber)
                    {
                        case "5":
                            Console.WriteLine(weekDayName[4]);
                            Console.WriteLine(string.Empty);
                            Console.WriteLine("Input another number");
                            inputNumber = Console.ReadLine();
                            break;
                    }
                    switch (inputNumber)
                    {
                        case "6":
                            Console.WriteLine(weekDayName[5]);
                            Console.WriteLine(string.Empty);
                            Console.WriteLine("Input another number");
                            inputNumber = Console.ReadLine();
                            break;
                    }
                    switch (inputNumber)
                    {
                        case "7":
                            Console.WriteLine(weekDayName[6]);
                            Console.WriteLine(string.Empty);
                            Console.WriteLine("Input another number");
                            inputNumber = Console.ReadLine();
                            break;

                    }

                }

                else
                {
                    Console.WriteLine(string.Empty);
                    Console.WriteLine("Incorrect Input. Please, input number from 1 to 7");
                    inputNumber = Console.ReadLine();
                }               
                resultForTheCycle = ChooseTheRightSymbol(inputNumber, weekDayNumber);

            }
            

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input number from 1 to 7");
            string[] weekDayNumber = new[] { "1", "2", "3", "4", "5", "6", "7" };
            string[] weekDayName = new[] { "Monday", "Tuesday", "Wendsday", "Thursday", "Friday", "Saturday", "Sunday" };
            string inputNumber = Console.ReadLine();

            WriteTheDayName(inputNumber, weekDayNumber, weekDayName);



        }
    }
}
