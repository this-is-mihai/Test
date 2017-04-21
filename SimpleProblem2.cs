using System;

namespace TestAgileFreaks
{
     class SimpleProblem2
    {
        /*
         * Simple Problem2
         * Given an integer array of size N, identify the largest 2 numbers in this array. Do not sort the array
         */
        
        public void Largest2Numbers(int[] arr)
        {
            int largest1 = arr.GetLowerBound(0);
            int largest2 = arr.GetLowerBound(0);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > largest1)
                {
                    largest2 = largest1;
                    largest1 = arr[i];
                }
                else if (arr[i] > largest2 && arr[i] != largest1)
                    largest2 = arr[i];

            }
            if (largest1 == largest2)
                Console.WriteLine( "Largest number is " + largest1 + " and the second largest is equal to the first");
            else
                Console.WriteLine("Largest number is " + largest1 + " and the second largest is " + largest2);
        }  
    }
}
