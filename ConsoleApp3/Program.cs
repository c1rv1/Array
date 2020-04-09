using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] digits = new byte[5];

            digits[0] = 34;
            digits[4] = 255;

            Console.WriteLine(digits[3]);

            string[] students = new string[] { "Bob", "Mickle", "George", "Alex" };

            Console.WriteLine(students[1]);

            int len = students.Length;

            Console.WriteLine(len);

            string[] copyStudents = new string[len];

            students.CopyTo(copyStudents, 0);

            foreach (string el in copyStudents)
            {

                Console.Write(" {0}", el);
                if (el.Length == copyStudents.Length)
                {
                    Console.WriteLine();
                }
            }

            short[,] nums = new short[5, 2];

            int[,] numbers = { { 5, 32, 1 }, { 23, 34, 51 }, { 45, 6, 34 } };

            //Array.Clear(students,0,len);

            numbers[1, 1] = 50;

            Console.WriteLine(numbers[1, 1]);

            Console.ReadKey();


        }
    }
}

