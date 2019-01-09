using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace SampleGL.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult ContactIndex()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendEmail(string name, string phoneno, string emailid, string message)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //MailMessage mail = new MailMessage();
                    //mail.To.Add("narayanansakthi1992@gmail.com");
                    //mail.From = new MailAddress("publicsakthinarayanan@gmail.com");
                    //mail.Subject = "My website " + DateTime.Now;

                    //string Body = "Name: " + name + ";";
                    //Body += "Phone no: " + phoneno + ";";
                    //Body += "Email Id: " + emailid + ";";
                    //Body += "Message: " + message;
                    //mail.Body = Body;

                    //mail.IsBodyHtml = true;
                    //SmtpClient smtp = new SmtpClient();
                    //smtp.Host = "smtp.gmail.com";
                    //smtp.Port = 587;
                    //smtp.UseDefaultCredentials = false;
                    //smtp.Credentials = new System.Net.NetworkCredential("publicsakthinarayanan@gmail.com", "publicSakthi"); // Enter seders User name and password  
                    //smtp.EnableSsl = true;
                    //smtp.Send(mail);
                    return View("ContactIndex");
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "Some Error";
            }
            return View();
        }
    }
}