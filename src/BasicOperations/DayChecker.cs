using System;

namespace BasicOperations
{
    public class DayChecker
    {
        public static void Execute()
        {   
            bool invalid = true;

            while (invalid)
            {
                Console.Write("Enter the day of a week (Numerical): ");

                // Since Console.ReadLine() may return null, we assign it an empty string in that event to prevent errors
                string dayInput = Convert.ToString(Console.ReadLine() ?? string.Empty);
                invalid = false;

                switch(dayInput)
                {
                    case "1": Console.WriteLine("Monday");
                        break;
                    case "2": Console.WriteLine("Tuesday");
                        break;
                    case "3": Console.WriteLine("Wednesday");
                        break;
                    case "4": Console.WriteLine("Thursday");
                        break;
                    case "5": Console.WriteLine("Friday");
                        break;
                    case "6":
                    case "7": Console.WriteLine("Weekday");
                        break;
                    default: Console.WriteLine("Invalid Number, Please Retry.");
                        invalid = true;
                        break;
                }
            }

        }
    }
}