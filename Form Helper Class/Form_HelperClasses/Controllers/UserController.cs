using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Form_HelperClasses.Controllers
{
    public class UserController : Controller
    {
        //by default GET Method
        //this method will execute when page load the first time
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(FormCollection formCollection)
        {
            string name = formCollection["txtUserName"].ToString();
            return View();
        }


    }
}