using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method 1: intialization 
            // Pro: most space controlled
            // Con: requires knowing max size initally
            // Follows path: datatype[] arrayName = new datatype[size];
            int[] declaredArray = new int[5];
            int i, j;

            // Adding elements to the declared array
            for ( i = 0; i <= 5; i++)
            {
                declaredArray[i] = i;
            }

            for (j = 0; j <= 5; j++)
            {
                Console.WriteLine($"Elecment[{0}] = {1}", j, declaredArray[j]);
            }
            Console.ReadKey();
        }
    }
}
