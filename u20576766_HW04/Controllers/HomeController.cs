using u20576766_HW04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace u20576766_HW04.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Adopt()
        {
            string[] fileDirectory = Directory.GetFiles(Server.MapPath("~/Media/Adopt/"));
            List<Filemedia> files = new List<Filemedia>();
            foreach (string filePath in fileDirectory)
            {
                files.Add(new Filemedia { FileName = Path.GetFileName(filePath) });
            }
            return View(files);
        }
    }
}