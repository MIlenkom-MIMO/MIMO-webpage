using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MIMOWEB_ENG_NEW.Controllers
{
    public class ServiceController : BaseController
    {
        // GET: Service
        public ActionResult Service()
        {
            ViewBag.Message = "Services";
            ViewBag.Title = "MIMO Services";

            return View();
        }

        public ActionResult Maintenance()
        {
            ViewBag.Message = "Maintenance & Planning";
            ViewBag.Title = "MIMO Maintenance Services";

            return View();
        }

        public ActionResult Verification()
        {
            ViewBag.Message = "Verification & Testing";
            ViewBag.Title = "MIMO Verification Services";

            return View();
        }

        public ActionResult Audits()
        {
            ViewBag.Message = "Audits & Inspection";
            ViewBag.Title = "MIMO Auditing Services";

            return View();
        }

        public ActionResult Uncertainty()
        {
            ViewBag.Message = "Uncertainty Calculations";
            ViewBag.Title = "MIMO Uncertainty Solutions";

            return View();
        }

        public ActionResult Mismeasurements()
        {
            ViewBag.Message = "Mismeasurements";
            ViewBag.Title = "MIMO Mismeasurements Solutions";

            return View();
        }

        public ActionResult IT_Solutions()
        {
            ViewBag.Message = "IT Solutions";
            ViewBag.Title = "MIMO IT Solutions";

            return View();
        }
    }
}