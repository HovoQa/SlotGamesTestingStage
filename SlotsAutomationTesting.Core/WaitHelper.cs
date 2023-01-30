using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SlotsAutomationTesting.Core
{
    public static class WaitHelper
    {
        public static void ShouldLocate(IWebDriver webDriver, string location)
        {
            try
            {
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(5)).Until(ExpectedConditions.UrlContains(location));
            }
            catch(WebDriverTimeoutException ex)
            {
                throw new NotFoundException($"cannot find out that app in specific location: {location}", ex);
            }
        }

        public static void WaitElement(IWebDriver webDriver,By locator,int seconds = 10)
        {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementIsVisible(locator));
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementToBeClickable(locator));
        }

    }
}