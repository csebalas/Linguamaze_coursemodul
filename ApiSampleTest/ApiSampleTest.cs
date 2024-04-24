using ApiSample;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiSampleTest
{
    internal class ApiSampleTest
    {
        private Form1 form = new Form1();
        [SetUp]
        public void Setup()
        {
            form.txtName = new TextBox();
            form.txtPrice = new TextBox();
            form.txtCost = new TextBox();
            form.listBoxKurzusok = new ListBox();

            // Itt inicializáljuk a listBoxKurzusok elemeket
            form.listBoxKurzusok.Items.Add("Kurzus1");
            form.listBoxKurzusok.Items.Add("Kurzus2");
            form.listBoxKurzusok.Items.Add("Kurzus3");
        }

        [Test]
        [TestCase("", "100", "50", null, false)]  // Hiányzik a név
        [TestCase("Product", "not a number", "50", "Kurzus", false)] // Az ár nem szám
        [TestCase("Product", "100", "", "Kurzus", false)]  // Hiányzik a költség
        [TestCase("Product", "100", "50", null, false)]  // Nincs kiválasztott kurzus
        [TestCase("Product", "100", "50", "Kurzus", true)]  // Minden adat rendben
        public void ValidateNewProductData_Tests(string name, string price, string cost, string kurzus, bool expectedResult)
        {
            //Arrange
            //var form = new Form1();

            //Act
            var result = form.ValidateNewProductData();

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
