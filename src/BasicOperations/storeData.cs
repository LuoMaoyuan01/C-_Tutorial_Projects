using System;

namespace BasicOperations
{
    class StoreData{
        /* 
         * Define a variable to hold your name
         * Define a variable to hold your phone number
         * Define a variable to hold your age
         * Print variables line by line
         * Define variables using the "var" keyword
        */

        public static void Execute(){
            string name = "Mao";
            string phoneNumber = "98536814";
            int age = 19;

            Console.WriteLine("StoreData Class Starting Up...");
            Console.WriteLine("Personal Information Loading...");
            Console.WriteLine($"Name: {name}, Phone: {phoneNumber}, Age: {age}");
        }
    }
}