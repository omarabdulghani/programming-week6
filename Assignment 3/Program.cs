using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //..course name
            Console.Write("Enter course name: ");
            string course = Console.ReadLine();

            //..nr of students
            Console.Write("Enter number of students: ");
            int nrstudents = int.Parse(Console.ReadLine());

            double[] grades = new double[nrstudents];
            string[] names = new string[nrstudents];
            double sum = 0;

                                    Console.Write("\n");

            for (int i = 0 ; i < names.Length; i++ )
            {
                Console.Write("Enter name of student " + (i+1) + ": ");
                names[i] = Console.ReadLine();
            }

                                    Console.Write("\n");

            for (int i = 0; i < names.Length; i++)
            { 
                Console.Write("Enter grade of " + names[i] + ": ");
                 grades[i] = double.Parse(Console.ReadLine());
                sum += grades[i];
            }

            double max = grades[0];

            for (int i = 0; i < grades.Length; i++)

            {

                if (grades[i] > max)
                {
                    max = grades[i];
                }

            }
                double average = sum / grades.Length;

            Console.WriteLine("\nAverage grade: {0:0.00}", average);
            Console.WriteLine("Student " + "has the maximum grade: {0:0.00}", max);

                                    Console.Write("\n");

            for (int i = 0; i < grades.Length; i++)

            {

                Console.WriteLine("Grade for student " + names[i] + " " + "(Course " + course + ") is: {0:0.00}", grades[i]);
            }
            Console.ReadKey();
        }
    }
}
