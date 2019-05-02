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
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            //Console.WriteLine("Exercitiul 1: Given an array of ints, write a C# method to total all the values that are even number.");
            //int suma = 0;
            //int[] array = new int[13] { 1, 15, 7, 11, 3, 9, 6, 4, 14, 10, 5, 8, 14 };
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.Write("\n");
            //for (int i = 0; i < array.Length; i++)
            //{

            //    if (array[i] % 2 == 0)

            //    {
            //        suma += array[i];
            //        Console.WriteLine("The even element is {0} and the sum is {1}.", array[i], suma);
            //    }
            //}

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            //Console.WriteLine("Exercitiul 2: How to find all pairs of elements in an integer array, whose sum is equal to a given number ?");
            //int[] array1 = new int[] { 1, 3, 5, 7, 9, 7, 6, 5, 6, 2, 9, 10 };

            //for(int i = 0; i < array1.Length; i++)
            //{
            //    Console.Write(array1[i] + " ");
            //}

            //int suma1;
            //Console.WriteLine("\nInsert the number to be checked:");
            //int numar = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < array1.Length; i++)
            //{
            //    for (int j = 0; j < array1.Length; j++)
            //    {
            //        suma1 = array1[i] + array1[j];
            //        if (suma1 == numar)
            //        {
            //            Console.WriteLine($"Sum of elements {array1[i]} (position {i}) + {array1[j]} (position {j}) => return a value of {suma1}");
            //        }

            //    }
            //}

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            //Console.WriteLine("Exercitiul 3: How to calculate factorial using recursion in C# + iterative + time difference.");




            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            //Console.WriteLine("Exercitiul 4: Algorithm to find if Array contains duplicates?");

            //int[] array2 = new int[] { 1, 2, 3, 4, 5, 6, 2, 6, 3, 5 };

            //for (int i = 0; i < array2.Length; i++)
            //{
            //    Console.Write(array2[i] + " ");
            //}
            //Console.WriteLine("\n>The above array has duplicates?");

            //Console.WriteLine(ContainDuplicates(array2));
            ////Console.WriteLine(">Which elements are the duplicates?");
            //for (int i = 0; i < array2.Length; i++)
            //{
            //    int counter = 0;
            //    for (int j = i + 1; j < array2.Length; j++)
            //    {
            //        if (array2[i] == array2[j])
            //        {
            //            counter = counter + 1;
            //            Console.WriteLine("The duplicate elements are {0}; ",array2[i]);
            //        }
            //    }
            //}
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            //Console.WriteLine("Exercitiul 5: How to remove duplicates from a sorted linked list?");

            //LinkedList<int> list = new LinkedList<int>();
            //list.AddFirst(2);
            //list.AddLast(2);
            //list.AddLast(2);
            //list.AddLast(3);
            //list.AddLast(3);
            //list.AddLast(4);
            //list.AddLast(4);
            //list.AddLast(5);
            //list.AddLast(5);
            //LinkedList<int> duplicate = new LinkedList<int>();


            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}

            //foreach (var i in list)
            //{
            //    foreach (var j in list)
            //    {

            //        if (!duplicate.Contains(i))
            //        {
            //            duplicate.AddLast(i);                  
            //        }
            //    }
            //}
            //Console.WriteLine("\nThe unique values are");
            //foreach (var j in duplicate)
            //{
            //    Console.Write(j + " ");
            //}

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            //Console.WriteLine("Exercitiul 6: How to find sum of digits of a number using Recursion?");

            //Console.WriteLine("Enter number for sum of digits: ");
            //int n = Convert.ToInt32(Console.ReadLine());


            //int sum = RecurtionFunction(n);

            //Console.WriteLine("The result is {0}",sum);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            //Console.WriteLine("Exercitiul 7: Given an unsorted array which has a number in the majority (a number appears more than 50% in the array), find that number?");

            //int[] array3 = new int[] { 5, 4, 3, 7, 5, 4, 5, 4, 4, 7, 5, 3, 3, 4, 5, 5, 5, 6, 6, 5, 5, 5, 5 };
            //for (int i = 0; i < array3.Length;i++)
            //{
            //    Console.Write(array3[i] + " ");
            //}
            //int count = 0;
            //int majNum = 0;
            //int number = 0;

            //for (int i = 0; i < array3.Length;i++)
            //{
            //    for (int j = 0; j < array3.Length;j++)
            //    {
            //        if (array3[i] == array3[j])
            //        {
            //            count++;
            //        }
            //        if (count > majNum)
            //        {                       
            //            number = array3[i];                       
            //            majNum = count;
            //            count = 0;
            //        }   
            //    }
            //}

            //Console.WriteLine("\nThe most repetitive element is {0}, from a total of {1} elements.", number,array3.Length);           


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            //Console.WriteLine("Exercitiul 8: How to detect a cycle in a singly linked list?");


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            //Console.WriteLine("Exercitiul 9: How to merge two sorted linked list, write a program in your favorite programming language e.g. Java, C#");

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            //Console.WriteLine("Exercitiul 10: Write a Program which checks if two Strings are Anagram or not?");

            //Console.WriteLine(">>Enter the first word to be checked for anagram");
            //string word1 = Console.ReadLine();
            //Console.WriteLine(">>Enter the second word to be confronted with the first wot for anagram");
            //string word2 = Console.ReadLine();
            //string initial = "";


            //for (int i = 0; i < word1.Length; i++)
            //{

            //    for (int j = i + 1; j < word1.Length; j++)
            //    {

            //        if (word1.Length == word1.Length)
            //        {
            //            initial += word1.Length;

            //        }
            //        Console.WriteLine(initial);
            //    }
            //}

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            //Console.WriteLine("Exercitiul 11: Write a function to print the nth number in Fibonacci series?");
            //Console.WriteLine("Enter the number:");
            //int n = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(Fibonacci(n));       

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercitiul 12: Write a function to count a total number of set bits in a 32-bit Integer?");

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            //Console.WriteLine("Exercitiul 13: Write a function to remove duplicate characters from String?");

            //string textwithdup = "afffrdeeeed";
            ////string textwithoutdup = "";

            //for (var i = 0; i < textwithdup.Length; i++)
            //{
            //    for (var j = 0; j < textwithdup.Length; i++)
            //    {
            //        if (i != j)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}
            




            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercitiul 14: How to find the 3rd element from the end, in a singly linked, in a single pass?");

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercitiul 15: C# program to check if a number is Armstrong number or not?");

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercitiul 16: Algorithm to check if a number is Prime or not?");

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercitiul 17: Algorithm to check if a number is a Palindrome?");           
            int num, temp, remainder, reverse = 0;
            Console.WriteLine("Enter a number to check for Palindrome");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;

            while (num > 0)
            {
                remainder = num % 10; //for getting remainder by dividing with 10
                reverse = reverse * 10 + remainder;  //multiplying the sum with 10 and adding remainder 
                num = num / 10;  //for getting quotient by dividing with 10
            }
            if (temp == reverse)
            {
                Console.WriteLine("Number {0} is a palindrome, as its reverse is {1}.", temp, reverse);
            }
            else
            {
                Console.WriteLine("Number {0} is not a palindrome, as its reverse is {1}.", temp, reverse);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercitiul 18: Write code to reverse a linked list, if you able to do it using loops, try to solve with recursion?");

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercitiul 19: How to rotate an array by a given pivot?");

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercitiul 20: Sorting an Array using Selection Sort");

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercitiul 21: Sorting an Array using Bubble Sort");



            Console.ReadKey();
        }

        //Functie booleana daca exista duplicate intr-un array
        public static bool ContainDuplicates (int [] arr)
        {
            for (int i = 0; i<arr.Length;i++)
            {
               
                for (int j = i + 1;j<arr.Length;j++)
                {
                    if (arr[i] == arr[j])                   
                    return true;
                }
            }
            return false;
        }

        //Functie int pentru sum of digits usingh recurtion
        public static int RecurtionFunction(int val)
        {
            if (val != 0)
            {
                return (val % 10 + RecurtionFunction(val / 10));
            }
            else
            {
                return 0;
            }
        }

        //Functie int pentru nth Fibonacci calcul (recursiv)

        public static int Fibonacci (int numar)
        {
            if (numar == 0) return 0;
            else if (numar == 1) return 1;
            else
            {
                return Fibonacci(numar - 1) + Fibonacci(numar - 2);
            }
        }

    }
}
