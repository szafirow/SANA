using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySite.Models;

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
        public ViewResult Index()
        {
            DB db = new DB();
            var kontakty = db.Kontakty;

            return View(kontakty); 
        }
    }
}