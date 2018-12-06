using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace uploadFile.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult UploadFile()
        {
            return View();
        }

        //[HttpPost]
        //[ActionName("UploadFile")]
        //public ActionResult PostMethod()
        //{
        //    return View();
        //}


        [HttpPost]
        public ActionResult UploadFile(string name, HttpPostedFileBase fileBase)
        {
            try
            {
                //under contentn folder
                string FilePath = Server.MapPath("~/Content/Images/");
                if(!Directory.Exists(FilePath))
                {
                    Directory.CreateDirectory(FilePath);
                }
                FilePath += name;
                fileBase.SaveAs(FilePath);

                ViewBag.message = "File Saved!";
            }
            catch (Exception ex)
            {

                ViewBag.message = "Error:" + ex.Message;
                
            }
            return View();
        }


    }
}