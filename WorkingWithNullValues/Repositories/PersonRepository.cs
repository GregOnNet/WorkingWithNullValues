﻿using System.Collections.Generic;
using WorkingWithNullValues.Extensions;
using WorkingWithNullValues.Models;

namespace WorkingWithNullValues.Repositories
{
  public class PersonRepository
  {
    List<Person> _persons = new List<Person>();

    public List<Person> TryFind(string name)
    {
      foreach (var p in _persons)
        if (p.Name == name)
          return new List<Person> { p };

      return new List<Person>();
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