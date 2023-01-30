using OpenQA.Selenium;

namespace SlotsAutomationTesting.Core.PageObject
{
    public class GamePageObject
    {
        private IWebDriver _webDriver;

        public GamePageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        
    }
}