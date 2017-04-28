using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class Youtube
    {
        public Youtube()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        public const string signInXpath = "//*[@id='yt-masthead-signin']/div/button";
        public const string subscribeXpath = "//*[@id='c4-primary-header-contents']/div/div/div[2]/div/span/button";
        public const string unsubscribeXpath = "//*[@id='body-container']/div[5]/div/div/div[1]/div[2]/div/div[2]/button[2]";

        [FindsBy(How = How.XPath, Using = Youtube.signInXpath)]
        public IWebElement signIn { get; set; }

        [FindsBy(How = How.Name, Using = "Email")]
        public IWebElement email { get; set; }

        [FindsBy(How = How.Name, Using = "signIn")]
        public IWebElement next { get; set; }

        [FindsBy(How = How.Name, Using = "Passwd")]
        public IWebElement pass { get; set; }

        [FindsBy(How = How.Id, Using = "signIn")]
        public IWebElement signIn2 { get; set; }

        [FindsBy(How = How.Id, Using = "masthead-search-term")]
        public IWebElement searchBar { get; set; }

        [FindsBy(How = How.LinkText, Using = "Music")]
        public IWebElement musicLink { get; set; }

        [FindsBy(How = How.XPath, Using = Youtube.subscribeXpath)]
        public IWebElement subscribe { get; set; }

        [FindsBy(How = How.XPath, Using = Youtube.unsubscribeXpath)]
        public IWebElement unsubscribe { get; set; }
    }
}
