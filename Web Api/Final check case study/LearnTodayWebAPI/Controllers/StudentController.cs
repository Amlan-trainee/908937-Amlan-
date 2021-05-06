using LearnTodayWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LearnTodayWebAPI.Controllers
{
    public class StudentController : ApiController
    {
        [HttpGet]
        public IEnumerable<Course> GetAllCourses()
        {
            using (LearnTodayWebAPIDbEntities3 dbContext = new LearnTodayWebAPIDbEntities3())
            {
                return dbContext.Courses.ToList();
            }
        }
        [HttpPost]
        public HttpResponseMessage PostStudent([FromBody] Student student)
        {
            try
            {
                using (LearnTodayWebAPIDbEntities3 dbContext = new LearnTodayWebAPIDbEntities3())
                {
                    dbContext.Students.Add(student);
                    dbContext.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.Created, student);
                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpDelete]
        public HttpResponseMessage DeleteStudentEnrollement(int id)
        {
            try
            {
                using (LearnTodayWebAPIDbEntities3 dbContext = new LearnTodayWebAPIDbEntities3())
                {
                    var obj = dbContext.Students.FirstOrDefault(s => s.EnrollmentId == id);
                    if (obj == null)
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No enrollement information found");
                    dbContext.Students.Remove(obj);
                    dbContext.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
