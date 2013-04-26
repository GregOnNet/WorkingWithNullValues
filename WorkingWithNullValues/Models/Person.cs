using System;

namespace FirstSteps.Models
{
  public class Person
  {
    public Person(string name, int age)
    {
      Name = name;
      Age = age;
    }

    public string Name { get; set; }
    public int Age { get; set; }

    public void SayHello()
    {
      Console.WriteLine("Hello this is {0}. I am {1} years old", Name, Age);
    }
  }
}
