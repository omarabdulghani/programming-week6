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
        {
            int[] numbers = new int[20];
            string numbersText = "";
            // fill array with numbers
           
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }

            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                int value = rnd.Next(0, 200);
                
                + numbersText += numbers[i] + " ";

            }

            Console.WriteLine(numbersText);

            Console.ReadKey();
        }
    }
}
