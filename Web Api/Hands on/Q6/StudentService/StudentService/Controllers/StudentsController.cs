using StudentService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentService.Controllers
{
    public class StudentsController : ApiController
    {
        //public void Put(int id, [FromBody] Student student)
        //{
        //    using (StudentDBContext dBContext = new StudentDBContext())
        //    {
        //        var entity = dBContext.Students.FirstOrDefault(s => s.ID ==id);
        //        entity.FirstName = student.FirstName;
        //        entity.LastName = student.LastName;
        //        entity.Gender = student.Gender;
        //        entity.Address = student.Address;
        //        dBContext.SaveChanges();

        //    }
        //}

        //public HttpResponseMessage Put(int id, [FromBody] Student student)
        //{
        //    using (StudentDBContext dBContext = new StudentDBContext())
        //    {
        //        var entity = dBContext.Students.FirstOrDefault(s => s.ID == id);
        //        entity.FirstName = student.FirstName;
        //        entity.LastName = student.LastName;
        //        entity.Gender = student.Gender;
        //        entity.Address = student.Address;
        //        dBContext.SaveChanges();
        //        return Request.CreateResponse(HttpStatusCode.OK, entity);
        //    }
        //}
        public HttpResponseMessage Put(int id, [FromBody] Student student)
        {
            try {
                using (StudentDBContext dBContext = new StudentDBContext())
                {
                    var entity = dBContext.Students.FirstOrDefault(s => s.ID == id);
                    if (entity == null)
                    {
                        return Request.CreateResponse(HttpStatusCode.NotFound, "Student with Id" + id.ToString() + " not found to update");

                    }
                    else
                    {
                        entity.FirstName = student.FirstName;
                        entity.LastName = student.LastName;
                        entity.Gender = student.Gender;
                        entity.Address = student.Address;
                        dBContext.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, entity);
                    }
                }

               }
            catch(Exception ex) { return Request.CreateResponse(HttpStatusCode.BadRequest, ex); }
            } 
    }
}
