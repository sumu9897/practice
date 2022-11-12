using System;

namespace MdSumon
{
  class Car
  {
    string color = "red";

    static void Main(string[] args)
    {
      Car myObj = new Car();
      Console.WriteLine("Car color : "+myObj.color);
    }
  }
}
