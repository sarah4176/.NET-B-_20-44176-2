using labtask1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace labtask1.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult Index()
        {
            ViewBag.Name = "Sarah Ferdous";
            ViewBag.Email = "sarahaiub2@gmail.com";
            ViewBag.Bio = "This is Sarah, Its my last semester";

            return View();
        }
        public ActionResult Profile()
        {
            var profile = new MyProfile();
            profile.Name = "Sarah Ferdous";
            profile.Email = "sarahaiub2@gmail.com";
            profile.Dob = "14/07/2000";
            profile.Address = "Dhaka";
            profile.Contact = "019289197";
            profile.Hobbies = new string[] { "Baking", "Reading Books", "Watching series", "Listening music" };


            return View(profile);
        }
        public ActionResult Education()
        {
            InfoEducation edu1 = new InfoEducation();
            edu1.Degree = "BSc in CSE";
            edu1.Ins = "AIUB";
            edu1.Year = "Final Year";
            InfoEducation edu2 = new InfoEducation();
            edu2.Degree = "HSC";
            edu2.Ins = "BNMPC";
            edu2.Year = "2019";
            InfoEducation edu3 = new InfoEducation();
            edu3.Degree = "SSC";
            edu3.Ins = "YWCA";
            edu3.Year = "2017";
            InfoEducation[] infoEducations = new InfoEducation[] { edu1, edu2, edu3 };
            ViewBag.Edus = infoEducations;
            return View();
        }
        public ActionResult Projects()
        {
            var p1 = new MyProject();
            p1.Course = "Web Technologies";
            p1.Description = "In Web Technologies, HTML,PHP,JS,CSS are taught";
            var p2 = new MyProject();
            p2.Course = "Advanced Programming in .Net";
            p2.Description = ".NET Framework introduced here";
            var projects = new MyProject[] { p1, p2 };

           
                return View(projects);
        }
        public ActionResult References()
        {
            var r1 = new MyReferences();
            r1.Reference = "www.w3schools.com ";
            var r2 = new MyReferences();
            r1.Reference = "Class material ";
            var reference = new MyReferences[] { r1, r2 };

            return View(reference);
        }
    }
}