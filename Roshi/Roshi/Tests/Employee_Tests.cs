using Roshi.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Roshi.Pages;
using OpenQA.Selenium.Chrome;

namespace Roshi.Tests
{
    [TestFixture]
    public class Employee_Tests : CommonDriver

    {
        LoginPage loginPageObj = new LoginPage();
        EmployeeHomePage empHomePageObj = new EmployeeHomePage();
        EmployeePage empPageObj = new EmployeePage();

        [SetUp]
         public void LoginActions()
        {

            driver = new ChromeDriver();

            // Login page object initialization and definition


            loginPageObj.LoginSteps(driver);

            //Home page object intialization and definition


            empHomePageObj.GoToEmployeePage(driver);

        }

        [Test]
           public void CreateEmployeeTest()

           {

            empPageObj.CreateEmployee(driver);

           }
        [Test]

           public void EditEmployeeTest()
        {

            empPageObj.EditEmployee(driver);
        }

        [Test]

          public void DeleteEmployeeTest()
        {

           empPageObj.DeleteEmployee(driver);
        }

    }
}
