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

    public bool TryFindPerson(string name, out Person person)
    {
      person = null;
      foreach (var p in _persons)
        if (p.Name == name)
        {
          person = p;
          return true;
        }

      return false;
    }
  }
}