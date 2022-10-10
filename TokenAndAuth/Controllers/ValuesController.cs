using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TokenAndAuth.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public string  ValidateToken()
        {
            string result = string.Empty;
            if (User.Identity.IsAuthenticated)
            {
                result = "Token is Valid";
            }
            else
            {
                result = "Token is Invalid";
            }
            return result;
        }
    }
}
