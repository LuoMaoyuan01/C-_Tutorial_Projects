using System;

namespace AdvancedOperations
{
    public class NumConverter
    {
        public static void Execute()
        {
            Console.Write("Enter A Number: ");
            string numInput = Console.ReadLine() ?? string.Empty;
            int num;

            bool success = int.TryParse(numInput, out num);
            
            if (success)
            {
                Console.WriteLine(num);
            }
            else{
                Console.WriteLine("Failed To Convert!");
            }

        }
    }
}