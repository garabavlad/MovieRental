using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRental.Models;

namespace MovieRental.Controllers
{
    public class UserController : Controller
    {
        [Route("User/myprofile/{id}")]
        public ActionResult MyProfile(int? id)
        {
            if (id != null)
                return View(new Customer{Id = (int)id,Name = "UserName"});
            else
            {
                return HttpNotFound("No given id");
            }
        }

        [Route("user/myprofile")]
        public ActionResult MyProfile()
        {
            return Redirect("myprofile/0");
        }


        [Route("user/login")]
        public ActionResult Login()
        {
            return View();
        }

        [Route("user/signup")]
        public ActionResult SignUp()
        {
            return View();
        }

    }
}