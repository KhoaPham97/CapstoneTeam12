using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone.Models;

namespace Capstone.Controllers
{
    public class LoginController : Controller
    {
        CapstoneEntities model = new CapstoneEntities();
        //
        // GET: /Login/
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            ViewBag.mgs = "";
            var user = model.Users.FirstOrDefault(x => x.Username== username);
      
                  return RedirectToAction("Index", "User");
        }
         

       
	}

    }

