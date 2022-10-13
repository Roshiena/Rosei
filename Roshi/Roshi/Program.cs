// open chrome browser


using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


internal class Program
{
    private static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();




        // nagivate to TurnUp portal


        driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
        driver.Manage().Window.Maximize();


        //Input username in username textbox


        IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
        usernameTextbox.SendKeys("hari");


        //Input password in password textbox


        IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
        passwordTextbox.SendKeys("123123");






        //Click Login


        IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        loginButton.Click();


        //Homepage successfully


        IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
        if (helloHari.Text == "Hello hari!")
            Console.WriteLine("Login successfully,test passed");
        else
            Console.WriteLine("Login Unsuccessful,test failed");


        // Create Time Record


        //Navigate to Administration Page
        IWebElement adminButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
        adminButton.Click();


        IWebElement timeandMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
        timeandMaterial.Click();


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


        if
            (newTime.Text == "September26")
        {
            Console.WriteLine("New record created");
        }
        else
        {
            Console.WriteLine("New record not created");

        }

        // edit record

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




        //if(codeTextbox.Text != "September26")
        {
            //Console.WriteLine("Deleted Successfully");
            //}
            //else
            //  {
            // Console.WriteLine("Not Deleted");

            // }

            //IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            //deleteButton.Click();
            //Thread.Sleep(1000);
        }
    }
}