using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class FacebookPublish
    {
        public FacebookPublish()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        public const string loginXpath = "//html/body/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/form/table/tbody/tr[2]/td[3]/label/input";
        public const string publishXpath = "//html/body/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[1]/div[3]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/form/div[1]/div[1]/div[2]/textarea";
        public const string btnPublishXpath = "//html/body/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[1]/div[3]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[3]/div[1]/div[2]/div[1]/button";
        public const string optionsXpath = "//html/body/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[1]/div[5]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/a";
        public const string eliminarXpath = "//html/body/div[1]/div[2]/div[3]/div[1]/div[1]/div[1]/ul/li[1]/a";
        public const string eliminarPublishXpath = "//html/body/div[16]/div[2]/div[1]/div[1]/form/div[3]/button";

        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement email { get; set; }

        [FindsBy(How = How.Name, Using = "pass")]
        public IWebElement pass { get; set; }

        [FindsBy(How = How.XPath, Using = loginXpath)]
        public IWebElement loginBtn { get; set; }

        [FindsBy(How = How.Id, Using = "q")]
        public IWebElement search { get; set; }

        [FindsBy(How = How.XPath, Using = FacebookPublish.publishXpath)]
        public IWebElement publish { get; set; }

        [FindsBy(How = How.XPath, Using = FacebookPublish.btnPublishXpath)]
        public IWebElement btnPublish { get; set; }

        [FindsBy(How = How.XPath, Using = FacebookPublish.optionsXpath)]
        public IWebElement options { get; set; }

        [FindsBy(How = How.XPath, Using = FacebookPublish.eliminarXpath)]
        public IWebElement eliminar { get; set; }

        [FindsBy(How = How.XPath, Using = FacebookPublish.eliminarPublishXpath)]
        public IWebElement eliminarPublish { get; set; }
    }
}
