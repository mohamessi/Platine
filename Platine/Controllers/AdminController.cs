using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Platine.Database;
using Platine.Database.BusinessObject;
namespace Platine.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View(DataAccessAction.user.GetAllUsers());
        }

        public ActionResult DeleteUser(Guid id)
        {
            DataAccessAction.user.DeleteUserById(id);
            return Redirect("/");
        }
    }
}