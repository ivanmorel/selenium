using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class Ebay
    {
        public Ebay()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement email { get; set; }

        [FindsBy(How = How.Name, Using = "remail")]
        public IWebElement remail { get; set; }

        [FindsBy(How = How.Name, Using = "PASSWORD")]
        public IWebElement password { get; set; }

        [FindsBy(How = How.Name, Using = "firstname")]
        public IWebElement firstName { get; set; }

        [FindsBy(How = How.Name, Using = "lastname")]
        public IWebElement lastName { get; set; }

        [FindsBy(How = How.Name, Using = "phoneFlagComp1")]
        public IWebElement phone { get; set; }

        [FindsBy(How = How.Id, Using = "sbtBtn")]
        public IWebElement btn { get; set; }

    }
}
