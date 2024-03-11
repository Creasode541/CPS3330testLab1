// Michael Banko - CPS3330 Midterm SP24
using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp3 {
    class LINQtoArray {
        static void Main(string[] args) {
            int[] array = { 8,2,2,24,5,7,5,3,2,10 };


            var orderedFilteredArray =
                 from element in array
                 where element >= 6
                 orderby element descending
                 select element;

            PrintArray(orderedFilteredArray, "All values greater than or equal to 6 and sorted in descending order:");
        }
        public static void PrintArray(IEnumerable<int> arr, string message) {
            Console.WriteLine("{0}", message);

            foreach (var element in arr)
                Console.WriteLine(" {0}", element);

            Console.WriteLine();
        }
    }
}