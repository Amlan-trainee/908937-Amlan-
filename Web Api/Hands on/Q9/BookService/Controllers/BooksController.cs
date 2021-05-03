using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BookService.Models;

namespace BookService.Controllers
{
    public class BooksController : ApiController
    {
        /*public HttpResponseMessage Get()
        {
            using(BOOKDBContext dbContext = new BOOKDBContext())
            {
                return Request.CreateResponse(HttpStatusCode.OK, dbContext.Books.ToList());
            }
        }
        public HttpResponseMessage Get(int id)
        {
            using(BOOKDBContext dbContext = new BOOKDBContext())
            {
                var entity = dbContext.Books.FirstOrDefault(s => s.ID == id);
                if(entity != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, entity);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, $"Book with ID '{id}' not found");
                }
            }
        }*/

        public HttpResponseMessage Post([FromBody]Book book)
        {
            try
            {
                using (BOOKDBContext dbContext = new BOOKDBContext())
                {
                    dbContext.Books.Add(book);
                    dbContext.SaveChanges();
                    var message = Request.CreateResponse(HttpStatusCode.Created, book);
                    return message;
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

    }
}
