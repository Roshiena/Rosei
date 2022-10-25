using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Roshi.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Roshi.Utilities;

namespace Roshi.Tests
{
    [TestFixture]
    public class TM_Tests : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        TMHomePage homePageObj = new TMHomePage();
        TMPage tmPageObj = new TMPage();


        [SetUp]
        public void LoginActions()
        {

            driver = new ChromeDriver();

            // Login page object initialization and definition


            loginPageObj.LoginSteps(driver);

            //Home page object intialization and definition


            homePageObj.GoToTMPage(driver);

        }
        [Test]
        public void CreateTMTest()
        {


            tmPageObj.CreateTM(driver);
            

        }

        [Test]
        public void EditTMTest()
        {

         // tmPageObj.EditTM(driver);

        }

        [Test]
        public void DelelteTMTest()
        {

            tmPageObj.DeleteTM(driver);

        }

        public void CloseTestRun()
        {
            driver.Quit();
        }

    }
}


























