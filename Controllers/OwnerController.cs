using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcWebApp.Models;

namespace mvcWebApp.Controllers
{
    public class OwnerController : Controller
    {
        //
        // GET: /Owner/
        public ActionResult Details(int id)
        {
            OwnerContext ownerContext = new OwnerContext();
            Owner owner = ownerContext.Owners.Single(own => own.id == id);

            ViewBag.Owner = owner; 
            return View();
        }
	}
}