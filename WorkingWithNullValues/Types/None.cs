using WorkingWithNullValues.Infrastructure;

namespace WorkingWithNullValues.Types
{
  public class None<T> : IOption<T>
  {
    public None(IReason reason)
    {
      Reason = reason;
    }

    public IReason Reason { get; private set; }
  }
}