using FirstSteps.Infrastructure;

namespace FirstSteps.Types
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