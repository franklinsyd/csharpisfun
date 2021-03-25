using System;

// declare class 'AreaClass' 
abstract class AreaClass
{
	// declare method 
	// 'Area' as abstract 
	abstract public int Area();
	abstract public float AreaNSides(); // Pentagone

	abstract public bool checkSides();
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

    public override float AreaNSides()
    {
        throw new NotImplementedException(); // Exceptions
	}

	public void checkIfSquare()
    {
		if(side_1 == side_2)
        {
			Console.WriteLine("This is square");
		}
		else
        {
			Console.WriteLine("This is NOT square");
		}
    }

	public int getTheLongestSide()
    {
		if (side_1 > side_2)
            return side_1;
		else
			return side_2;

	}

	public int getTheShortestSide()
	{
		if (side_1 < side_2)
			return side_1;
		else
			return side_2;

	}

	public override bool checkSides()
    {
        throw new NotImplementedException();
    }


    //return the size of the longest side
}

//Start a class for pentagone

class Pentagone : AreaClass
{
	float side = 0;

	//Constructor
	public Pentagone(float s)
    {
		side = s;
    }

    public override int Area()
    {
        throw new NotImplementedException();
    }

    public override float AreaNSides()
    {
		float pent_area; // var that will hold the pentagone area
		pent_area = (float)(Math.Sqrt(5 * (5 + 2 * (Math.Sqrt(5)))) * side * side)/ 4;
		return pent_area;
	}
	public override bool checkSides()
	{
		throw new NotImplementedException();
	}

}


class DriverCode
{

	// Main Method 
	public static void Main()
	{
		//Instantiate some rectangles
		Rectangle rect1 = new Rectangle(76, 100);
		Console.WriteLine("Area of the retangle = {0}", rect1.Area());
		Console.WriteLine("The longest side of the retangle = {0} and the shortest = {1}",
			    rect1.getTheLongestSide(), rect1.getTheShortestSide());
		rect1.checkIfSquare();

		Instantiate some pentagones
		Pentagone pent1 = new Pentagone(334);
		Console.WriteLine("Area of the pentagone = {0}", pent1.AreaNSides());



	}
}
