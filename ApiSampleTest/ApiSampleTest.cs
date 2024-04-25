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
                form.comboBoxNyelv = new ComboBox();

                form.comboBoxNyelv.Items.Add("Angol");
                form.comboBoxNyelv.Items.Add("Német");
                form.comboBoxNyelv.Items.Add("Spanyol");
            }

            [Test]
            [TestCase("", "100", "50", -1, false)]  // Hiányzik a név
            [TestCase("Product", "not a number", "50", 1, false)] // Az ár nem szám
            [TestCase("Product", "100", "", -1, false)]  // Hiányzik a költség
            [TestCase("Product", "100", "50", -1, false)]  // Nincs kiválasztott nyelv
            [TestCase("Product", "100", "50", 2, true)]  // Minden adat rendben
            public void ValidateNewProductData_Tests(string name, string price, string cost, int nyelvIndex, bool expectedResult)
            {
                //Arrange
                form.txtName.Text = name;
                form.txtPrice.Text = price;
                form.txtCost.Text = cost;
                form.comboBoxNyelv.SelectedIndex = nyelvIndex;

                //Act
                var result = form.ValidateNewProductData();

                //Assert
                Assert.AreEqual(expectedResult, result);
            }
        }

    }
