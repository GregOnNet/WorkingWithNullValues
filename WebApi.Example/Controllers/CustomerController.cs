using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OptionTypes.Extensions;
using WebApi.Example.Repositories;

namespace WebApi.Example.Controllers
{
  public class CustomerController : ApiController
  {
    public HttpResponseMessage Get(int id)
    {
      //HttpResponseMessage response;
      return CustomerRepository.GetBy(id)
               .Match(
                 c  => Request.CreateResponse(HttpStatusCode.Found, c),
                 () => Request.CreateErrorResponse(
                         HttpStatusCode.NotFound,
                         String.Format("There is no customer having the ID '{0}'", id)));

      //if (customer == null)
      //{
      //  response = Request.CreateErrorResponse(HttpStatusCode.NotFound,
      //                                        string.Format("There is no customer having the ID '{0}'", id));
      //}
      //else
      //{
      //  response = Request.CreateResponse<Customer>(HttpStatusCode.Found, customer);
      //}

      //return response;
    }
  }
}