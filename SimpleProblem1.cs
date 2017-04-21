using System;

namespace TestAgileFreaks
{
    public class SimpleProblem1
    {
        /*
         * Simple Problem1
         * Given an integer array of size N, compute the sum of all even numbers in this array
        */
        public void SumEvenNumbers(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum = sum + arr[i];
                }
            }
            Console.WriteLine("The sum of all even numbers is: " + sum);
        }

        public int SumEvenNumbersWG(int[] arr)
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

    }
}
