using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationSpecFlowProject.Drivers
{
    public class SeleniumDriver
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        public void OneTimeSetup()
        {
            
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--incognito");
            chromeOptions.AddArguments("--start-maximized");
            chromeOptions.AddArguments("--headless");
            chromeOptions.AddArguments("--disable-extensions");
            driver = new ChromeDriver(chromeOptions);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

    }
}
