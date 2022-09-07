using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationSpecFlowProject.Drivers
{
    public class SeleniumDriver
    {
        protected IWebDriver? Driver;
        protected WebDriverWait? Wait;

        public void OneTimeSetup()
        {
            
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("--start-maximized");
            chromeOptions.AddArguments("--headless");
            chromeOptions.AddArguments("--disable-extensions");
            Driver = new ChromeDriver(chromeOptions);
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
        }

    }
}
