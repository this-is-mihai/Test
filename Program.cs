using System;
using System.Collections.Generic;
using System.Linq;

namespace AgileFreaks
{
    public class Program
    {
        public static void Main(string[] args) { }
       /*
        * Simple Problem1
        * Given an integer array of size N, compute the sum of all even numbers in this array
        */

        public int SimpleProblem1(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum = sum + arr[i];
                }
            }
            return sum;
        }


        /*
         * Simple Problem2
         * Given an integer array of size N, identify the largest 2 numbers in this array. Do not sort the array
         */


        public String SimpleProblem2(int[] arr)
        {

            int l1 = arr.GetLowerBound(0);
            int l2 = arr.GetLowerBound(0);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > l1)
                {
                    l2 = l1;
                    l1 = arr[i];
                }
                else if (arr[i] > l2 && arr[i] != l1)
                    l2 = arr[i];
            }
            return (l1 + " and " + l2);
        }

        /*
         * Simple Problem3
         * Given an array of numbers having size N in which every number is between 1 and N, determine if there are any duplicates in it. 
         * You are allowed to destroy the array if you like. Do not sort the array or use bit vectors. 
         * Try to work within the array without using any other temporary data structures. 
         * Do not use 2 nesting for loops since the time complexity would be high. 
         * Try to find a solution by executing just one loop. Hint: manipulate the elements of the same array as you loop through. 
         */

        public bool SimpleProblem3(int[] arr)
        {
            bool duplicates = false;
            int origValue = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                origValue = arr[i];
                if (arr[i] < 0)
                    origValue = -1 * arr[i];
                if (arr[origValue - 1] < 0)
                {
                    duplicates = true;
                }
                else
                    arr[origValue - 1] = -1 * arr[origValue - 1];
            }
            return duplicates;
        }

    }
}