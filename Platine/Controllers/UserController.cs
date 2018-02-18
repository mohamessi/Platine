using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Platine.Database.BusinessObject;
using Platine.Exceptions;
using Platine.Database;
using System.Net.Mail;
using Platine.Models;
using System.Text.RegularExpressions;

namespace Platine.Controllers
{
   
    public class UserController : Controller
    {
        [SessionExpire]
        public ActionResult Index()
        {
            Guid id = (Guid)Session["PlatineId"];
            return View(DataAccessAction.user.GetUserById(id));
        }

        public ActionResult RegisterPage()
        {
            return View();
        }

        public ActionResult Register(User u)
        {
            try
            {
                DataAccessAction.user.Register(u);
            }
            catch (UserException ue)
            {
                ViewBag.Message = ue.Message;
                return View("RegisterPage");
            }
            return Redirect("/");
        }

        [SessionExpire]
        public ActionResult EditPasswordPage()
        {
            return View();
        }

        [SessionExpire]
        public ActionResult EditPassword(NewPasswordModel newPasswordModel)
        {
            Guid id = (Guid)Session["PlatineId"];
            User u = DataAccessAction.user.GetUserById(id);
            Regex r = new Regex(@"\d+");
            if (!r.IsMatch(newPasswordModel.Password))
            {
                ViewBag.Message = "The password must contains a int";
                return View("EditPasswordPage");
            }
            u.Password = newPasswordModel.Password;
            DataAccessAction.user.UpdateUser(u);
            return Redirect("/User");
        }

        public async System.Threading.Tasks.Task<ActionResult> SendMailAsync()
        {
            var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
            var message = new MailMessage();
            message.To.Add(new MailAddress("mohameddiallo93md@gmail.com")); //replace with valid value
            message.Subject = "Your email subject";
            message.Body = string.Format(body, "mohamed", "mo-2010@live.fr", "Password");
            message.IsBodyHtml = true;
            using (var smtp = new SmtpClient())
            {
                await smtp.SendMailAsync(message);
                return RedirectToAction("Sent");
            }
        }

        public ActionResult Logout()
        {
            Session["PlatineId"] = null;
            Session["PlatineLogin"] = null;
            return Redirect("/");
        }
       


    }
}