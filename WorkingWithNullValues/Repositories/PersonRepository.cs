using System.Collections.Generic;
using WorkingWithNullValues.Extensions;
using WorkingWithNullValues.Infrastructure;
using WorkingWithNullValues.Models;
using WorkingWithNullValues.Reasons;
using WorkingWithNullValues.Types;

namespace WorkingWithNullValues.Repositories
{
  public class PersonRepository
  {
    List<Person> _persons = new List<Person>();

    public IOption<Person> TryFind(string name)
    {
      foreach (var p in _persons)
        if (p.Name == name)
          return new Some<Person>(p);

      return new None<Person>(new NotFound());
    }

    public bool IsOlderThan12(string name)
    {
      return
        TryFind(name)
          .Match(
            () => false,
            person => person.Age > 12);
    }
  }
}