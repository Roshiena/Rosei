using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Roshi.Pages;
using System.Net.Http.Headers;


   IWebDriver driver = new ChromeDriver();

// Login page object initialization and definition

LoginPage loginPageObj = new LoginPage();
loginPageObj.LoginSteps(driver);

//Home page object intialization and definition

HomePage homePageObj = new HomePage();
homePageObj.GoToTMPage(driver);

// Time and material page object initialization and definition

TMPage tmPageObj = new TMPage();
tmPageObj.CreateTM(driver);

tmPageObj.EditTM(driver);

tmPageObj.DeleteTM(driver);











