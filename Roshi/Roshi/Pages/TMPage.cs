using OpenQA.Selenium;
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
            Thread.Sleep(1000);


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
            Thread.Sleep(2000);




            IWebElement goLastpage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goLastpage.Click();
            Thread.Sleep(2000);


            IWebElement newTime = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

        }

        public void EditTM(IWebDriver driver)

        {
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            Thread.Sleep(2000);

            IWebElement typeCodedropdown1 = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodedropdown1.Click();
            Thread.Sleep(500);
            IWebElement materialOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[1]"));
            materialOption.Click();

            IWebElement codeTextbox1 = driver.FindElement(By.Id("Code"));
            codeTextbox1.Clear();
            codeTextbox1.SendKeys("October13");

            IWebElement descriptionTextbox1 = driver.FindElement(By.Id("Description"));
            descriptionTextbox1.Clear();
            descriptionTextbox1.SendKeys("Editing test");

            IWebElement inputTag1 = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            inputTag1.Click();
            IWebElement priceTextbox1 = driver.FindElement(By.Id("Price"));
            priceTextbox1.Clear();

            IWebElement inputTag3 = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            inputTag3.Click();
            IWebElement priceTextbox3 = driver.FindElement(By.Id("Price"));
            priceTextbox3.SendKeys("100");

            IWebElement saveButton1 = driver.FindElement(By.Id("SaveButton"));
            saveButton1.Click();
            Thread.Sleep(2000);

            //validate edit record

            IWebElement lastPage1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPage1.Click();

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





        