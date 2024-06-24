using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCActionResults.Controllers
{
    public class HomeController : Controller
    {
        //GET: Home
        public ViewResult Index()
        {
            return View();
        }
        //[HttpGet]
        public ViewResult Login()
        {
            return View(); 
        }
        //public string Validate(string txtUid,string txtPwd)
        [HttpPost]
        public string Login(string txtUid, string txtPwd)
        {
            if (txtUid == "admin" && txtPwd == "admin") return "Valid User";
            else return "Invalid User";
        }
        public ViewResult Register()
        {
            return View();
        }
        public ViewResult ForgotPassword()
        {
            return View("ForgotPwd");
        }
        public ViewResult Resetpassword()
        {
            return View("~/Views/Home/ResetPwd.cshtml");
        }
        public ActionResult Contact() 
        { 
            return View();
        }
        public ViewResult Mission()
        {
            return View("~/Views/Test/Mission.cshtml");
        }
        public ActionResult About()
        {
            //return View() ;
            return View("~/Views/Home/About.cshtml");
        }
        public ViewResult Show(int id)
        {
            if (id == 1) return View("Show1");
            else return View("Show2");
        }

    }
}