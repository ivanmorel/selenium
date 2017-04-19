using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class FacebookLogin
    {
        public FacebookLogin()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement email { get; set; }

        [FindsBy(How = How.Name, Using = "pass")]
        public IWebElement pass { get; set; }

        [FindsBy(How = How.Id, Using = "loginbutton")]
        public IWebElement btnlogin { get; set; }

    }
}
