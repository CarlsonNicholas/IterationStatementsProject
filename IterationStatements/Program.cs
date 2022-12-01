using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
//Exercise 2: Nick Carlson 
namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
                //TODO - Read each comment and complete its instruction
                // like the example below

                //Create a List called "numbers" - DONE!
                var numbers = new List<int>();
            
            //-----START HERE------------------------------------------
            //Create a variable of type int and name it num
            //initialize the variable with a value of 0 - DONE!

            int num = 0;



            // Create a do-while loop and use the template below: DONE!

            do
            {
                num++;

                // Then add num to the collection - numbers
                // Hint: reference num inside of the Add method's parentheses
                numbers.Add(num);

            } while (num < 100); 



            // Create a while loop DONE!
            while (num < 200) 
            {
                num++;
                numbers.Add(num);
                // Then add num to the collection numbers
                    //HINT: copy how this was done in the do while loop

            }


            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");

            foreach (int i in numbers) {Console.WriteLine(i); }


            // Create a foreach loop using the collection - numbers
                //In the scope of the foreach loop, print each number in numbers - DONE!
             


            Console.WriteLine("");
            Console.WriteLine("Decrease:");


            // Create a for loop - this will print the numbers in reverse order - from 200 to 1
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
            // AND as long as i is greater than or equal to 0
            // Decrement i by 1

            for (int i = 199; i <= (numbers.Count) && i >= 0; i--)
            {
                // place numbers[i] inside of the Console.WriteLine() method
                Console.WriteLine(i);
            }

            //------------End of exercise - Done!!
        }
    }
}
