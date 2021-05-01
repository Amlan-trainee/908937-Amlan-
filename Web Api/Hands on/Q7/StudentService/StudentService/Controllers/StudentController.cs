using StudentService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentService.Controllers
{
    public class StudentController : ApiController
    {
        //public void Post([FromBody] Student student)
        //{
        //    using (StudentDBContext dBContext = new StudentDBContext())
        //    {
        //        dBContext.Students.Add(student);
        //        dBContext.SaveChanges();
        //    }
        //}

        public HttpResponseMessage Post([FromBody] Student student)
        {
            try
            {
                using (StudentDBContext dBContext = new StudentDBContext())
                {
                    dBContext.Students.Add(student);
                    dBContext.SaveChanges();
                    var message = Request.CreateResponse(HttpStatusCode.Created, student);
                    return message;
                }
            }
            catch(Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, e);
            }
        }
    }
}
