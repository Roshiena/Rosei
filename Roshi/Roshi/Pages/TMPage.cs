using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V105.DOMDebugger;
using Roshi.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Roshi.Pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            IWebElement createNew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNew.Click();


            IWebElement typecodeDropDown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typecodeDropDown.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"TypeCode_listbox\"]/li[2]", 5);


            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeOption.Click();




            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("September26");


            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("Deliver by next week");


            IWebElement inputTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            inputTag.Click();


            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("15");


            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(1000);


            IWebElement goLastpage1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goLastpage1.Click();
            Thread.Sleep(2000);

         // Wait.WaitToExist(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]", 5);

        }

        public string GetCode(IWebDriver driver)
        {
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return newCode.Text;
        }

        public string GetDescription(IWebDriver driver)
        {
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return newDescription.Text;
        }


        public string GetPrice(IWebDriver driver)
        {
            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));
            return newPrice.Text;
        }
        public void EditTM(IWebDriver driver , string description)
        {
            IWebElement goLastPageButton1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goLastPageButton1.Click();
            Thread.Sleep(500);
            
           IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
           editButton.Click();
           Thread.Sleep(1000);
            
           
            
            IWebElement typeCodedropdown1 = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodedropdown1.Click();
            Thread.Sleep(1000);
            

            IWebElement materialOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[1]"));
            materialOption.Click();

            IWebElement codeTextbox1 = driver.FindElement(By.Id("Code"));
            codeTextbox1.Clear();
            codeTextbox1.SendKeys("October13");

            IWebElement descriptionTextbox1 = driver.FindElement(By.Id("Description"));
            descriptionTextbox1.Clear();
            descriptionTextbox1.SendKeys(description);

            IWebElement priceInputTag1 = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceInputTag1.Click();
            IWebElement Price1 = driver.FindElement(By.Id("Price"));
            Price1.Clear();

            IWebElement priceInputTag2 = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceInputTag2.Click();
            IWebElement Price2 = driver.FindElement(By.Id("Price"));
            Price2.SendKeys("100");


            IWebElement saveButton1 = driver.FindElement(By.Id("SaveButton"));
            saveButton1.Click();
            Thread.Sleep(1000);

            IWebElement lastPage1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPage1.Click();
            Thread.Sleep(1000);

           //WebElement editedRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
           // if (editedRecord.Text == "October13")
           // {
           //     Console.WriteLine("Edited record successfully");
           // }
           // else
           // {
           //     Console.WriteLine("Record has not been edited");


           // }

            

        }

        public string GetEditedDescription(IWebDriver driver)
        {
            IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return editedDescription.Text;
        }


        public void DeleteTM(IWebDriver driver)
        {
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();
            Thread.Sleep(1000);

            //alert pop up 

            driver.SwitchTo().Alert().Accept();

            //validate deleted record

            IWebElement deletedRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (deletedRecord.Text == "October13")
            {
                Console.WriteLine("Record deleted successfully");
            }
            else
            {
                Console.WriteLine("Record deletion failed");
            }

        }
           



    }
      
    
    
       


      

}





        