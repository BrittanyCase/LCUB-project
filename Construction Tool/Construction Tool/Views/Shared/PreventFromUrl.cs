using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Construction_Tool.Views.Shared
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class PreventFromUrl : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
           if(filterContext.HttpContext.Request.UrlReferrer == null || 
                filterContext.HttpContext.Request.Url.Host !=
                filterContext.HttpContext.Request.UrlReferrer.Host)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(
                    new { controller = "Project", action = "Index", area = "" }));
            }
        }
    }
}