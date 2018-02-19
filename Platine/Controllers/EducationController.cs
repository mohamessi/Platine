using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Platine.Database.BusinessObject;
using Platine.Exceptions;
using Platine.Database;


namespace Platine.Controllers
{
    [SessionExpire]
    public class EducationController : Controller
    {
        // GET: Education
        public ActionResult Index()
        {
            Guid id = (Guid)Session["PlatineId"];
            
            return View(DataAccessAction.education.GetEducationsByUserId(id));
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Add(Education education)
        {
            Guid id = (Guid)Session["PlatineId"];
            education.UserId = id;
            DataAccessAction.education.AddEducation(education);
            return Redirect("/Education");
        }

        public ActionResult Delete(Guid id)
        {
            try
            {
                Guid userId = (Guid)Session["PlatineId"];
                DataAccessAction.education.DeleteEducation(id);
            }
            catch (PlatineException p)
            {
                ViewBag.Message = p.Message;

            }
            return Redirect("/Education");
        }

        public ActionResult Detail(Guid id)
        {
            Education e = null;
            try
            {
                Guid userId = (Guid)Session["PlatineId"];
                e = DataAccessAction.education.GetEducationById(id);
                //ViewBag.Message = "";
            }
            catch (PlatineException p)
            {

                ViewBag.Message = p.Message;
                return Redirect("/Education");
            }
            return View(e);
        }
    }
}