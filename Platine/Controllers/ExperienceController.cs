using Platine.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Platine.Database.BusinessObject;
using Platine.Exceptions;

namespace Platine.Controllers
{
    [SessionExpire]
    public class ExperienceController : Controller
    {
        // GET: Experience
        public ActionResult Index()
        {
            Guid id = (Guid)Session["PlatineId"];
            return View(DataAccessAction.experience.GetExperienceByUserId(id));
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult AddExperience(Experience e)
        {
            
            Guid id = (Guid)Session["PlatineId"];
            e.UserId = id;
            DataAccessAction.experience.AddExperience(e);
            return Redirect("/Experience");
        }

        public ActionResult Delete(Guid id)
        {
            try
            {
                Guid userId = (Guid)Session["PlatineId"];
                DataAccessAction.experience.DeleteExperience(id, userId);

            }
            catch (PlatineException p)
            {
                ViewBag.Message = p.Message;
                
            }
            return Redirect("/Experience");
        }

        public ActionResult Detail(Guid id)
        {
            Experience e = null;
            try
            {
                Guid userId = (Guid)Session["PlatineId"];
                e = DataAccessAction.experience.GetExperienceById(id, userId);
                Console.WriteLine("");
            }
            catch (PlatineException p)
            {

                ViewBag.Message = p.Message;
                return Redirect("/Experience");
            }
            return View(e);
        }


    }
}