using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMain.Controllers
{
    public class UploadController : Controller
    {
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Upload()
        {
            foreach (string file in Request.Files)
            {
                var uploadedFile = Request.Files[file];
                uploadedFile.SaveAs(Server.MapPath("~/content/pics") +
                                              Path.GetFileName(uploadedFile.FileName));
            }

            //return RedirectToAction("Upload");
            return View();
        }

        // GET: Upload
        public ActionResult Index()
        {
            return View();
        }
    }
}