using Abp.Application.Services;
using Own.Manager.User;
using Own.Manager.User.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Own.Manager.Web.Controllers
{
    public class UserController : ManagerControllerBase
    {
        private readonly IUserAppService _userAppService;
        public UserController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List(ListPageUserInput input)
        {
            var ret = _userAppService.ListPageUsers(input);
            return Json(ret, JsonRequestBehavior.AllowGet);
        }
    }
}