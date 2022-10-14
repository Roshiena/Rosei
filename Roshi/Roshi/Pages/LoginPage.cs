using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Roshi.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshi.Pages
{
    public class LoginPage
    {
        public void LoginSteps(IWebDriver driver)

        {
          

        driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
        driver.Manage().Window.Maximize();
        Wait.WaitToExist(driver, "ID", "UserName", 5);


        //Input username in username textbox


        IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
        usernameTextbox.SendKeys("hari");


        //Input password in password textbox


        IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
        passwordTextbox.SendKeys("123123");


       //Click Login


        IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        loginButton.Click();

        }
    }
}
