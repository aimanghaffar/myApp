using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }
        public ActionResult login(login log)
        {
            if(db.validate(log.name, log.pass))
            {
                Session["login"] = log.name;
                return View("contact");
            }
            return View();
        }
        public ActionResult womens()
        {
            if(Session["login"]==null)
            {
                return Redirect("login");
            }

            return View();
        }
        public ActionResult mens()
        {
            if (Session["login"] == null)
            {
                return Redirect("login");
            }

            return View();
        }

        public ActionResult about()
        {
            if (Session["login"] == null)
            {
                return Redirect("login");
            }

            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult icons()
        {
            if (Session["login"] == null)
            {
                return Redirect("login");
            }

            return View();
        }
        public ActionResult single()
        {
            if (Session["login"] == null)
            {
                return Redirect("login");
            }

            return View();
        }
        public ActionResult typography()
        {
            if (Session["login"] == null)
            {
                return Redirect("login");
            }

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}