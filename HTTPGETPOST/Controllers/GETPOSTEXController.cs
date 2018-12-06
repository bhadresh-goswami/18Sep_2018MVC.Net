using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTTPGETPOST.Controllers
{
    public class GETPOSTEXController : Controller
    {
        // GET: GETPOSTEX
        [HttpGet]
        public ActionResult Index(int? id,string name ="", string course = null)
        {
            return View();
        }

        [HttpPost]
        [ActionName("Index")]
        public ActionResult IndexPOST(FormCollection formCollection)
        {
            return View();
        }
    }
}