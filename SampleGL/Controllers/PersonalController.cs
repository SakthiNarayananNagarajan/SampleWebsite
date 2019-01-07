using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleGL.Controllers
{
    public class PersonalController : Controller
    {
        // GET: Personal
        public ActionResult PersonalIndex()
        {
            return View();
        }

        public ActionResult Family()
        {
            return View();
        }

    }
}