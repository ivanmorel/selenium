using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class Get
    {
        public static string getText( string type, string element)
        {
            if (type == "id")
                return Driver.driver.FindElement(By.Id(element)).GetAttribute("value");
            if (type == "name")
                return Driver.driver.FindElement(By.Name(element)).GetAttribute("value");
            else return String.Empty;
        }
    }
}
