using System.Collections.Generic;

namespace WorkingWithNullValues
{
  public class PersonRepository
  {
    List<Person> _persons = new List<Person>();

    public Option<Person> TryFindPerson(string name)
    {
      foreach (var p in _persons)
        if (p.Name == name)
          return new Some<Person>(p);

      return new None<Person>();
    }

    public bool IsOlderThan12(string name)
    {
      return
        TryFindPerson(name)
          .Match(
            () => false,
            person => person.Age > 12);
    }
  }
}