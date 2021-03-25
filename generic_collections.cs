using System;
using System.Collections.Generic;

namespace Generic_Collection
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("====== Lists ========");
            // List<T>
            List<int> even_numbers = new List<int>();

            // Add some elements to the list
            even_numbers.Add(2);
            even_numbers.Add(4);
            even_numbers.Add(34);
            even_numbers.Add(36);
            even_numbers.Add(34);
            
            //loop through the list
            for (int x = 0; x < even_numbers.Count; x++)
            {
                Console.WriteLine("{0} is at index [{1}]", even_numbers[x], x);

            }

            //Let add 1 to each element of the list to transform them into odd numbers
            int k = 0;
            while (k < even_numbers.Count)
            {
                even_numbers[k] = even_numbers[k] + 1;
                Console.WriteLine("The new value at index [{0}] is {1}", k, even_numbers[k]);
                k++;  // Same as =>  k = k + 1

            }

            Console.WriteLine("====== Queues ========");
            // Queue<T>
            Queue<string> student_names = new Queue<string>();

            // Add some elements to the queue
            student_names.Enqueue("Sydney");
            student_names.Enqueue("John");
            student_names.Enqueue("Mark");
            student_names.Enqueue("Jeff");

            //let print those names
            foreach (string name in student_names)
                Console.WriteLine(name);

            //lets remove an element from the queue
            student_names.Dequeue();
            
            Console.WriteLine("====== After Dequeuing ========");
            
            foreach (string name in student_names)
                Console.WriteLine(name);


            Console.WriteLine("====== Dictionaries ========");
            //Dictionaries Dictionary<TKey, TValue>

            IDictionary<int, string> SA_cities = new Dictionary<int, string>();
            SA_cities.Add(1, "Pretoria");
            SA_cities.Add(2, "Cape Town");
            SA_cities.Add(3, "Durban");

            //Access Data in a Dictionary
            foreach (KeyValuePair<int, string> kvp in SA_cities)
                Console.WriteLine("At key: {0}, we have the following SA City {1}", kvp.Key, kvp.Value);

            Console.WriteLine("====== Dictionaries 2 ========");
            //Another way to use Dictionaries 
            IDictionary<string, string> SA_cities_p = new Dictionary<string, string>();
            SA_cities_p.Add("Gauteng", "Pretoria");
            SA_cities_p.Add("Western Cape", "Cape Town");
            SA_cities_p.Add("KwaZulu Natak", "Durban");

            foreach (KeyValuePair<string, string> kvp in SA_cities_p)
                Console.WriteLine("{0} is in {1}", kvp.Value, kvp.Key);

            Console.WriteLine("====== Access an element in a dictionary ========");
            // Access Values using the key
            Console.WriteLine(SA_cities_p["Gauteng"]);


            Console.WriteLine("====== Stacks ========");

            Stack<string> car_names = new Stack<string>();
            car_names.Push("Toyota");
            car_names.Push("Mazda");
            car_names.Push("Lamborghini");
            car_names.Push("Mercedes Benz");

            //Display stuff from the stack
            foreach (var things in car_names)
                Console.Write("\n" +things);
        }

    }
}
