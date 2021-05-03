using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using handson4.Models;
namespace handson4.Controllers
{
    public class CoursesController : ApiController
    {
        public HttpResponseMessage Get(string courseName)
        {
            var item = Course.courses.FirstOrDefault(c => c.CourseName == courseName);
            if (item == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Course Name " + courseName + " not found.");
            }
            else
                return Request.CreateResponse<Course>(HttpStatusCode.OK, item);
        }
        public HttpResponseMessage Post(Course course)
        {
            Course.courses.Add(course);
            return Request.CreateResponse<Course>(HttpStatusCode.OK, course);
        }


        /* static List<Course> courses = new List<Course>()
         {
             new Course(){CourseId = 1, CourseName = "Android", Trainee = "Shawn", Fees = 12000,
             CourseDescription = "Android is a mobile operating system development"},

             new Course(){CourseId = 2, CourseName = "Asp.Net", Trainee = "Kevin", Fees = 10000,
             CourseDescription = "ASP .NET is a open source web development framework"},

             new Course(){CourseId = 3, CourseName = "JSP", Trainee = "Debaratha", Fees = 10000,
             CourseDescription = "Java server pages is a technology used for web page creation"},

             new Course(){CourseId = 4, CourseName = "Xamarin.forms", Trainee = "Mark John", Fees = 15000,
             CourseDescription = "Xamarin forms are cross platform UI tools"}

         };
         public HttpResponseMessage Get ([FromUri]string courseName)
         {
             var entity = courses.FirstOrDefault(s => s.CourseName == courseName);
             if (entity != null)
                 return Request.CreateResponse(HttpStatusCode.OK, entity);

             return Request.CreateResponse(HttpStatusCode.NotFound, "Course Name not found");
         }*/
    }
}
