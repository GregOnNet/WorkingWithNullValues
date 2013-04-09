namespace WorkingWithNullValues
{
  public interface Option<T> { }

  public class None<T> : Option<T> { }

  public class Some<T> : Option<T>
  {
    public T Value { get; set; }
    
    public Some( T value)
    {
      Value = value;
    }
  }
}