using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V105.DOMDebugger;
using Roshi.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
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
            

            IWebElement goLastpage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goLastpage.Click();
            Wait.WaitToExist(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]", 5);


            IWebElement newTime = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if(newTime.Text == "September26")
            {
                Console.WriteLine("New record created successfully");
            }
            else
            {
                Console.WriteLine("Record not created");
            }
        }

        public void EditTM(IWebDriver driver)
        {
            IWebElement goLastPageButton1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goLastPageButton1.Click();
            Thread.Sleep(500);
            
            IWebElement recordCreated = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (recordCreated.Text == "September26")
            {
                IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                editButton.Click();
                Thread.Sleep(1000);
            }
            else
            {
                Assert.Fail("Record to be edited hasn't been found. Record not edited");

            }


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
            descriptionTextbox1.SendKeys("Editing test");

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

            //validate edit record

            IWebElement lastPage1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPage1.Click();
            Thread.Sleep(1000);

            IWebElement editedRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (editedRecord.Text == "October13")
            {
                Console.WriteLine("Edited record successfully");
            }
            else
            {
                Console.WriteLine("Record has not been edited");


            }

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





        