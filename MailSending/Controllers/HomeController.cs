using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using MailSending.Models;

namespace MailSending.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public void SendMessage(UserDetails objData)
        {
            MailMessage msg = new MailMessage("hogriders8055@gmail.com", "hogrider8055@gmail.com");

            msg.Subject = objData.Subject;
            msg.Body = objData.BodyMessage;

            SmtpClient smpt = new SmtpClient("smtp.gmail.com",587);
            smpt.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "hogriders8055@gmail.com",
                Password = "srikanth@1234"
            };
            smpt.EnableSsl = true;
            smpt.Send(msg);
        }
    }
}