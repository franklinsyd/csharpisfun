// C# program to illustrate how looks work
using System;

class LoopsDemo
{
    public static void Main()
    {
        int x = 1; // initialize for the while

         // Exit when x becomes greater than 4 
         while (x <= 10) // Condition
         {
             Console.WriteLine("Counter is: " + x);

             // Do not forget Increment the value of x for 
             // next iteration 
             x++; // x = x + 1
         } 

         Console.WriteLine("########## For loop equivalent below ######");

         for (int i = 1; i <= 10; i++)
         {
             Console.WriteLine("Counter is: " + i);

             //  4/2 = 2    5/2 = 2.5 R=1 (0.5)    7/2 = 3 R 1
             // %   if ((input%2) == 0) even    if ((input%2) != 0) odd
             if (i%2 == 0)
             {
                 Console.WriteLine(i + " is an even number");
             }
             else
             {
                 Console.WriteLine(i + " is an odd number");
             }
         }
        Console.WriteLine("########## Use for ######");

        char[] arr_char = { 's', 'y', 'd', 'n', 'e', 'y' }; // [0 1 2 3 4 5] arr_char.Length = 6

        for (int k = 0; k < arr_char.Length; k++)
        {
            Console.WriteLine(arr_char[k]);
        }

        Console.WriteLine("########## Use foreach ######");
        
        foreach(char chr in arr_char)
        {
            Console.WriteLine(chr);
        }
          
      
    }
}