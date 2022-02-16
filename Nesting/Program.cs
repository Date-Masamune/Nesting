using System;

namespace Nesting
{
   class Program
      // Program to print a diamond pattern using nested loops
   {
      static void Main(string[] args)
      {
         int number, i, k, count = 1;
         Console.WriteLine("Enter Number of rows\n");
         number = int.Parse(Console.ReadLine());
         count = number - 1;
         for (k =1; k <= number; k++)
         {
            for (i = 1; i <= count; i++)
               Console.Write(" ");
            count--;
            for (i = 1; i <= 2 * k - 1; i++)
               Console.Write("*");
            Console.WriteLine();
         }
         count = 1; 
         for (k = 1; k <= number - 1; k++)
         {
            for (i = 1; i <= count; i++)
               Console.Write(" ");
            count++;
            for (i = 1; i <= 2 * (number - k) - 1; i++)
               Console.Write("*");
            Console.WriteLine();
         }

         Console.ReadLine();

      }
   }
}
