using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityProject.Class_Libary;
using DataBusinessLayer;
namespace UniversityProject.Controllers
{
    public class CountyController : Controller
    {
        // GET: County
        public ActionResult CountyPage()
        {
            DataBusinessClass databusinessLayer = new DataBusinessClass();
            List<County> count = databusinessLayer.count.ToList();
            
            return View(count);
        }
    }
}