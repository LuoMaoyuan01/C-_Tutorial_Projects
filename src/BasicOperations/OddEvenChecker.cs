using System;

namespace BasicOperations
{
    class OddEvenChecker{
        /* 
         * Define a variable to hold your name
         * Define a variable to hold your phone number
         * Define a variable to hold your age
         * Print variables line by line
         * Define variables using the "var" keyword
        */

        public static void Execute(){
            Console.WriteLine("Enter Number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
        
            int remainder = num2 % num1;

            if(remainder%2 == 0){
                Console.WriteLine($"The Remainder {remainder} Is Even");
            }else{
                Console.WriteLine($"The Remainder {remainder} Is Odd");
            }

        }
    }
}