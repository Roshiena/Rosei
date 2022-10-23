using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roshi.Utilities;


namespace Roshi.Pages
{
    public class EmployeeHomePage
    {
        public void GoToEmployeePage(IWebDriver driver)
        {
            IWebElement adminButton3 = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminButton3.Click();

            IWebElement employeeOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            employeeOption.Click(); 


        }
    } 
}
