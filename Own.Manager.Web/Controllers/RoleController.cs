using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Own.Manager.Web.Controllers
{
    public class RoleController : ManagerControllerBase
    {
        // GET: Role
        public ActionResult Index()
        {
            return View();
        }
    }
}