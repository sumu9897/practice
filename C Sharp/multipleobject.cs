using System;

namespace MdSumon
{
  class Car 
  {
    string model;
    string color;
    int year;

    static void Main(string[] args)
    {
      Car Ford = new Car();
      Ford.model = "Mustang";
      Ford.color = "red";
      Ford.year = 1969;

      Car Opel = new Car();
      Opel.model = "Astra";
      Opel.color = "white";
      Opel.year = 2005;

      Console.WriteLine("Ford car model : "+Ford.model);
      
      Console.WriteLine("Ford car color : "+Ford.color);
      
      Console.WriteLine("Opel car model : "+Opel.model);
      
      Console.WriteLine("Opel car color : "+Opel.color);
    }
  }
}
