using System;

namespace MultiplicationOfNums
{
    class Program
    {
        static void Main(string[] args)
        // Create a console application that, given a comma separated list of strings, prints the result of multiplying the values together.
        /* EX. INPUT = "1,2,3" 
           Ex. OUPUT = 6; */
        {
            var numbers = "1, 2, 3";
            // Line below is splitting the string at the commas and creating an array with those values
            string[] splitNumbers = numbers.Split(",");
            // Line below is creating a var to multiply each value that is loop over creating a new value through each loop so that the next number is multiplied by the previous number
            var total = 1;

            foreach(var number in splitNumbers)
            {
                // parse the string value of the value in the loop into a number
             var num = int.Parse(number);
                total *= num;
            }
            Console.Write(total);
            Console.ReadLine();
        }
    }
}
