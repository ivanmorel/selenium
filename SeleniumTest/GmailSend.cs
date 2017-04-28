using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class GmailSend
    {
        public GmailSend()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        public const string composeXpath = "//html/body/div[7]/div[3]/div[1]/div[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div/div";
        public const string recipientXpath = "//html/body/div[14]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[4]/table/tbody/tr/td[2]/form/div[1]/table/tbody/tr[1]/td[2]/div/div/textarea";
        public const string textAreaXpath = "//html/body/div[14]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[4]/table/tbody/tr/td[2]/table/tbody/tr[1]/td/div/div[1]/div[2]/div[1]/div/table/tbody/tr/td[2]/div[2]/div";
        public const string sendBtnXpath = "//html/body/div[14]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[4]/table/tbody/tr/td[2]/table/tbody/tr[2]/td/div[1]/div[1]/div[4]/table/tbody/tr/td[1]/div/div[2]";
        public const string trashXpath = "//html/body/div[7]/div[3]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[3]/div/div";
        public const string clickEmailXpath = "//html/body/div[7]/div[3]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[7]/div[1]/div[1]/div[2]/div[1]/table/tbody/tr/td[2]/div/div";

        [FindsBy(How = How.Name, Using = "Email")]
        public IWebElement email { get; set; }

        [FindsBy(How = How.Name, Using = "signIn")]
        public IWebElement next { get; set; }

        [FindsBy(How = How.Name, Using = "Passwd")]
        public IWebElement pass { get; set; }

        [FindsBy(How = How.Id, Using = "signIn")]
        public IWebElement signIn { get; set; }

        [FindsBy(How = How.XPath, Using = GmailSend.composeXpath)]
        public IWebElement compose { get; set; }

        [FindsBy(How = How.XPath, Using = GmailSend.recipientXpath)]
        public IWebElement recipients { get; set; }

        [FindsBy(How = How.Name, Using = "subjectbox")]
        public IWebElement subject { get; set; }

        [FindsBy(How = How.XPath, Using = GmailSend.textAreaXpath)]
        public IWebElement textarea { get; set; }

        [FindsBy(How = How.XPath, Using = GmailSend.sendBtnXpath)]
        public IWebElement sendBtn { get; set; }

        [FindsBy(How = How.XPath, Using = GmailSend.clickEmailXpath)]
        public IWebElement selectEmail { get; set; }

        [FindsBy(How = How.XPath, Using = GmailSend.trashXpath)]
        public IWebElement trash { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Inbox")]
        public IWebElement inbox { get; set; }

    }
}
