using System;

namespace APennyADayConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string output;
            long count = 0;
            long numDays = 0;
            long pennyTotal = 1;
            double dollarValue;

            //max 62
            Console.WriteLine("Enter number of days up to 62 (x to exit): ");
            input = Console.ReadLine();

            while (input != "x")
            {
                pennyTotal = 1;
                count = 0;

                numDays = Convert.ToUInt64(input);
                Console.WriteLine("days " + numDays);
                while (count != numDays)
                {
                    pennyTotal = pennyTotal + pennyTotal;
                    Console.WriteLine("cur " + pennyTotal);
                    count++;
                }

                dollarValue = pennyTotal / 100.0;

                output = Math.Round(dollarValue, 2).ToString();

                Console.WriteLine("Total in cents is: " + pennyTotal);
                Console.WriteLine("Total in Dollars is: $" + output);

                //max 62
                Console.WriteLine("Enter number of days up to 62 (x to exit): ");
                input = Console.ReadLine();
            }
        }
    }
}
