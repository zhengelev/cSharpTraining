using System;
using System.Linq;
using System.Collections.Generic;

namespace _2020._04._27_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            var railwayCarriage = new List<RailwayCarriage>()
            {
                new RailwayCarriage{CarriageNumber = 1, ComfortLevel = "Economy"},
                new RailwayCarriage{CarriageNumber = 2, ComfortLevel = "Standart"},
                new RailwayCarriage{CarriageNumber = 3, ComfortLevel = "Priority"},
                new RailwayCarriage{CarriageNumber = 4, ComfortLevel = "Luxury"},
                
            };

            var passengers = new List<Passenger>()
            {
                new Passenger{PassengerName = "Jack Jilenhall",   LuggageCount = 0, CarriageNumber = 1},
                new Passenger{PassengerName = "Katy Jilenhall",   LuggageCount = 1, CarriageNumber = 1},
                new Passenger{PassengerName = "Mike Tyson",       LuggageCount = 0, CarriageNumber = 1},
                new Passenger{PassengerName = "Marshall Mathers", LuggageCount = 1, CarriageNumber = 1},
                new Passenger{PassengerName = "Adam Levine",      LuggageCount = 0, CarriageNumber = 1},
                new Passenger{PassengerName = "Lindsey Lohan",    LuggageCount = 1, CarriageNumber = 2},
                new Passenger{PassengerName = "Amiran Duraev",    LuggageCount = 0, CarriageNumber = 2},
                new Passenger{PassengerName = "Adam Brown",       LuggageCount = 1, CarriageNumber = 2},
                new Passenger{PassengerName = "Tracy Brown",      LuggageCount = 1, CarriageNumber = 2},
                new Passenger{PassengerName = "Mark Ivanov",      LuggageCount = 0, CarriageNumber = 2},
                new Passenger{PassengerName = "Regina Todorenko", LuggageCount = 1, CarriageNumber = 2},
                new Passenger{PassengerName = "Alexander Kumirov",LuggageCount = 2, CarriageNumber = 3},
                new Passenger{PassengerName = "Claudio Morallez", LuggageCount = 1, CarriageNumber = 3},
                new Passenger{PassengerName = "Antonio Fagundez", LuggageCount = 3, CarriageNumber = 3},
                new Passenger{PassengerName = "Phill Collins",    LuggageCount = 6, CarriageNumber = 4},
                new Passenger{PassengerName = "Alexi Minor",      LuggageCount = 5, CarriageNumber = 4},
            };

            var train = railwayCarriage.Join(passengers,
                carriage => carriage.CarriageNumber,
                passenger => passenger.CarriageNumber,
                (carriage, passenger) => new 
                {
                    CarriageNumber = passenger.CarriageNumber,
                    ComfortLevel = carriage.ComfortLevel,
                    PassengerName = passenger.PassengerName,
                    LuggageCount = passenger.LuggageCount
                });

            
            var summOfPassengers = train.Count();
            Console.WriteLine($"Total passengers: {summOfPassengers}");

            var countOfLuggage = train
                .Sum(count => count.LuggageCount);
            Console.WriteLine($"Total amount of luggage: {countOfLuggage}");
            Console.WriteLine();


            Console.WriteLine("Railway carriages are sorted by comfort level:");
            Console.WriteLine();
            var carriageSortByComfort = railwayCarriage
                .OrderBy(comfort => comfort.ComfortLevel);

            Console.WriteLine($"Class       Carriage number");
            foreach (var item in carriageSortByComfort)
            {
                Console.WriteLine($"{item.ComfortLevel} -       {item.CarriageNumber}");
            }

            var passengersPerCarriage = new List<RailwayCarriage>();            
            for (int i = 1; i <= railwayCarriage.Count; i++)
            {
                var carriageSumm = train
                    .Where(number => number.CarriageNumber == i)
                    .Count();
                passengersPerCarriage.Add(new RailwayCarriage {CarriageNumber = i, AmountOfPassengers = carriageSumm });
                
            }

            Console.WriteLine("To find the carriage by the amount of passengers, please enter the number:");
            bool loop = false;

            while (loop |!loop)
            {
                
                Console.WriteLine("From   ");
                var inputChar1 = Console.ReadLine();
                int startNumber;

                if (int.TryParse(inputChar1, out startNumber))
                {
                    Console.WriteLine("Till");

                    var inputChar2 = Console.ReadLine();
                    int endNumber;

                    if (int.TryParse(inputChar2, out endNumber))
                    {
                        var selectedCarriages = passengersPerCarriage
                        .Where(pasenger => pasenger.AmountOfPassengers >= startNumber & pasenger.AmountOfPassengers <= endNumber);

                        if (selectedCarriages.Count() == 0)
                        {
                            Console.WriteLine($"There is no carriages that matches your search");
                        }

                        foreach (var carriage in selectedCarriages)
                        {
                            Console.WriteLine($"Number of carriages: {carriage.CarriageNumber}");
                        }
                    }

                    else
                    {
                        Console.WriteLine("Invalid input, please enter the correct number!");
                    }
                }

                else
                {
                    Console.WriteLine("Invalid input, please enter the correct number!");
                }                
            }
            
            foreach (var item in passengersPerCarriage)
            {
                Console.WriteLine($"{item.CarriageNumber} - {item.AmountOfPassengers} ");
            }
        }
    }
}
