using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Platine.Models;

using Platine.Database.BusinessObject;
using Platine.Database;

namespace Platine.Controllers
{

    [SessionExpire]
    public class SkillController : Controller
    {
       
        public ActionResult Index()
        {
            Guid id = (Guid)Session["PlatineId"];

            return View(DataAccessAction.skill.GetSkillNameByUserId(id));
        }

        public ActionResult Detail(Guid id)
        {
            return View(DataAccessAction.skill.GetSkillBySkillNameId(id));
        }

        public ActionResult DeleteSkillName(Guid id)
        {
            return Redirect("/Skill");
        }
        public ActionResult DeleteSkill(Guid id)
        {
            return Redirect("/Skill");
        }
    }
}