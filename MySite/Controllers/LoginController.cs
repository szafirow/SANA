﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySite.Models;

namespace MySite.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            DB db = new DB();
            var users = db.users;
            return View(users);

        }


        public ActionResult Login()
        {
            return View();



        }


    }
}