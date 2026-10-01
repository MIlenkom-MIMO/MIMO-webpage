using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MIMOWEB_ENG_NEW.Models;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Web.UI.HtmlControls;
using System.Text;
using System.Net.Configuration;
using System.IO;
using System.Configuration;

namespace MIMOWEB_ENG_NEW.Controllers
{
    public class BaseController : Controller
    {
    }

    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Measurement Solutions for Oil & Gas Industry";
            ViewBag.Title = "Measurement Solutions for Oil & Gas Industry";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Measurement Solutions for Oil & Gas Industry";
            ViewBag.Title = "Measurement Solutions for Oil & Gas Industry";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact us";
            ViewBag.Title = "Contact us";

            FormDetails model = new FormDetails();

            return View(model);
        }

        public ActionResult ThankYou()
        {
            ViewBag.Title = "Contact us";
            ViewBag.Message = "Contact us";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contact(FormDetails Frm)
        {
            ViewBag.Message = "Contact us";
            ViewBag.Title = "Contact us";

            if (ModelState.IsValid)
            {
                int RecordAdded = ClassLib.BussinessLogic.Business.FormProcessor(
                    Frm.Name,
                    Frm.Surname,
                    Frm.Title,
                    Frm.Company,
                    Frm.Mail,
                    Frm.Telephone,
                    Frm.Subject,
                    Frm.Message
                );

                if (string.IsNullOrEmpty(Frm.Title))
                {
                    Frm.Title = "Not provided";
                }

                if (string.IsNullOrEmpty(Frm.Company))
                {
                    Frm.Company = "Not provided";
                }

                string body = string.Empty;

                using (StreamReader reader =
                    new StreamReader(Server.MapPath("~/Templates/EmailBody.html")))
                {
                    body = reader.ReadToEnd();
                }

                body = body.Replace("{name}", Frm.Name);
                body = body.Replace("{surname}", Frm.Surname);
                body = body.Replace("{title}", Frm.Title);
                body = body.Replace("{company}", Frm.Company);
                body = body.Replace("{e-mail}", Frm.Mail);
                body = body.Replace("{telephone}", Frm.Telephone);
                body = body.Replace("{subject}", Frm.Subject);
                body = body.Replace("{comment}", Frm.Message);

                SmtpSection smtpSection =
                    (SmtpSection)ConfigurationManager.GetSection(
                        "system.net/mailSettings/smtp"
                    );

                using (MailMessage mm =
                    new MailMessage(smtpSection.From, "info@mimo-ms.com"))
                {
                    mm.Subject = Frm.Subject;
                    mm.Body = body;
                    mm.IsBodyHtml = true;

                    SmtpClient smtp = new SmtpClient();

                    smtp.Host = smtpSection.Network.Host;
                    smtp.EnableSsl = smtpSection.Network.EnableSsl;

                    NetworkCredential networkCred =
                        new NetworkCredential(
                            smtpSection.Network.UserName,
                            smtpSection.Network.Password
                        );

                    smtp.UseDefaultCredentials =
                        smtpSection.Network.DefaultCredentials;

                    smtp.Credentials = networkCred;
                    smtp.Port = smtpSection.Network.Port;

                    smtp.Send(mm);
                }

                return RedirectToAction("ThankYou");
            }

            return View(Frm);
        }

        public ActionResult Calculations()
        {
            ViewBag.Message = "Metering Calculations";
            ViewBag.Title = "Metering Calculation Templates";

            return View();
        }

        public ActionResult Vacancies()
        {
            ViewBag.Message = "MIMO Vacancies";
            ViewBag.Title = "MIMO Vacancies";

            return View();
        }

        public ActionResult Projects()
        {
            ViewBag.Message = "Completed Projects";
            ViewBag.Title = "MIMO Completed Projects";

            return View();
        }
    }
}