using System;

namespace ArrayApplication
{
    class ArrayDemo
    {
        static void Main(string[] args)
        {
            int[] my_array = new int[18];  // store exp in an array
            
			for (int i = 0; i < 18; i++)
            {
                my_array[i] = i + 500; // You can play with this part
            }

            //Display each element of the array
            for (int k = 0; k < 18; k++)
            {
                Console.WriteLine("Value at index[{0}] = {1}", j, my_array[j]);
            }
            Console.ReadKey();
        }
    }
}