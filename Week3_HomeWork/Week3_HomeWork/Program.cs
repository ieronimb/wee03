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

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n\n------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercitiul 2: How to find all pairs of elements in an integer array, whose sum is equal to a given number ?");
            int[] array1 = new int[] { 1, 3, 5, 7, 9, 7, 6, 5, 6, 2, 9, 10 };

            for (int i1 = 0; i1 < array1.Length; i1++)
            {
                Console.Write(array1[i1] + " ");
            }

            int suma1;
            Console.WriteLine("\nInsert the number to be checked:");
            int numar = Convert.ToInt32(Console.ReadLine());

            for (int i1 = 0; i1 < array1.Length; i1++)
            {
                for (int j1 = 0; j1 < array1.Length; j1++)
                {
                    suma1 = array1[i1] + array1[j1];
                    if (suma1 == numar)
                    {
                        Console.WriteLine($"Sum of elements {array1[i1]} (position {i1}) + {array1[j1]} (position {j1}) => return a value of {suma1}");
                    }

                }
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n\n------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercitiul 4: Algorithm to find if Array contains duplicates?");

            int[] array2 = new int[] { 1, 2, 3, 4, 5, 6, 2, 6, 3, 5 };

            for (int i2 = 0; i2 < array2.Length; i2++)
            {
                Console.Write(array2[i2] + " ");
            }
            Console.WriteLine("\n>The above array has duplicates?");

            Console.WriteLine(ContainDuplicates(array2));
            //Console.WriteLine(">Which elements are the duplicates?");
            for (int i2 = 0; i2 < array2.Length; i2++)
            {
                int counter = 0;
                for (int j2 = i2 + 1; j2 < array2.Length; j2++)
                {
                    if (array2[i2] == array2[j2])
                    {
                        counter = counter + 1;
                        Console.WriteLine("The duplicate elements are {0}; ", array2[i2]);
                    }
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n\n------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercitiul 5: How to remove duplicates from a sorted linked list?");

            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(2);
            list.AddLast(2);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(4);
            list.AddLast(5);
            list.AddLast(5);
            LinkedList<int> duplicate = new LinkedList<int>();


            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            foreach (var i3 in list)
            {
                foreach (var j3 in list)
                {

                    if (!duplicate.Contains(i3))
                    {
                        duplicate.AddLast(i3);
                    }
                }
            }
            Console.WriteLine("\nThe unique values are");
            foreach (var j3 in duplicate)
            {
                Console.Write(j3 + " ");
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n\n------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercitiul 6: How to find sum of digits of a number using Recursion?");

            Console.WriteLine("Enter number for sum of digits: ");
            int n = Convert.ToInt32(Console.ReadLine());


            int sum = RecurtionFunction(n);

            Console.WriteLine("The result is {0}", sum);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n\n------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercitiul 7: Given an unsorted array which has a number in the majority (a number appears more than 50% in the array), find that number?");

            int[] array3 = new int[] { 5, 4, 3, 7, 5, 4, 5, 4, 4, 7, 5, 3, 3, 4, 5, 5, 5, 6, 6, 5, 5, 5, 5 };
            for (int i4 = 0; i4 < array3.Length; i4++)
            {
                Console.Write(array3[i4] + " ");
            }
            int count = 0;
            int majNum = 0;
            int number = 0;

            for (int i4 = 0; i4 < array3.Length; i4++)
            {
                for (int j4 = 0; j4 < array3.Length; j4++)
                {
                    if (array3[i4] == array3[j4])
                    {
                        count++;
                    }
                    if (count > majNum)
                    {
                        number = array3[i4];
                        majNum = count;
                        count = 0;
                    }
                }
            }

            Console.WriteLine("\nThe most repetitive element is {0}, from a total of {1} elements.", number, array3.Length);


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n\n------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercitiul 11: Write a function to print the nth number in Fibonacci series?");
            Console.WriteLine("Enter the number:");
            int numarF = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Fibonacci(numarF));


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n\n------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercitiul 16: Algorithm to check if a number is Prime or not?");
            int i5, j5 = 0;

            Console.Write("Write the number to be checked:\n");
            int numberP = Convert.ToInt32(Console.ReadLine());
            int NotPrime = numberP / 2;

            for (i5 = 2; i5 <= NotPrime; i5++)

            {

                if (numberP % i5 == 0)
                {
                    Console.WriteLine("{0} is not prime", numberP);
                    j5 = 1;
                    break;
                }
            }

            if (j5 == 0)
            {
                Console.WriteLine("{0} is prime", numberP);

            }


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n\n------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercitiul 17: Algorithm to check if a number is a Palindrome?");
            int num;
            int temp;
            int remainder;
            int reverse = 0;
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
            Console.WriteLine("\n\n------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercitiul 19: How to rotate an array by a given pivot?");
            int[] array4 = new int[] { 1, 2, 3 };
            var temporaryarr = array4[0];

            for (int i6 = 0; i6 < array4.Length; i6++)
            {
                Console.Write(array4[i6] + " ");
            }

            for (var i6 = 0; i6 < array4.Length - 1; i6++)
            {
                array4[i6] = array4[i6 + 1];
            }
            array4[array4.Length - 1] = temporaryarr;
            Console.WriteLine("\nAfter rotating array becomes:");

            for (int i6 = 0; i6 < array4.Length; i6++)
            {
                Console.Write(array4[i6] + " ");
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n\n------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercitiul 21: Sorting an Array using Bubble Sort");

            int[] array5 = new int[] { 23, 34, 27, 66, 33, 43, 56, 78 };
            for (int i7 = 0; i7 < array5.Length; i7++)
            {
                Console.Write(array5[i7] + " ");
            }
            int temporaryarr1;

            for (int j7 = 0; j7 <= array5.Length - 2; j7++)
            {
                for (int i7 = 0; i7 <= array5.Length - 2; i7++)
                {
                    if (array5[i7] > array5[i7 + 1])
                    {
                        temporaryarr1 = array5[i7 + 1];
                        array5[i7 + 1] = array5[i7];
                        array5[i7] = temporaryarr1;
                    }
                }
            }

            Console.WriteLine("\nBuble sort result:");
            foreach (int p in array5)
                Console.Write(p + " ");


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n\n------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercitiul 10: Write a Program which checks if two Strings are Anagram or not?");
            var string1 = new List<string>();
            var string2 = new List<string>();
           
            Console.WriteLine("1. Write first word to be checked:");
            string1.Add(Console.ReadLine());

            Console.WriteLine("2. Write the second word to be checked:");
            string2.Add(Console.ReadLine());

            for (int i8 = 0; i8 < string1.Count; i8++)
            {
                for (int j8 = string2.Count - 1; j8 >= 0; j8--)
                {
                    if (string1[i8] == string2[j8])
                    {
                        Console.WriteLine("{0} Is an anagram in comparison with {1}", string1[i8], string2[j8]);
                    }
                    else
                        Console.WriteLine("{0} Is not an anagram in comparison with {1}", string1[i8], string2[j8]);
                }
            }



            Console.ReadKey();
        }

        //Functie booleana daca exista duplicate intr-un array
        public static bool ContainDuplicates(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = i + 1; j < arr.Length; j++)
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

        public static int Fibonacci(int numar)
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
