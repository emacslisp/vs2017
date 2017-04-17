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
        public Contact[] Get()
        {
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