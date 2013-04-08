using System;

namespace WorkingWithNullValues
{
  public class Program
  {
    static void Main()
    {
      Person peter;

      if (DateTime.Now > new DateTime(2013, 1, 1))
      {
        Console.WriteLine("Happy birthday Peter");
        peter = new Person("Peter", 12);
      }

      Console.WriteLine("{0} is {1} years old", peter.Name, peter.Age);
    }
  }
}