using System;
using System.Collections.Generic;

namespace WorkingWithNullValues.Extensions
{
  public static class ListExtensions
  {
     public static S Match<T,S> (
       this List<T> value,
       Func<S> ifNone, 
       Func<T,S> ifSome )
     {
       if (value.Count > 0)
         return ifSome(value[0]);
       return ifNone();
     }
  }
}