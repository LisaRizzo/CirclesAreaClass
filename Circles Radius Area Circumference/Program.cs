using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circles_Radius_Area_Circumference
{
  class Program
  {
      static void Main(string[] args)
      {
        // Get the number for the radius
        Console.WriteLine("Welcome to the Circle Tester");
        CircleApp c = new CircleApp();
        c.Run();
      }
    }

  public class CircleApp
  {
    public List<Circle> Circles = new List<Circle> ();

    public void Run()
    {
      while (true)
      {
        try
        {
          Console.Write("Enter radius: ");
          double radius = double.Parse(Console.ReadLine());
          Circle c = new Circle(radius);
          Console.WriteLine("Circumference: " + c.GetCircumference());
          Console.WriteLine("Area: " + c.GetArea());
          Circles.Add(c);
        }
        catch (FormatException e)
        {
          Console.WriteLine("That input was not a number, please input a number!");
          Console.WriteLine(e.GetType());
        }
        Console.Write("Continue? (Y/N): ");
        string input = Console.ReadLine();
        input.ToLower();

        if (input == "n")
        {
          Console.Write("Goodbye! ");
          Console.WriteLine("You created {0} Circle object(s).", Circles.Count);
          Console.WriteLine("Here is their output:");
          PrintCircles();

          break;
        }
        else if (input == "y")
        {
          continue;
        } 
        else
        {
          Console.WriteLine("I'm sorry. I don't understand");
        }


      }
    }
   
    //Method calls PrintInfo() on each circle in the Circles list
    public void PrintCircles()
    {
      int total = 0;

      for (int i = 0; i < Circles.Count; i++)
      {
        total += i;

        Console.WriteLine();
        Console.WriteLine("Circle " + (i + 1));
        Circles[i].PrintInfo();
        Console.WriteLine();
      }
      
    }
  }
  public class Circle
  {
    //Instance Variables
    public double radius;

    //Constructor this
    public Circle(double radius)
    {
      this.radius = radius;
    }

    //Constructor sets the radius field
    public Circle()
    {
      radius = 0.0;
    }

    //Method sets the Circles radius
    public void SetRadius(double radius)
    {
      this.radius = radius;
    }

    //Method returns the radius of the circle
    public double GetRadius()
    {
      return radius;
    }

    //Method returns the area of the circle
    public double GetArea()
    {
      return Math.Round((Math.PI * radius * radius),2);
    }

    //Method returns the diameter of the circle
    public double GetDiameter()
    {
      return Math.Round((radius * 2),2);
    }

    //Method returns the circumference of the circle
    public double GetCircumference()
    {
      return Math.Round((2 * Math.PI * radius),2);
    }

    public void PrintInfo()
    {
      Console.WriteLine("Radius: " + GetRadius());
      Console.WriteLine("Circumference: " + GetCircumference());
      Console.WriteLine("Area: " + GetArea());
      Console.WriteLine("-------------------");
    }
  }
}
