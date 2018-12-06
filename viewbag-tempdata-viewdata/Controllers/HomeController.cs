using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ViwBagViewDataTempData.Models;


namespace ViwBagViewDataTempData.Controllers
{
    public class HomeController : Controller
    {
        #region ViewBag Login Example

        [HttpGet]
        public ActionResult InsertData()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InsertData(InfoModel infoModel)
        {
            if (infoModel.Password == "MTIzNA==" && infoModel.UserName == "abc")
            {
                ViewBag.message = "User Name Or Password is True!";
            }
            else
            {
                ViewBag.error = "User Name Or Password is wrong!";
            }
            return View();
        }

        #endregion

        #region ViewBag
        public ActionResult ViewBagExample()//act1
        {
            ViewBag.name = "Bhadresh";
            ViewBag.bs = 12000.00;
            ViewBag.inc = 12.20;

            TempData["ticks"] = DateTime.Now.Ticks.ToString();

            return View();
        }
        #endregion
        #region ViewData
        public ActionResult ViewDataExample()//act2
        {
            ViewData["name"] = "Bhadresh";
            ViewData["bs"] = 12000.00;
            ViewData["inc"] = 12.20;


            return View();
        }
        #endregion
    }
}