using OpenQA.Selenium;
using Roshi.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshi.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {

            IWebElement adminButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminButton.Click();
            Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 5);

            IWebElement timeOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeOption.Click();
        }
    }
}
