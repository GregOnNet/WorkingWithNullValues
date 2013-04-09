using WorkingWithNullValues.Infrastructure;

namespace WorkingWithNullValues.Types
{
  public class Some<T> : IOption<T>
  {
    public T Value { get; set; }
    
    public Some( T value)
    {
      Value = value;
    }
  }
}