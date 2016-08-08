using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dummy.Controllers
{
    public class DummyController : Controller
    {
        // GET: Dummy Index
        public ActionResult Index()
        {
            return View();
        }
    }
}