using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using Roshi.Utilities;
using Roshi.Pages;
using NUnit.Framework;

namespace Roshi.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        [Given(@"\[I logged into TurnUp Portal successfully]")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
        }

        [When(@"\[I navigate to Time and Material Page]")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            TMHomePage homePageObj = new TMHomePage();
            homePageObj.GoToTMPage(driver);
        }

        [When(@"\[Create a new time and management record]")]
        public void WhenCreateANewTimeAndManagementRecord()
        {
           TMPage tmPageObj = new TMPage();
           tmPageObj.CreateTM(driver);
        }

        [Then(@"\[A new record is created successfully]")]
        public void ThenANewRecordIsCreatedSuccessfully()
        {
            TMPage tmPageObj = new TMPage();

            string newCode = tmPageObj.GetCode(driver);
            string newDescription = tmPageObj.GetDescription(driver);   
            string newPrice = tmPageObj.GetPrice(driver);

            Assert.That(newCode == "September26", "Actual code does not match Expected code");
            Assert.That(newDescription == "Deliver by next week", "Actual description does not match Expected Description");
            Assert.That(newPrice == "$15.00", "Actual Price does not match Expected Price");
        }

        [When(@"I update '([^']*)' on an existing time and management record")]
        public void WhenIUpdateOnAnExistingTimeAndManagementRecord(string description)
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTM(driver, description);

        }
            
        [Then(@"The record should have the updated '([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdated(string description)
        {
            TMPage tmPageObj = new TMPage();
            string editedDescription = tmPageObj.GetEditedDescription(driver);
            Assert.That(editedDescription == description, "Actual description does not match expected description");

        }


    }
}
