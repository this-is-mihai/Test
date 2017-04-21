using System;

namespace TestAgileFreaks
{
    /*
     * Simple Problem3
     * Given an array of numbers having size N in which every number is between 1 and N, determine if there are any duplicates in it. 
     * You are allowed to destroy the array if you like. Do not sort the array or use bit vectors. 
     * Try to work within the array without using any other temporary data structures. 
     * Do not use 2 nesting for loops since the time complexity would be high. 
     * Try to find a solution by executing just one loop. Hint: manipulate the elements of the same array as you loop through. 
     */

     /*
      * Can be simplified by removing the code that displays in console the duplicates found.
      */
   
    class SimpleProblem3
    {
         public void FindDuplicates(int[] arr)
        {
            bool noDuplicates = true;
            int origValue = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                origValue = arr[i];
                if (arr[i] < 0)
                    origValue = -1 * arr[i];
                if (arr[origValue - 1] < 0)
                {
                    Console.WriteLine("Duplicate number found: " + origValue);
                    noDuplicates = false;
                }
                else
                    arr[origValue - 1] = -1 * arr[origValue - 1];
            }
            if (noDuplicates)
                Console.WriteLine("No duplicates were found in the array.");
        }
    }

}
