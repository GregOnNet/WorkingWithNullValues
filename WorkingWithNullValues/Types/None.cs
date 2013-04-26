using FirstSteps.Infrastructure;

namespace FirstSteps.Types
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