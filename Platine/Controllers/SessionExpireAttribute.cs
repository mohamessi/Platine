using System;
using System.Web;
using System.Web.Mvc;

namespace Platine.Controllers
{
    internal class SessionExpireAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContext ctx = HttpContext.Current;

            // check  sessions here
            if (HttpContext.Current.Session["PlatineId"] == null)
            {
                filterContext.Result = new RedirectResult("/");
                return;
            }

            base.OnActionExecuting(filterContext);
        }
    }
}