using System;

namespace AdvancedOperations
{
    public class TimesTable
    {
        /*
         * Asks user for a number for the table
         * Write a for loop to print out x Times Table
        */

        public static void Execute()
        {
            int result, num;
            Console.Write("Enter A Number: ");
            string numInput = Console.ReadLine() ?? string.Empty;
            bool success = int.TryParse(numInput, out num);
            
            if(success){
            }else{
                Console.WriteLine("Invalid Entry");
                return;
            }

            for(int i = 1; i < 10; i++){
                result = i * num;
                Console.WriteLine($"{i} x {num} = {result}");
            }
        }
    }
}