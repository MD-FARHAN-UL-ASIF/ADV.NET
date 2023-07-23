using NewsPaper.EF;
using NewsPaper.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml.Linq;
using System.Data.Entity.Core.Objects;

namespace NewsPaper.Controllers
{
    public class NewsController : ApiController
    {
        [HttpGet]
        [Route("api/news/all")]
        public HttpResponseMessage All()
        {
            var db = new NPContext();
            var data = db.Newses.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/news/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var db = new NPContext();
            var data = db.Newses.Find(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

       






    /*
             [HttpGet]
            [Route("api/news/date/{date}")]
            public HttpResponseMessage Get(DateTime date)
            {
                var db = new NPContext();
                var data = db.Newses.Find(date);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            /*
                    [HttpGet]
                    [Route("api/news/{date}")]
                    public HttpResponseMessage GetByDate(DateTime date)
                    {
                        var db = new NPContext();
                        var newsByDate = db.Newses.Where(n => DbFunctions.TruncateTime(n.date) == date.Date).ToList();

                        if (newsByDate.Count == 0)
                        {
                            return Request.CreateResponse(HttpStatusCode.NotFound, "News not found for the specified date.");
                        }

                        return Request.CreateResponse(HttpStatusCode.OK, newsByDate);
                    }

            */

    [HttpPost]
        [Route("api/news/create")]
        public HttpResponseMessage Create(News n) 
        {
            var db = new NPContext();
            try
            {
                db.Newses.Add(n);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "News Created Successfully" });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/news/update")]
        public HttpResponseMessage Update(News upda)
        {
            var db = new NPContext();
            var exnews = db.Newses.Find(upda.id);
            db.Entry(exnews).CurrentValues.SetValues(upda);
            try
            {
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Updated News Successfully" });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/news/delete")]
        public HttpResponseMessage Delete(News del)
        {
            var db = new NPContext();
            var exnews = db.Newses.Find(del.id);

            try
            {
                db.Newses.Remove(exnews);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Deleted Successfully" });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [HttpGet]
        [Route("api/news/date/{date}")]
        public HttpResponseMessage GetByDate(DateTime date)
        {
            var db = new NPContext();
            var data = (from n in db.Newses
                        where EntityFunctions.TruncateTime(n.date) == EntityFunctions.TruncateTime(date)
                        select n).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }


        [HttpGet]
        [Route("api/news/c_name/{name}")]
        public HttpResponseMessage GetByCategoryName(string name)
        {
            var db = new NPContext();
            var data = (from n in db.Newses
                        where n.Category.name == name
                        select n).ToList();

            if (data.Count == 0)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "News not found for the specified category name.");
            }

            return Request.CreateResponse(HttpStatusCode.OK, data);
        }


        [HttpGet]
        [Route("api/news/{name}/{date}")]
        public HttpResponseMessage GetByCategoryNameAndDate(string name, DateTime date)
        {
            var db = new NPContext();
            var data = (from n in db.Newses
                        where n.Category.name == name && EntityFunctions.TruncateTime(n.date) == EntityFunctions.TruncateTime(date)
                        select n).ToList();

            if (data.Count == 0)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "News not found for the specified category name and date.");
            }

            return Request.CreateResponse(HttpStatusCode.OK, data);
        }


    }
}
