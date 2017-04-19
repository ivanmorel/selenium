using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class Google
    {
        public Google()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement firstName { get; set; }

        [FindsBy(How = How.Name, Using = "LastName")]
        public IWebElement lastName { get; set; }

        [FindsBy(How = How.Name, Using = "GmailAddress")]
        public IWebElement gmailAddr { get; set; }

        [FindsBy(How = How.Name, Using = "Passwd")]
        public IWebElement pass { get; set; }

        [FindsBy(How = How.Name, Using = "PasswdAgain")]
        public IWebElement passCheck { get; set; }

        [FindsBy(How = How.Id, Using = "BirthMonth")]
        public IWebElement month { get; set; }

        [FindsBy(How = How.Id, Using = ":7")]
        public IWebElement monthdrop { get; set; }

        [FindsBy(How = How.Name, Using = "BirthDay")]
        public IWebElement birthDay { get; set; }

        [FindsBy(How = How.Name, Using = "BirthYear")]
        public IWebElement birthYear { get; set; }

        [FindsBy(How = How.Id, Using = "Gender")]
        public IWebElement gender { get; set; }

        [FindsBy(How = How.Id, Using = ":f")]
        public IWebElement male { get; set; }

        [FindsBy(How = How.Name, Using = "RecoveryPhoneNumber")]
        public IWebElement phoneRec { get; set; }

        [FindsBy(How = How.Name, Using = "RecoveryEmailAddress")]
        public IWebElement emailRec { get; set; }

    }
}
