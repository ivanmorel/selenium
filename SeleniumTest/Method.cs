using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class Method
    {
        public static void FillText(string type, string element, string value)
        {
            if (type == "id")
                Driver.driver.FindElement(By.Id(element)).SendKeys(value);
            if (type == "name")
                Driver.driver.FindElement(By.Name(element)).SendKeys(value);
        }

        public static void Click(string type, string element)
        {
            if (type == "id")
                Driver.driver.FindElement(By.Id(element)).Click();
            if (type == "name")
                Driver.driver.FindElement(By.Name(element)).Click();
        }

        public static void SelectDropdown( string type, string element, string value)
        {
            if (type == "id")
                new SelectElement(Driver.driver.FindElement(By.Id(element))).SelectByText(value);
            if (type == "name")
                new SelectElement(Driver.driver.FindElement(By.Name(element))).SelectByText(value);
            if (type == "classname")
                new SelectElement(Driver.driver.FindElement(By.ClassName(element))).SelectByText(value);
        }

        public static void GoToUrl( string url)
        {
            Driver.driver.Navigate().GoToUrl(url);
        }
       

        public static IWebElement FindBy(string type, string element)
        {
            if (type == "id")
                return Driver.driver.FindElement(By.Id(element));
            else if (type == "name")
                return Driver.driver.FindElement(By.Name(element));
            else if (type == "class")
                return Driver.driver.FindElement(By.ClassName(element));
            else
                return Driver.driver.FindElement(By.Id(element));
        }
    }
}
