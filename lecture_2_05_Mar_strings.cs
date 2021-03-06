using System;

namespace lecture3_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter a string
            Console.WriteLine("Enter a String:");
            string my_string = Console.ReadLine();
            Console.WriteLine(my_string);

            //UpperCase
            Console.WriteLine("Print out the string in uppper case:");
            Console.WriteLine(my_string.ToUpper());

            //Lower Case
            Console.WriteLine("Print out the string in lower case:");
            Console.WriteLine(my_string.ToLower());

            Console.WriteLine("--------------------------------------");

            // You can concatenate or join string using the "+" operator
            Console.WriteLine("Enter the first string:");
            string str_1 = Console.ReadLine();
            
            Console.WriteLine("Enter the second string:");
            string str_2 = Console.ReadLine();

            //Contactenate the strings
            string str_3 = str_1 + str_2;

            //Print out the concatenated string
            Console.WriteLine("The concatenate string is "+ str_3);

            Console.WriteLine("--------------------------------------");

            //Working with substrings
            // A long string    
            string a_very_long_string = "I am feeling fantastic because I am working with awesome students";

            //Print the length of a string
            Console.WriteLine("The length of the above string is : " + (a_very_long_string.Length).ToString()); 

            // Get first 22 characters substring from a string    
            string sub_string = a_very_long_string.Substring(0, 22); //Starts from position 0 to position 2 , 3 is not included
            Console.WriteLine("First substring: "+ sub_string);

            //Get everything else after the 22 position
            string sub_string_2 = a_very_long_string.Substring(22);
            Console.WriteLine("Second substring: "+ sub_string_2);



        }
    }
}
