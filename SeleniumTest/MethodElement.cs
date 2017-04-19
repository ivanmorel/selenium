using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    public static class MethodElement
    {
        public static void EnterText(this IWebElement element, string text)
        {
            element.SendKeys(text);
        }

        public static void DropdownSelect(this IWebElement element, string select)
        {
            new SelectElement(element).SelectByText(select);
        }
    }
}
