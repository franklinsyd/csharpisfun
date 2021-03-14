// C# program to illustrate encapsulation
// encapsulation is a protective shield that prevents the data from being accessed by the code outside this shield.
using System;

public class ExampleEncapsulation
{

    // Private variables declared 
    // These can only be accessed by public methods of the class 
    private String car_brand;
    private int year_model;


    // Using accessors to get and set the value of car_brand 
    public String BrandName
    {

        get
        {
            return car_brand;
        }

        set
        {
            car_brand = value;
        }

    }

    // using accessors to get and set the value of year_model 
    public int YearModel
    {

        get
        {
            return year_model;
        }

        set
        {
            year_model = value;
        }

    }


}

// Driver Class 
class MyDriverClass
{

    // Main Method 
    static public void Main()
    {

        // creating a new car object 
        ExampleEncapsulation car_obj = new ExampleEncapsulation(); // remember, we did not use a Constructor

        Console.WriteLine("Enter the car brand: ");
        String brand = Console.ReadLine();

        Console.WriteLine("Enter the year model: ");
        String year = Console.ReadLine();

        
        car_obj.BrandName = brand;
        car_obj.YearModel = Int32.Parse(year);

        // Output the values of the variables
        Console.WriteLine("Car Brand: " + car_obj.BrandName);
        Console.WriteLine("Year Model: " + car_obj.YearModel);
    }
}