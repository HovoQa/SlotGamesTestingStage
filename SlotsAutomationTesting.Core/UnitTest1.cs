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
using SlotsAutomationTesting.Core.PageObject;

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
            var stageLogIn = new StageLogInPageObject(_webDriver);
            stageLogIn.SignIn();
            var launchgame = new StagingMainPageObject(_webDriver);
            launchgame.Launch();
            
            
        }

        // [Test]
        //  public void LaunchGame()
        // {
        //   var launchgame = new StagingMainPageObject(_webDriver);
        //   string actualGameframeValue = launchgame.GameFrameIsVisible();
        //   Assert.AreEqual(Constance.launchId,actualGameframeValue);
        //     
        // }

        [Test]
        public void GameOpen()
        {
            var gameOpen = new GamePageObject(_webDriver);
            gameOpen.ListenGameOpen();
            var actualResult = gameOpen.GetGameId();
            

        }

        [Test]
        public void DoSpin()
        {
            
        }
        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }
    }
}