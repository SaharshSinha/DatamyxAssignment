using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business.Entities;

namespace Web.Controllers
{
    public class BaseController : Controller
    {
        protected Model dataBase = new Model();
    
        public ActionResult Exception()
        {
            return View();
        }
    }

    
}
