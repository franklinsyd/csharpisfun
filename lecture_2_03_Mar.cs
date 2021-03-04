using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter Your Name
            Console.WriteLine("Enter name:");
            // Read your name into a string variable
            string name = Console.ReadLine();

            // Enter Your Surname
            Console.WriteLine("Enter surname:");
            // Read your name into a string variable
            string surname = Console.ReadLine();

            // Print your name and surname
            Console.WriteLine("Your name is: " + name + " Your surname is: " + surname);

            // Enter your age
            Console.WriteLine("Age:");

            //Convert the age from a String to Int
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);
            
        }
    }
}