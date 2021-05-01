using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StudentService.Models;

namespace StudentService.Controllers
{
    public class StudentsController : ApiController
    {
        public HttpResponseMessage Get()
        {
            using (StudentDBContext dbContext = new StudentDBContext())
            {
                return Request.CreateResponse(HttpStatusCode.OK, dbContext.Students.ToList());
            }
        }
        public HttpResponseMessage Get(int id)
        {
            using (StudentDBContext dbContext = new StudentDBContext())
            {
                var entity = dbContext.Students.FirstOrDefault(s => s.ID == id);
                if (entity != null)
                    return Request.CreateResponse(HttpStatusCode.OK, entity);
                return Request.CreateResponse(HttpStatusCode.NotFound, $"Student with ID {id} not found");
            }
        }
    }
}
