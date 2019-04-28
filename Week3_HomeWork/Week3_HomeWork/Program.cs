using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercitiul 1: Given an array of ints, write a C# method to total all the values that are even number.");
            int suma = 0;
            int[] array = new int[13] { 1, 15, 7, 11, 3, 9, 6, 4, 14, 10, 5, 8, 14 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.Write("\n");
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] % 2 == 0)

                {
                    suma += array[i];
                    Console.WriteLine("The even element is {0} and the sum is {1}.", array[i], suma);
                }
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercitiul 2: How to find all pairs of elements in an integer array, whose sum is equal to a given number ?");
            int suma1;
            Console.WriteLine("Insert the number to be checked:");
            int numar = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[] { 1, 3, 5, 7, 9, 7, 6, 5, 6, 2, 9, 10 };

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array1.Length; j++)
                {
                    suma1 = array1[i] + array1[j];
                    if (suma1 == numar)
                    {
                        Console.WriteLine($"Sum of elements {array1[i]} (position {i}) + {array1[j]} (position {j}) => return a value of {suma1}");
                    }

                }
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercitiul 2: How to find all pairs of elements in an integer array, whose sum is equal to a given number ?");
                       


            Console.ReadKey();
        }
    }
}
