using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roshi.Utilities;


namespace Roshi.Pages
{
    public class CustomerHomePage
    {
        public void GoToCustomerPage(IWebDriver driver)
        {

            IWebElement adminDropdown1 = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminDropdown1.Click();

            IWebElement customerOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[1]/a"));
            customerOption.Click();
            Thread.Sleep(1000);
                
        }
        

       



    }
          
    
}
