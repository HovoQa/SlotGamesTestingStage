using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SlotsAutomationTesting.Core.PageObject
{
    public class StageLogInPageObject
    {

        private readonly IWebDriver _webDriver;
        private readonly By _logIn = By.CssSelector("#logged_user_id");
        private readonly By _password = By.CssSelector("#logged_user_balance");
        private readonly By _signInBtn = By.CssSelector("#loginBtnOut");
        private readonly By _updateBalanceBtn = By.CssSelector("#_updateBalace");

        public StageLogInPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public StagingMainPageObject SignIn()
        {
            WaitHelper.WaitElement(_webDriver,_logIn,10);
            _webDriver.FindElement(_logIn).SendKeys(Constance.login);
            _webDriver.FindElement(_password).SendKeys(Constance.password);
            _webDriver.FindElement(_signInBtn).Click();
            return new StagingMainPageObject(_webDriver);
        }
        
    }
}