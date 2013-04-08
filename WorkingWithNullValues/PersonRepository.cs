using System.Collections.Generic;

namespace WorkingWithNullValues
{
  public class PersonRepository
  {
    List<Person> _persons = new List<Person>();

    public Person FindPerson(string name)
    {
      foreach (var person in _persons)
        if (person.Name == name)
          return person;
      

      throw new PersonNotFoundException();
    }
  }
}