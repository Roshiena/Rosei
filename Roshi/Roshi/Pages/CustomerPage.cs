using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshi.Pages
{
    public class CustomerPage
    {
        public void CreateNewRecord(IWebDriver driver)
        {
            IWebElement createButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createButton.Click();
            Thread.Sleep(1000);

            IWebElement customerTextBox = driver.FindElement(By.Id("Name"));
            customerTextBox.SendKeys("Rosh");

            IWebElement editContact = driver.FindElement(By.XPath("//*[@id=\"EditContactButton\"]"));
            editContact.Click();

            IWebElement firstNameBox = driver.FindElement(By.Id("FirstName"));
            firstNameBox.SendKeys("Rosh");

            IWebElement lastNameBox = driver.FindElement(By.Id("LastName"));
            lastNameBox.SendKeys("ina");

            IWebElement preferedNameBox = driver.FindElement(By.Id("PreferedName"));
            preferedNameBox.SendKeys("Rosh");

            IWebElement phoneTextBox = driver.FindElement(By.XPath("//*[@id=\"Phone\"]"));
            phoneTextBox.SendKeys("123456789");

            IWebElement mobileTextBox = driver.FindElement(By.XPath("//*[@id=\"Mobile\"]"));
            mobileTextBox.SendKeys("987654321");

            IWebElement emailTextBox = driver.FindElement(By.Id("email"));
            emailTextBox.SendKeys("emily@hotmail.com");

            IWebElement faxTextBox = driver.FindElement(By.XPath("//*[@id=\"Fax\"]"));
            faxTextBox.SendKeys("5555555");

            IWebElement addressTextBox = driver.FindElement(By.XPath("//*[@id=\"autocomplete\"]"));
            addressTextBox.SendKeys("Raffles Institution");

            IWebElement streetTextBox = driver.FindElement(By.Id("Street"));
            streetTextBox.SendKeys("Raffles Street 1");

            IWebElement cityTextBox = driver.FindElement(By.Id("City"));
            cityTextBox.SendKeys("Raffles");

            IWebElement pcodeTextBox = driver.FindElement(By.Id("Postcode"));
            pcodeTextBox.SendKeys("345345");

            IWebElement countryTextbox = driver.FindElement(By.Id("Country"));
            countryTextbox.SendKeys("Singapore");

            IWebElement saveContactButton = driver.FindElement(By.Id("submitButton"));
            saveContactButton.Click();

            IWebElement sameBilling = driver.FindElement(By.Id("IsSameContact"));
            sameBilling.Click();

            IWebElement gstTextBox = driver.FindElement(By.Id("GST"));
            gstTextBox.SendKeys("15");

            IWebElement saveButton = driver.FindElement(By.Id("submitButton"));
            saveButton.Click();

            
        }

    }
}
