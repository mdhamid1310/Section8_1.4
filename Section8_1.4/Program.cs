using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section8_1._4
{
   

        class Program
        {
            static void Main(string[] args)
            {
                runApp();
            Console.ReadLine();
        }

            public static void runApp()
            {
            string[] students3A = { "Alice", "Bob", "Catherine", "David", "Ella", "Frank", "Grace", "Henry", "Ivy", "Jack" };
            string[] students3B = { "Lily", "Matthew", "Nora", "Oliver", "Penelope", "Quinn", "Samuel", "Tiffany", "Ulysses", "Victoria" };


            string[] subjects = { "Physics", "Chemistry", "Biology", "Calculus", "Computer Science", "Algebra" };
                int[] marks = { 67, 90, 80, 55, 71, 92 };

            Console.WriteLine("Students of Class 3A:");
            for (int i = 0; i < students3A.Length; i++)
            {
                Console.WriteLine(students3A[i] + " ");
            }
            Console.WriteLine("Students of Class 3B:");
            for (int i = 0; i < students3B.Length; i++)
            {
                Console.WriteLine(students3B[i] + " ");
            };

              
            }
        
    }

}
