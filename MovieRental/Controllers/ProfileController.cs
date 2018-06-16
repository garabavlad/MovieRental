using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieRental.Controllers
{
    public class ProfileController : Controller
    {
        [Route("profile/myprofile/{id}")]
        public ActionResult MyProfile(int? id)
        {
            if (id != null)
                return Content(" My profile id: " +id);
            else
            {
                return HttpNotFound();
            }
        }

    }
}