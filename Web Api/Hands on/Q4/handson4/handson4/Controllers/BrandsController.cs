using handson4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace handson4.Controllers
{
    public class BrandsController : ApiController
    {
        public HttpResponseMessage Post([FromUri] string BrandId, [FromUri] string Name)
        {
            Brand b = new Brand() { BrandId = BrandId, Name = Name };
            Brand.brands.Add(b);
            return Request.CreateResponse<Brand>(HttpStatusCode.OK, b);
        }
    }
}
