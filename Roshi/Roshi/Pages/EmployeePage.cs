using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V104.Page;
using OpenQA.Selenium.DevTools.V104.Tethering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Roshi.Pages
{
    public class EmployeePage
    {
        public void CreateEmployee(IWebDriver driver)
        {
            IWebElement createButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createButton.Click();

            IWebElement nameTextBox = driver.FindElement(By.Id("Name"));
            nameTextBox.SendKeys("Roshi");

            IWebElement userName = driver.FindElement(By.Id("Username"));
            userName.SendKeys("Roro");
            Thread.Sleep(1000);

            IWebElement editContactButton = driver.FindElement(By.XPath("//*[@id=\"EditContactButton\"]"));
            editContactButton.Click();
            Thread.Sleep(1000);

            // pop up to fill details

            driver.SwitchTo().Frame(0);
           

            IWebElement firstNameBox3 = driver.FindElement(By.Id("FirstName"));
            firstNameBox3.SendKeys("Rosh");
            


            IWebElement lastNameBox3 = driver.FindElement(By.Id("LastName"));
            lastNameBox3.SendKeys("ina");

            IWebElement preferedNameBox3 = driver.FindElement(By.Id("PreferedName"));
            preferedNameBox3.SendKeys("Roshi");

            IWebElement phoneTextBox3 = driver.FindElement(By.XPath("//*[@id=\"Phone\"]"));
            phoneTextBox3.SendKeys("123456789");

            IWebElement mobileTextBox3 = driver.FindElement(By.XPath("//*[@id=\"Mobile\"]"));
            mobileTextBox3.SendKeys("987654321");

            IWebElement emailTextBox3 = driver.FindElement(By.Id("email"));
            emailTextBox3.SendKeys("emily@hotmail.com");

            IWebElement faxTextBox3 = driver.FindElement(By.XPath("//*[@id=\"Fax\"]"));
            faxTextBox3.SendKeys("5555555");

            IWebElement addressTextBox3 = driver.FindElement(By.XPath("//*[@id=\"autocomplete\"]"));
            addressTextBox3.SendKeys("18,Waterloo");

           
            IWebElement streetTextBox3 = driver.FindElement(By.Id("Street"));
            streetTextBox3.SendKeys("Raffles Street 1");

            IWebElement cityTextBox3 = driver.FindElement(By.Id("City"));
            cityTextBox3.SendKeys("Raffles");

            IWebElement pcodeTextBox3 = driver.FindElement(By.Id("Postcode"));
            pcodeTextBox3.SendKeys("345345");

            IWebElement countryTextbox3 = driver.FindElement(By.Id("Country"));
            countryTextbox3.SendKeys("Singapore");


            IWebElement saveContact = driver.FindElement(By.Id("submitButton"));
            saveContact.Click();

            driver.SwitchTo().DefaultContent();

            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("July123&&");

            IWebElement retypePassword = driver.FindElement(By.Id("RetypePassword"));
            retypePassword.SendKeys("July123&&");

            IWebElement admin = driver.FindElement(By.Id("IsAdmin"));
            admin.Click();

            IWebElement vehicleBox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            vehicleBox.SendKeys("123123");

            IWebElement groupDropDown = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
            groupDropDown.Click();

            IWebElement testOption = driver.FindElement(By.XPath("//*[@id=\"groupList_listbox\"]/li[25]"));
            testOption.Click();

            IWebElement saveButton2 = driver.FindElement(By.Id("SaveButton"));
            saveButton2.Click();

            IWebElement backList = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            backList.Click();
            Thread.Sleep(1000);

            IWebElement lastPage = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]"));
            lastPage.Click();

            IWebElement lastRecord = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(lastRecord.Text == "Roshi", "Employee Record has not been recorded");


        }

       

        public void EditEmployee(IWebDriver driver)
        {
            IWebElement lastPage5 = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]"));
            lastPage5.Click();
            Thread.Sleep(1000);

            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
            editButton.Click();

            IWebElement userName1 = driver.FindElement(By.Id("Username"));
            userName1.Clear();
            userName1.SendKeys("Rose");

            IWebElement saveButton3 = driver.FindElement(By.Id("SaveButton"));
            saveButton3.Click();

            IWebElement backList3 = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            backList3.Click();
            Thread.Sleep(1000);

            IWebElement lastPage3 = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            lastPage3.Click();

            IWebElement editedRecord = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[2]"));
            Assert.That(editedRecord.Text == "Rose", "This record has not been edited");

        }

        public void DeleteEmployee(IWebDriver driver)


        {

            IWebElement lastPage4 = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]"));
            lastPage4.Click();

            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
            deleteButton.Click();

            driver.SwitchTo().Alert().Accept();

            IWebElement deletedRecord = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(deletedRecord.Text == "Roshi", "Record has not been deleted");











        }
    }
}
