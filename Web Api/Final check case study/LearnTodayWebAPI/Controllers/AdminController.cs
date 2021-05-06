using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LearnTodayWebAPI.Models;

namespace LearnTodayWebAPI.Controllers
{
    public class AdminController : ApiController
    {
        [HttpGet]
        public IEnumerable<Course> GetAllCourses()
        {
            using (LearnTodayWebAPIDbEntities3 dbContext = new LearnTodayWebAPIDbEntities3())
            {
                return dbContext.Courses.ToList();
            }
        }
        [HttpGet]
        public HttpResponseMessage GetCouseById(int id)
        {
            using (LearnTodayWebAPIDbEntities3 dbContext = new LearnTodayWebAPIDbEntities3())
            {
                var obj = dbContext.Courses.FirstOrDefault(s => s.CourseId == id);
                if (obj == null)
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Searched Data not Found");
                return Request.CreateResponse(HttpStatusCode.OK, obj);

            }
        }
    }
}
