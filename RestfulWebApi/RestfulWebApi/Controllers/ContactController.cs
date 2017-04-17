using RestfulWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace RestfulWebApi.Controllers
{
    public class ContactController : ApiController
    {
        private const string CacheKey = "ContactStore";

        public Contact[] Get()
        {
            //@todo: add cache for restful api
            var ctx = HttpContext.Current;

            if (ctx != null)
            {
                return (Contact[])ctx.Cache[CacheKey];
            }

            return new Contact[]
                {
            new Contact
            {
                Id = 0,
                Name = "Placeholder"
            }
                };

            Contact[] c =  new Contact[]
            {
                new Contact
                {
                    Id = 1,
                    Name = "Glenn Block"
                },
                new Contact
                {
                    Id = 2,
                    Name = "Dan Roth"
                }
            };

            return c; ;
        }

        //// GET: Contact
        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}