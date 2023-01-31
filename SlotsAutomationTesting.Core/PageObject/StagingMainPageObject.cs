using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SlotsAutomationTesting.Core.PageObject
{
    public class StagingMainPageObject
    {
        private readonly IWebDriver _webDriver;
        private readonly By _provider = By.CssSelector("button.btn-primary");
        private readonly By _providers = By.CssSelector("#provider_321");
        private readonly By _mode = By.CssSelector("#mode>option:nth-of-type(2)");
        private readonly By _games = By.CssSelector("#games_dropdown");
        private readonly By _gameId = By.XPath( $"//li[@class='pr_games{" "}{Constance.gameId}']");
        private readonly By _gameFrame = By.CssSelector("#game-frame");
        
        public StagingMainPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        
        public GamePageObject Launch()
        {
            
            _webDriver.FindElement(_provider).Click();
            WaitHelper.WaitElement(_webDriver,_providers,10);
            _webDriver.FindElement(_providers).Click();
            _webDriver.FindElement(_mode).Click();
            _webDriver.FindElement(_games).Click();
            _webDriver.FindElement(_gameId).Click();
            return new GamePageObject(_webDriver);
        }
        public string GameFrameIsVisible()
        {
            WaitHelper.WaitElement(_webDriver,_gameFrame,20);
            string gameframe = _webDriver.FindElement(_gameFrame).Text; 
            return gameframe;
        }
    }
}