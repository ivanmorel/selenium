using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class Amazon
    {
        public Amazon()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Name, Using = "customerName")]
        public IWebElement customerName { get; set; }

        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement email { get; set; }

        [FindsBy(How = How.Name, Using = "password") ]
        public IWebElement password { get; set; }

        [FindsBy(How = How.Name, Using = "passwordCheck") ]
        public IWebElement passwordCheck { get; set; }

        [FindsBy(How = How.Id, Using = "continue") ]
        public IWebElement btncontinue { get; set; }

    }
}
