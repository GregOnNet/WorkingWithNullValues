using System;

namespace OptionTypes.Extensions
{
  public static class ForOptionTypes
  {
    public static S Match<T, S>(
      this IOption<T> value,
      Func<T, S> ifSome,
      Func<S> ifNone)
    {
      if (value is Some<T>)
        return ifSome(((Some<T>)value).Value);
      return ifNone();
    }
  }
}