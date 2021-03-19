
using System;

abstract class AreaClass
{
	//This is the declaration of an Abstract class
	//Below are the abstract method.
	//Please read the theory about abstract classes
	abstract public int Area();

}

// 
class Rectangle : AreaClass
{
	int side_1 = 0;
	int side_2 = 0;

	// constructor 
	public Rectangle(int s1, int s2)
	{
		side_1 = s1;
		side_2 = s2;
	}

	// the abstract method 
	// 'Area' is overridden here 
	public override int Area()
	{
		return side_1 * side_2;
	}


    //return the size of the longest side
}

//Start a class for pentagone

class DriverCode
{

	// Main Method 
	public static void Main()
	{   
		//Instantiate some rectangles
		Rectangle rect1 = new Rectangle(11, 9);
		Console.WriteLine("Area = {0}", rect1.Area());

	}
}

