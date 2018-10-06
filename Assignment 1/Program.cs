using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        { //.. computer inserts 20 random numbers (0 - 200) in an array of 20 then calculates average and difference between average & random number, displays results
            int[] numbers = new int[20];
            

            // fill array with numbers - display what's filled

            Random rnd = new Random();
            double sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0, 201);
                Console.WriteLine("Element " + i + " is " + numbers[i]);
                 sum += numbers[i]; //sum = sum + numbers[i]             

                

            }

            //.. calculate average

            double average = sum / numbers.Length;
            Console.WriteLine("\nThe average is: {0:0.00}\n", average);

            //.. calculate difference 

            for (int i = 0; i < numbers.Length; i++)
            {
                double difference = Math.Abs(average - numbers[i]);
                

                Console.WriteLine("Difference between average and element " + i + " is {0:0.00}", difference);
                



            }
            Console.ReadKey();
        }
    }
}
