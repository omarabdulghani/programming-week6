using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[20];
            int i = 0;
            int counter = 0;
            int n;



            do
            {

                Console.Write("Enter a number (0=stop): ");
                n = int.Parse(Console.ReadLine());
                
                

                if (i < numbers.Length) //..only calculates 20 inputs
                {
                    numbers[i] = n;
                }
                i++;

            } while (n != 0);


            //..looking for the searchvalue among the entered numbers

            Console.Write("Enter searchvalue: ");
            int searchvalue = int.Parse(Console.ReadLine());

            for (i = 0; i < numbers.Length; i++)
            {
                if (searchvalue == numbers[i])
                {
                    counter++;
                }
            }

            Console.Write("Number of occurences of searchvalue " + searchvalue + " is: " + counter);

            Console.ReadKey();
        }

    }        
}
