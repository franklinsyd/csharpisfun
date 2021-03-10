
using System;

// This is how you declare a class
public class Car
{

    // Instance Variables 
    String color;
    String brand;
    int top_speed;


    // Constructor Declaration of Class 
    public Car(string color, String brand,
                  int top_speed)
    {
        this.color = color;
        this.brand = brand;
        this.top_speed = top_speed;

    }

    // Get the car's brand (Property)
    public String getBrand()
    {
        return brand;
    }

    // Get the car's color (Property)
    public String getColor()
    {
        return color;
    }

    // // Get a car's top_speed (Property)
    public int getTopSpeed()
    {
        return top_speed;
    }

    public void setTopSpeed(int new_top_speed)
    {
        this.top_speed = new_top_speed;
    }



    // Example of a method on properties
    public String toString()
    {

        return ("Car Brand: " + this.getBrand() + "\nColor: " + this.getColor() + "\nTop Speepd: "
                + this.getTopSpeed() + " km/h");
    }

    // Main Method  // Driver code
    public static void Main(String[] args)
    {

        // Creating object 
        Car obj_1 = new Car("Black", "Bugatti", 431);
        Console.WriteLine(obj_1.toString());

        //change the top speed using a setter method.
        obj_1.setTopSpeed(500);
        
        //Print new detatils
        Console.WriteLine(obj_1.toString());
    }
}