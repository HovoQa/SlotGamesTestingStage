using OpenQA.Selenium;

namespace SlotsAutomationTesting.Core.PageObject
{
    public class StagingMainPageObject
    {
        private IWebDriver _webDriver;
        private static GameMode _gameMode;
        private static string _gameName;
        private readonly By _provider = By.CssSelector("button.btn-primary");
        private readonly By _providers = By.CssSelector("#provider_321");
        private readonly By _mode = By.CssSelector("#mode");
        private readonly By _modeType = By.CssSelector("Select>option[value='" + _gameMode + "']");
        private readonly By _games = By.CssSelector("#games_dropdown");
        private readonly By _game = By.CssSelector("Select>option[value='" + _gameName + "']");
        private readonly By _gameFrame = By.CssSelector("#game-frame");
        
        public StagingMainPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        
        public GamePageObject Launch(GameMode gameMode,string gameName)
        {
            _gameMode = gameMode;
            _gameName = gameName;
            _webDriver.FindElement(_provider).Click();
            WaitHelper.WaitElement(_webDriver,_providers,10);
            _webDriver.FindElement(_providers).Click();
            _webDriver.FindElement(_mode).Click();
            WaitHelper.WaitElement(_webDriver,_modeType,10);
            _webDriver.FindElement(_modeType).Click();
            _webDriver.FindElement(_games).Click();
            WaitHelper.WaitElement(_webDriver,_game,10);
            _webDriver.FindElement(_game).Click();
            return new GamePageObject(_webDriver);
        }
        public string GameFrameIsVisible()
        {
            WaitHelper.WaitElement(_webDriver,_gameFrame,10);
            string gameframe = _webDriver.FindElement(_gameFrame).Text; 
            return gameframe;
        }
    }
}