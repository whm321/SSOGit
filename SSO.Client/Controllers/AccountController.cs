using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SSO.Client.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        //[Authorize]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            FormsAuthentication.SetAuthCookie("123",false);
            return RedirectToAction("Index","Home");
        }

        public ActionResult Logout()
        {
            return View();
        }
    }
}