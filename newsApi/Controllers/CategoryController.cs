using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace newsApi.Controllers
{
    public class CategoryController : ApiController
    {
        [HttpGet]
       
        public HttpResponseMessage Test()
        {
            var obj = new
            {
                mag = "testing"
            };
            return Request.CreateResponse(HttpStatusCode.OK, obj);

        }
    }
}
