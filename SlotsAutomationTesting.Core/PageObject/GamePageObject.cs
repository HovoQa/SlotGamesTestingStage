using System;
using Microsoft.AspNetCore.SignalR.Client;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using SlotsAutomationTesting.Core.Responses;

namespace SlotsAutomationTesting.Core.PageObject
{
    public class GamePageObject
    {
        private IWebDriver _webDriver;
        private Actions bulder = new Actions(new FirefoxDriver());
        private HubConnection _hubConnection;


        public GamePageObject(IWebDriver webDriver)
        {
            bulder.MoveByOffset(Constance.defoultLocationY, Constance.defoultLocationX).Perform();
            _hubConnection = new HubConnectionBuilder()
                .WithUrl(Constance.hubUrl)
                .WithAutomaticReconnect()
                .Build();
            _webDriver = webDriver;
        }

        // public HubConnection HubConnect()
        // {
        //     _hubConnection = new HubConnectionBuilder()
        //     .WithUrl(Constance.hubUrl)
        //     .WithAutomaticReconnect()
        //     .Build();
        //     return _hubConnection;
        //     
        //     
        // }

        public void ListenGameOpen()
        {
            _hubConnection.On<GameOpen>("GameOpen", model =>
                GetGameId(model));
        }

        public int  GetGameId(GameOpen model)
        {
           return  model.gameId;
           
        }

        // public GamePageObject Spin()
        // {
        //     bulder.Click().Perform();
        //     return new GamePageObject(_webDriver);
        // }
        

        // public int DefoultBetAmount()
        // {
        //     
        // }

    }
}