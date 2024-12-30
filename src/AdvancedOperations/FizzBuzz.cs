using System;

namespace AdvancedOperations
{
    public class FizzBuzz
    {
        /*
         * Create a loop from 1 - X (15)
         * 3 & 5 = FizzBuzz
         * 3 = Fizz
         * 5 = BUzz
         * else = number
        */

        public static void Execute()
        {
            
            for (int i = 1; i <= 15; i++){
                if (i % 3 == 0 && i % 5 == 0){
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 3 == 0){
                    Console.WriteLine("Fizz");
                }
                else if(i % 5 == 0){
                    Console.WriteLine("Buzz");
                }
                else{
                    Console.WriteLine($"{i}");
                }
            }

            Console.ReadLine();

        }
    }
}