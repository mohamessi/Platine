using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Platine.AleaData;
using Platine.Models;
using Platine.Exceptions;
using Platine.Database;
using Platine.Database.BusinessObject;
using System.Net.Mail;
using System.Net;
using Platine.Utils;

namespace Platine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session["PlatineId"] != null)
                return Redirect("/User");
            ViewBag.Message = "";
            return View();
        }

        public ActionResult Profil(string id)
        {
             if (id.Equals("momo"))
               return View(AleaUser.MomoUser());
            User u = DataAccessAction.user.GetUserByLogin(id);
            List<Experience> experiences = DataAccessAction.experience.GetExperienceByUserId(u.Id);
            List<Education> educations = DataAccessAction.education.GetEducationsByUserId(u.Id);
            List<ProjectModel> projects = new List<ProjectModel>();
            List<SkillModel> skills = new List<SkillModel>();

            return View(new UserProfileModel
            {
                User = u,
                Educations = educations,
                Experiences = experiences,
                Projects = projects,
                SkillModel = skills,
            });
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AddMomo()
        {
            DataAccessAction.user.Register(AleaUser.MomoUser().User);
            return Redirect("/");
        }

        public ActionResult Login(LoginModel lm)
        {
            try
            {
                ViewBag.Message = "";
                var u = DataAccessAction.user.Login(lm.Login, lm.Password);
                Session["PlatineId"] = u.Item1;
                Session["PlatineLogin"] = u.Item2;
                return Redirect("/Home/Profil/" + u.Item2);
            }
            catch (PlatineException ue)
            {
                ViewBag.Message = ue.Message;

            }
            return View("index");
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }
        public ActionResult SendRecoveryMail(ForgotPasswordModel forgotPasswordModel)
        {
            try
            {
                User u = DataAccessAction.user.GetUserByMail(forgotPasswordModel.Mail);
                String s  = PasswordGenerate.AleaPassword();
                u.Password = s;
                String address = u.Mail.Trim();
                DataAccessAction.user.UpdateUser(u);
                MailMessage email = new MailMessage();
                email.From = new System.Net.Mail.MailAddress("no-reply@platine.com");
                email.To.Add(new MailAddress(address));
                email.IsBodyHtml = true;
                email.Subject = "Platine - New Password";
                email.Body = " voici votre nouveau mot de passe : " + s;
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
                smtp.Host = "smtp.sfr.fr";
                smtp.Credentials = new System.Net.NetworkCredential("bbarrypita@yahoo.fr", "ohdrrsqq");
                smtp.Send(email);
            }
            catch (PlatineException ex)
            {
                ViewBag.Message = ex.Message;
                return View("ForgotPassword");
            }
            catch (UserException ue)
            {
                ViewBag.Message = ue.Message;
                return View("ForgotPassword");
            }
            return Redirect("/");

        }

    }
}