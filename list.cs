using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // declare a list that will hold integers.
        var my_list = new List<int>();
        my_list.Add(11);
        my_list.Add(16);
        my_list.Add(21);
        my_list.Add(22);
		my_list.Add(25);
        Console.WriteLine("My list contains: " + my_list.Count + " values.");

        // The following codes does that same as above
        var my_list_2 = new List<int>() { 11, 16, 21, 22, 25};
        Console.WriteLine("My list 2 contains: " + my_list_2.Count + " values.");
		
		//You can also declare list and have them contain other types
		// var my_list = new List<double>();
		// var my_list = new List<float>();
		// var my_list = new List<string>();
    }
}