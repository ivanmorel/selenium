using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class FacebookRegister
    {
        public FacebookRegister()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Name, Using = "firstname")]
        public IWebElement firstName { get; set; }

        [FindsBy(How = How.Name, Using = "lastname")]
        public IWebElement lastName { get; set; }

        [FindsBy(How = How.Id, Using = "u_0_6")]
        public IWebElement email { get; set; }

        [FindsBy(How = How.Id, Using = "u_0_9")]
        public IWebElement emailCheck { get; set; }

        [FindsBy(How = How.Id, Using = "u_0_d")]
        public IWebElement password { get; set; }

        [FindsBy(How = How.Id, Using = "day")]
        public IWebElement day { get; set; }

        [FindsBy(How = How.Id, Using = "month")]
        public IWebElement month { get; set; }

        [FindsBy(How = How.Id, Using = "year")]
        public IWebElement year { get; set; }

        [FindsBy(How = How.Id, Using = "u_0_h")]
        public IWebElement btn1 { get; set; }

        [FindsBy(How = How.Id, Using = "u_0_l")]
        public IWebElement btn2 { get; set; }

    }
}
