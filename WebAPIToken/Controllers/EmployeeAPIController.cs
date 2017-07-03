using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIToken.Models;

namespace WebAPIToken.Controllers
{
   [Authorize]
   public class EmployeeAPIController : ApiController
   {
      public List<Employee> Get()
      {
         return new EmployeeDatabase();
      }
   }

}
