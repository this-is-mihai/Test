using System;

namespace TestAgileFreaks
{
    class Program
    {
        public static int[] arrayN = {1, 2, 3, 6, 2, 8, 1, 10, 7, 6, 7, 10};
        //public static int[] arrayN = { 1, 2, 3, 4, 5, 7, 6};
        //private static int[] arrayN = {};
        //private static int[] arrayN = { -10, 1, 3, -10, 5, 5, 7, 8, 9, 9};
        public static void Main(string[] args)
        {
            // Creating objects for methods
            SimpleProblem1 answer = new SimpleProblem1();
            SimpleProblem2 answer2 = new SimpleProblem2();
            SimpleProblem3 answer3 = new SimpleProblem3();

            // display initial string
            Console.WriteLine("Array: " + (String.Join("; ", arrayN)));

            // execute
            answer.SumEvenNumbers(arrayN);
            answer2.Largest2Numbers(arrayN);
            answer3.FindDuplicates(arrayN);


        }
    }
}