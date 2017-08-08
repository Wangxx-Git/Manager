using System.Web.Mvc;

namespace Own.Manager.Web.Controllers
{
    public class HomeController : ManagerControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index_abp()
        {
            return View();
        }
    }
}