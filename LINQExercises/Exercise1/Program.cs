// Michael Banko - CPS 3330 Midterm SP24
using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp2 {
    class LINQtoArray {
        static void Main(string[] args){
            int[] array = { 8,2,2,24,5,7,5,3,2,10 }; 
            var filteredArray =         // LINQ query
                from element in array
                where element >= 8
                select element;
            PrintArray(filteredArray, "All values greater or equal to 8:");}

        public static void PrintArray(IEnumerable<int> arr, string message){
            Console.WriteLine("{0}", message);

            foreach (var element in arr)
                Console.WriteLine(" {0}", element);

            Console.WriteLine();
        }}}
