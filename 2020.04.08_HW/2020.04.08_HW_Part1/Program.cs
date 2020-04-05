using System;

namespace _2020._04._08_HW_Part1
{
    class Program
    {
        public static void WriteTheDayName(string inputNumber, string[] weekDayNumber, string[] weekDayName)
        {
            bool a = weekDayNumber[0] == inputNumber;
            bool b = weekDayNumber[1] == inputNumber;
            bool c = weekDayNumber[2] == inputNumber;
            bool d = weekDayNumber[3] == inputNumber;
            bool e = weekDayNumber[4] == inputNumber;
            bool f = weekDayNumber[5] == inputNumber;
            bool g = weekDayNumber[6] == inputNumber;
            bool compare = a | b | c | d | e | f | g;


            bool repeatInput = !a & !b & !c & !d & !e & !f & !g;
            while ((compare | repeatInput) | (!compare | !repeatInput))
            {
                if (compare)
                {
                    switch (inputNumber)
                    {
                        case "1":
                            Console.WriteLine(weekDayName[0]);
                            Console.WriteLine("Input another number");
                            inputNumber = Console.ReadLine();

                            break;
                    }
                    switch (inputNumber)
                    {
                        case "2":
                            Console.WriteLine(weekDayName[1]);
                            Console.WriteLine("Input another number");
                            inputNumber = Console.ReadLine();
                            break;
                    }
                    switch (inputNumber)
                    {
                        case "3":
                            Console.WriteLine(weekDayName[2]);
                            Console.WriteLine("Input another number");
                            inputNumber = Console.ReadLine();
                            break;
                    }
                    switch (inputNumber)
                    {
                        case "4":
                            Console.WriteLine(weekDayName[3]);
                            Console.WriteLine("Input another number");
                            inputNumber = Console.ReadLine();
                            break;
                    }
                    switch (inputNumber)
                    {
                        case "5":
                            Console.WriteLine(weekDayName[4]);
                            Console.WriteLine("Input another number");
                            inputNumber = Console.ReadLine();
                            break;
                    }
                    switch (inputNumber)
                    {
                        case "6":
                            Console.WriteLine(weekDayName[5]);
                            Console.WriteLine("Input another number");
                            inputNumber = Console.ReadLine();
                            break;
                    }
                    switch (inputNumber)
                    {
                        case "7":
                            Console.WriteLine(weekDayName[6]);
                            Console.WriteLine("Input another number");
                            inputNumber = Console.ReadLine();
                            break;

                    }

                }

                else
                {
                    Console.WriteLine("Incorrect Input. Please, input number from 1 to 7");
                    inputNumber = Console.ReadLine();
                }
                bool a1 = weekDayNumber[0] == inputNumber;
                bool b1 = weekDayNumber[1] == inputNumber;
                bool c1 = weekDayNumber[2] == inputNumber;
                bool d1 = weekDayNumber[3] == inputNumber;
                bool e1 = weekDayNumber[4] == inputNumber;
                bool f1 = weekDayNumber[5] == inputNumber;
                bool g1 = weekDayNumber[6] == inputNumber;
                compare = a1 | b1 | c1 | d1 | e1 | f1 | g1;

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
