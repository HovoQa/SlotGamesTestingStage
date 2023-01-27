using NUnit.Framework;
using System;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SlotsAutomationTesting.Core
{
    [TestFixture]
    public class Tests
    {
        private IWebDriver _webDriver;
        
        
        [SetUp]
        public void Setup()
        {
            _webDriver = new FirefoxDriver();
            _webDriver.Manage().Window.Maximize();
            _webDriver.Navigate().GoToUrl(Constance.StageUrl);
            
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [TearDown]
        public void TearDown()
        {
        }
    }
}