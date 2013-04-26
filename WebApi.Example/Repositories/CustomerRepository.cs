using OptionTypes;
using WebApi.Example.Models;

namespace WebApi.Example.Repositories
{
  public class CustomerRepository
  {
    public static IOption<Customer> GetBy(int id)
    {
      var customer = new Customer
      {
        Name = "Greg",
        Status = "Platin"
      };

      if (id == 1)
        return new Some<Customer>(customer);
      return new None<Customer>();
    }
  }
}