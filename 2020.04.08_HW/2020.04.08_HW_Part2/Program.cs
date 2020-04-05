using System;

namespace _2020._04._08_HW_Part2
{
    class Program
    {
        public static bool CalculateCorrectInputSymbol(string inputValue, int [] multiplyTable)
        {
            bool result = false;
            for (int i = 0; i < (multiplyTable.Length - 1); i++)
            {
                string[] stringMultiplyTable = Array.ConvertAll(multiplyTable, x => x.ToString());
                bool a = inputValue == stringMultiplyTable[i];
                bool b = inputValue == stringMultiplyTable[i + 1];
                result |= a | b;
                
            }
            return result;
        }
        public static void ShowMultiplyTable(string inputNumber, int [] multiplyTable)
        {
            bool resultForTheCycle = CalculateCorrectInputSymbol(inputNumber, multiplyTable);

            while (resultForTheCycle | !resultForTheCycle)
            {
                if (resultForTheCycle)
                {
                    int firstMultiplier = Int32.Parse(inputNumber);
                    Console.WriteLine(string.Empty);
                    Console.WriteLine("Here's your table:");


                    for (int i = 0; i < multiplyTable.Length; i++)
                    {
                        var secondMultiplier = multiplyTable[i];
                        var result = firstMultiplier * secondMultiplier;
                        Console.WriteLine(firstMultiplier + " " + "x" + " " + secondMultiplier + " " + "=" + " " + result);

                    }
                    Console.WriteLine(string.Empty);
                    Console.WriteLine("Input another number from 1 to 10");
                    inputNumber = Console.ReadLine();

                }

                else
                {
                    Console.WriteLine(string.Empty);
                    Console.WriteLine("Please input correct number:");
                    inputNumber = Console.ReadLine();
                }
                resultForTheCycle = CalculateCorrectInputSymbol(inputNumber, multiplyTable);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input number from 1 to 10 to see it's multiply table:");            
            int [] multiply = new[] { 1, 2, 3 ,4 ,5, 6, 7, 8, 9, 10 };
            var inputNumber = Console.ReadLine();
            ShowMultiplyTable(inputNumber, multiply);
            
        }
    }
}
