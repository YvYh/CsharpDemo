using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstAppliBDTN.Models;
using FirstAppliBDTN.Controllers;

namespace FirstAppliBDTN.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void EtudiantTest()
        {
            // Arrange
            DateTime dt = new DateTime();

            //Act
            DateTime.TryParse("16/02/2017", out dt);
            Etudiant e = new Etudiant { NumInsee = 1, Nom = "Gravé", Prenom = "Samuel", DateNaiss = dt };

            //Assert
            Assert.AreEqual(1, e.NumInsee);
        }
    }
}
