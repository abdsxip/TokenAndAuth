using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using TokenAndAuth.Models;

namespace TokenAndAuth.Controllers
{
    [System.Web.Http.Authorize]
    public class EmployeeController : ApiController
    {
        // GET: Employee
        public IHttpActionResult Get()
        {
            using (EmployeeEntities emp = new EmployeeEntities())
            {
                return Ok(emp.Employees.ToList());
            }
        }
    }
}