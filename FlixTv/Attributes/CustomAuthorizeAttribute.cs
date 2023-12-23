using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Mvc;
using AuthorizeAttribute = System.Web.Mvc.AuthorizeAttribute;

namespace FlixTv.Attributes
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                filterContext.Result = new RedirectResult("~/Views/Account/Login.cshtml");
            }

            if (!filterContext.HttpContext.User.IsInRole("Premium") && !filterContext.HttpContext.User.IsInRole("FreeTrial"))
            {
                filterContext.Result = new RedirectResult("~/www/main/Pricing.html");
            }
            //else
            //{
            //    base.HandleUnauthorizedRequest(filterContext);
            //}
        }
    }
}