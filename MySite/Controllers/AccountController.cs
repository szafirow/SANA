using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySite.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
      /*  public ActionResult Index()
        {
            return View();
        }
        */

        [HttpGet]
        public ViewResult Register()
        {
            return View();
        }
    }
}