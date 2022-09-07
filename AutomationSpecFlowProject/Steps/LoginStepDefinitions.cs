using AutomationSpecFlowProject.Hooks;
using NUnit.Framework;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System;

namespace AutomationSpecFlowProject.Steps
{
    [Binding]
    public sealed class LoginStepDefinitions : HookInitialization
    {
        
        private readonly ScenarioContext _scenarioContext;

        public LoginStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"User Navigate to application")]
        public void GivenIOpenTheWebsite()
        {
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            var url = Driver.Url;
            Assert.AreEqual(url, "http://automationpractice.com/index.php");
        }

        [Given(@"clicking on sign In button")]
        public void GivenIClickOnSignInButton()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("login"))).Click();
        }

        [Given(@"Enter user logindetails as following :")]
        public void GivenEnterMyLogindetailsAsFollowing(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("email"))).SendKeys((string)data.UserName);
            Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("passwd"))).SendKeys((string)data.Password);
        }

        [When(@"Click on Sign in button")]
        public void WhenClickOnSignInButton()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("SubmitLogin"))).Click();
        }

        [Then(@"Verify The Welcome message")]
        public void ThenVerifyTheWelcomeMessage()
        {
            var welcome_msg = Wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("info-account"))).Text;
            Assert.AreEqual(welcome_msg, "Welcome to your account. Here you can manage all of your personal information and orders.");
        }

        [Then(@"Verify The error message")]
        public void ThenVerifyTheErrorMessage(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            var errorMessage = Wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("alert"))).Text;
            Console.WriteLine(errorMessage);
            Assert.AreEqual((string)data.message, errorMessage.Replace("\r\n", " "));
        }
    }
}
