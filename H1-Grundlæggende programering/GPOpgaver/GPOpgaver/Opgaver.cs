﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GPOpgaver
{
    public static class Opgaver
    {
        /*
        * Introduktion til Algoritmer
        * Exercise 1. 
        * Describe an algorithm that interchanges the values of the variables x and y, using only assignment statements.
        * What is the minimum number of assignment statements needed to do so?
        */
        public static void Interchange(ref int x, ref int y)
        {
            //Write your solution here
            int tmp = x;
            x = y;
            y = tmp;
        }
        /*
        * Introduktion til Algoritmer
        * Exercise 2. 
        * 2.Describe an algorithm that uses only assignment statements to replace thevalues of the triple(x, y, z) with (y, z, x).
        * What is the minimum number of assignment statements needed?
        */
        public static void InterchangeTriple(ref int a, ref int b, ref int c)
        {
            //Write your solution here
            int tmp = a;
            a = c;
            c = b;
            b = tmp;
        }
        /*
         * Introduktion til Algoritmer
         * Exercise 3.
         * A palindrome is a string that reads the same forward and backward.
         * Describe an algorithm for determining whether a string of n characters is a palindrome.
         */
        public static bool IsPalindrome(string s)
        {
            //throw new NotImplementedException();
            //Write your solution here
            char[] palin = s.ToCharArray();
            Array.Reverse(palin);
            return true;
        }
        /*
         * Introduktion til Algoritmer
         * Exercise 4.a.
         * List all the steps used to search for 9 in the sequence 1, 3, 4, 5, 6, 8, 9, 11
         * Do this by completing the unit test for 4A
         */
        public static int StepsInLinearSearch(int searchFor, int[] intergerArray)
        {
            //throw new NotImplementedException();
            //Write your solution here
            for (int i = 0; i < intergerArray.Length; i++)
            {
                if (searchFor == intergerArray[i]) return i + 1;
            }

            return -1;
        }
        /*
         * Introduktion til Algoritmer
         * Exercise 4.b.
         * List all the steps used to search for 9 in the sequence 1, 3, 4, 5, 6, 8, 9, 11
         * Do this by completing the unit test for 4B
         */
        public static int StepsInBinarySearch(int[] integerArray, int arrayStart, int arrayEnd, int searchFor)
        {
            //throw new NotImplementedException();
            //Write your solution here
            if (arrayStart >= arrayEnd)
            {
                return +1;
            }
            else
            {
                int mid = (arrayEnd + arrayStart) / 2;
                if (searchFor == integerArray[mid])
                {
                    return 1;
                }
                else if (searchFor < integerArray[mid])
                {
                    return 1 + StepsInBinarySearch(integerArray, arrayStart, mid - 1, searchFor);
                }
                else
                {
                    return 1 + StepsInBinarySearch(integerArray, mid + 1, arrayEnd, searchFor);
                }
            }
        }
        /*
         * Introduktion til Algoritmer
         * Exercise 5.
         * Describe an algorithm based on the linear search for de-termining the correct position in which to insert a new element in an already sorted list.
         */
        public static int InsertSortedList(List<int> sortedList, int insert)
        {
            //throw new NotImplementedException();
            //Write your solution here
            for (int i = 0; i < sortedList.Count - 1; i++)
            {
                if (insert < sortedList[i])
                {
                    sortedList.Insert(i, insert);
                    return i;
                }
            }
            return 1;

        }
        /*
         * Exercise 6.
         * Arrays
         * Create a function that takes two numbers as arguments (num, length) and returns an array of multiples of num up to length.
         * Notice that num is also included in the returned array.
         */
        public static int[] ArrayOfMultiples(int num, int length)
        {
            //throw new NotImplementedException();
            //Write your solution here
            int[] array = new int[length];
            for (int i = 1; i <= length; i++)
            {
                array[i - 1] = num * i;
            }

            return array;
        }
        /*
         * Exercise 7.
         * Create a function that takes in n, a, b and returns the number of values raised to the nth power that lie in the range [a, b], inclusive.
         * Remember that the range is inclusive. a < b will always be true.
         */
        public static int PowerRanger(int power, int min, int max)
        {
            //throw new NotImplementedException();
            //Write your solution here
            int counter = 0;

            for (int i = 1; (int)Math.Pow(i, power) <= max; i++)
            {
                if (Math.Pow(i, power) >= min)
                    counter++;
            }
            return counter;
        }
        /*
         * Exercise 8.
         * Create a Fact method that receives a non-negative integer and returns the factorial of that number.
         * Consider that 0! = 1.
         * You should return a long data type number.
         * https://www.mathsisfun.com/numbers/factorial.html
         */
        public static long Factorial(int n)
        {
            //throw new NotImplementedException();
            //Write your solution here

            //int res = 1, i;

            //for (i = 2; i <= n; i++)
                //res *= i;
            //return res;

            return (n == 1 || n == 0) ? 1 : n * Factorial(n - 1);


        }
        /*
         * Exercise 9.
         * Write a function which increments a string to create a new string.
         * If the string ends with a number, the number should be incremented by 1.
         * If the string doesn't end with a number, 1 should be added to the new string.
         * If the number has leading zeros, the amount of digits should be considered.
         */
        public static string IncrementString(string txt)
        {
            //throw new NotImplementedException();
            //Write your solution here
            string[]
            string digits = new string(txt.Where(char.IsDigit).ToArray());
            string letters = new string(txt.Where(char.IsLetter).ToArray());

            int number;
            if (!int.TryParse(digits, out number))
            {
                Console.WriteLine("Something weired happened");
            }

            string newStr = letters + (++number).ToString("D5");
        }
    }
}