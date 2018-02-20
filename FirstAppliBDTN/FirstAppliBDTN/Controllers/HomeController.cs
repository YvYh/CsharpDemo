using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstAppliBDTN.Models;
using FirstAppliBDTN.ViewModels;

namespace FirstAppliBDTN.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult VoirEtudiant()
        {
            DateTime dt = new DateTime();
            Etudiant e = null;
            if (DateTime.TryParse("10/10/1970 05:20:00", out dt))
                e = new Etudiant { NumInsee = 1, Nom = "Dupont", Prenom = "Daniel", DateNaiss = dt };
            //ViewData["Etudiant"] = e;
            //dynamic et = new Etudiant(2, "Guérin", "Gilles", dt);
            //ViewBag["Etudiant"] = et;
            VoirEtudiantVM vm = new VoirEtudiantVM
            {
                Etudiant = e
            };
            return View(vm);
        }
    }
}