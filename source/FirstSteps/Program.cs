using System;
using FirstSteps.Repositories;

namespace FirstSteps
{
  public class Program
  {
    static void Main()
    {
      var peter = "peter";
      var person = new PersonRepository();

      if (person.IsOlderThan12(peter))
        Console.WriteLine(
          "{0} is older than 12.", peter);
      Console.Read();
    }
  }
}