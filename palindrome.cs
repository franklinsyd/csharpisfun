using System;
namespace String_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            //Palindrome 
            // aba   abba  atuta
            //input the string
            //reverse the string and store into temporary string var
            //Compare the temp string with the input string
            // True/false

            string input_str, temp_str;
            Console.WriteLine("Enter your string");
            input_str = Console.ReadLine();

            //convert the string into an array of characters
            char[] inverse_char = input_str.ToCharArray(); // Will indexes

            //Reverse the array
            Array.Reverse(inverse_char);

            //place into the temp string, don't forget to get it back to string
            temp_str = new string(inverse_char);

            // check condition
            bool check_palindrome = input_str.Equals(temp_str, StringComparison.OrdinalIgnoreCase); // true or a false

            //Conduct the check
            if(check_palindrome == true)
            {
                Console.WriteLine(input_str + " is a palindrome");
            }
            else
            {
                Console.WriteLine(input_str + " is not a palindrome");
            }
            
            //Create a method called isPalindrome, it takes in a string,  returns a boolean (check_palindrome)

        }
    }
}