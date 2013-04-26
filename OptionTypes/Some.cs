using OptionTypes.Contracts;

namespace OptionTypes
{
  public class Some<T> : IOption<T>
  {
    public Some(T value)
    {
      Value = value;
    }

    public T Value { get; set; }
  }
}