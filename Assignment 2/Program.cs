using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            Random rnd = new Random();
            int counter = 0;
            

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0, 151);
                Console.WriteLine("Element " + i + " = " + numbers[i] );

                
            }

            int smallest = numbers[0];

            for (int i = 0; i < numbers.Length;  i++)

            {
                
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];

                }

               else if (numbers[i] == smallest)


                {

                    counter++;

                    }


            }

            
                


            Console.WriteLine("\nSmallest number = " + smallest);
            Console.WriteLine("Number of occurance = " + counter);

            Console.ReadKey();

        }
    }
}
