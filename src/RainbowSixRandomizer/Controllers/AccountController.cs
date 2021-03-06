﻿using RainbowSixRandomizer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RainbowSixRandomizer.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Register(AccountRegisterViewModel viewModel)
        {

            // If the ModelState is valid...

            // Instantiate a User object

            // Create the user

            // If the user was successfully created...

            // Sign-in the user and redirect them to the web app's "Home" page

            // If there were errors...

            // Add model errors

            return View(viewModel);
        }

    }
}