using AutomationSpecFlowProject.Drivers;
using TechTalk.SpecFlow;

namespace AutomationSpecFlowProject.Hooks
{
    [Binding]
    public class HookInitialization  : SeleniumDriver
    {
        
        
        [BeforeScenario]
        public void BeforeScenario()
        {
            OneTimeSetup();         
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}
