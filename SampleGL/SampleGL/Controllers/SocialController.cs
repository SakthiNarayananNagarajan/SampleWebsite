using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleGL.Controllers
{
    public class SocialController : Controller
    {
        // GET: Social
        public ActionResult SocialIndex()
        {
            return View();
        }

        public ActionResult SPI()
        {
            return View();
        }

        public ActionResult Ethel()
        {
            return View();
        }
    }
}