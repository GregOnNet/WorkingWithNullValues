using System;
using WorkingWithNullValues.Infrastructure;
using WorkingWithNullValues.Types;

namespace WorkingWithNullValues.Extensions
{
  public static class OptionExtensions
  {
     public static S Match<T, S>(
       this IOption<T> value,
       Func<S> ifNone,
       Func<T, S> ifSome)
     {
       if (value is Some<T>)
         return ifSome(((Some<T>) value).Value);
       return ifNone();
     }
  }
}