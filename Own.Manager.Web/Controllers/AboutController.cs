using System.Web.Mvc;

namespace Own.Manager.Web.Controllers
{
    public class AboutController : ManagerControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}