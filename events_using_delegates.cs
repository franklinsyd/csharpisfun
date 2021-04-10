//Our own code to demonstrate how delegates work with events
// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/events/

using System;

namespace OurOwnEventApplication
{
    //Delegate that will handle the event
    public delegate string del_fn(string str);

    class TestOurOwnEvent
    {
        //decalre an event 
        event del_fn test_event;

        // we implement the event
        public TestOurOwnEvent()
        {
            this.test_event += new del_fn(this.ErrorHandlingFn); // del_fn takes in a function
        }

        //Implementation of the ErrorHandlingFn  function
        public string ErrorHandlingFn(string error_content)
        {
            string err = "Something bad happned at VC labs, this is the error content: " + error_content;
            return err;
        }

        //Driver code
        static void Main(string [] args)
        {
            TestOurOwnEvent event_obj = new TestOurOwnEvent();

            //Enter the error content below
            Console.WriteLine("Enter your error content below: ");
            string error_content_1 = Console.ReadLine();
            
            //Pass the error content to the event
            string error_1 = event_obj.test_event(error_content_1);
            Console.WriteLine(error_1);


        }


    }
}

