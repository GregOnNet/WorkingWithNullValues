using System;

namespace WorkingWithNullValues
{
  public static class OptionExtensions
  {
     public static S Match<T, S>(
       this Option<T> value,
       Func<S> ifNone,
       Func<T, S> ifSome)
     {
       if (value is Some<T>)
         return ifSome(((Some<T>) value).Value);
       return ifNone();
     }
  }
}