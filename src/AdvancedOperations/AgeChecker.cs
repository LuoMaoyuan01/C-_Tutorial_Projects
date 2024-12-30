using System;

namespace AdvancedOperations
{
    public class AgeChecker
    {
        public static void Execute()
        {
            
            Console.Write("Enter Your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // (condition) ? true : false
            string result = (age >= 0 && age <= 100) ? string.Format("Your Age Is {0}", age) : "Invalid Age Entered";
            
            Console.WriteLine(result);

        }
    }
}