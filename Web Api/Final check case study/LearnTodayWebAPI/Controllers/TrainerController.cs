using LearnTodayWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LearnTodayWebAPI.Controllers
{
    public class TrainerController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage TrainerSignUp([FromBody] Trainer trainer)
        {
            try
            {
                using (LearnTodayWebAPIDbEntities3 dbContext = new LearnTodayWebAPIDbEntities3())
                {
                    dbContext.Trainers.Add(trainer);
                    dbContext.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.Created, trainer);
                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpPut]
        public HttpResponseMessage UpdatePassword(int id,[FromBody] Trainer trainer)
        {
            using (LearnTodayWebAPIDbEntities3 dbContext = new LearnTodayWebAPIDbEntities3())
            {
                try
                {
                    var obj = dbContext.Trainers.FirstOrDefault(s => s.TrainerId == id);
                    if (obj == null)
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Searched Data not Found");
                    obj.Password = trainer.Password;
                    dbContext.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, "Data Updated successfully");
                }
                catch(Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
                }
            }

        }
    }
}
