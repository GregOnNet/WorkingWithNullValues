using System;

namespace WorkingWithNullValues
{
  public class Program
  {
    static void Main()
    {
      var person = new PersonRepository();

      if (person.IsOlderThan12("peter"))
        Console.WriteLine("He is older than 12.");
    }
  }
}