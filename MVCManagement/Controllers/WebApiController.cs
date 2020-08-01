using Microsoft.Ajax.Utilities;
using MVCManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCManagement.Controllers
{
    [RoutePrefix("api/Management")]
    public class WebApiController : ApiController
    {
        ManagementDbContext db = new ManagementDbContext();

        [HttpGet]
        [Route("GetEmployees")]
        public List<Employee> GetEmployees()
        {
            return db.Employees.ToList();
        }
    }
}
