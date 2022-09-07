using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationSpecFlowProject.Drivers
{
    public class SeleniumDriver
    {
#pragma warning disable CS8618 
        protected IWebDriver Driver;
#pragma warning restore CS8618
#pragma warning disable CS8618
        protected WebDriverWait Wait;
#pragma warning restore CS8618

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
