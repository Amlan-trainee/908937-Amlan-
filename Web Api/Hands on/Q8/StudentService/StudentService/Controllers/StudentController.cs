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
        //public void Delete(int id)
        //{
        //    using (StudentDBContext dbContext = new StudentDBContext())
        //    {
        //        dbContext.Students.Remove(dbContext.Students.FirstOrDefault(s => s.ID == id));
        //        dbContext.SaveChanges();
        //    }
        //}
        //public HttpResponseMessage Delete(int id)
        //{
        //    using (StudentDBContext dbContext = new StudentDBContext())
        //    {
        //        var entity = dbContext.Students.FirstOrDefault(s => s.ID == id);
        //        dbContext.Students.Remove(entity);
        //        dbContext.SaveChanges();
        //        return Request.CreateResponse(HttpStatusCode.OK);
        //    }

        //}
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                using (StudentDBContext dbContext = new StudentDBContext())
                {
                    var entity = dbContext.Students.FirstOrDefault(s => s.ID == id);
                    if (entity == null)
                    {
                        return Request.CreateResponse(HttpStatusCode.NotFound, "Student with Id= " + id.ToString() + " not found to delete");
                    }
                    else
                    {
                        dbContext.Students.Remove(entity);
                        dbContext.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                    
                    
                }

            }
            catch(Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest,e);

            }
        }
    }
}
