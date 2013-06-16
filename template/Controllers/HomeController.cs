using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OpenShift.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "This is the landing page for your ASP.NET MVC application on OpenShift.";

            return View();
        }

        public ActionResult GettingStarted()
        {
            ViewBag.Message = "This page will go through the steps of getting you up and running.";
			ViewBag.GitURL = "ssh://" + Environment.GetEnvironmentVariable ("OPENSHIFT_GEAR_UUID") + "@" +
				Environment.GetEnvironmentVariable ("OPENSHIFT_GEAR_DNS") + "/~/git/" + 
				Environment.GetEnvironmentVariable ("OPENSHIFT_GEAR_NAME") + ".git";

            return View();
        }

        public ActionResult Community()
        {
            ViewBag.Message = "Your gateway to the OpenShift Community.";

            return View();
        }
    }
}
