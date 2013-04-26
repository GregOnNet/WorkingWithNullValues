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
      return CustomerRepository.GetBy(id)
               .Match(
                 c  => Request.CreateResponse(HttpStatusCode.Found, c),
                 () => Request.CreateErrorResponse(
                         HttpStatusCode.NotFound,
                         String.Format("There is no customer having the ID '{0}'", id)));
    }
  }
}