using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniumeatest
{
    class SeleniumSetMethods
    {
        public static void EnterText(IWebElement element,string value)
        {
            element.SendKeys(value);
        }
        public static void Click(IWebElement element)
        {
            element.Click();
        }
        public static void SelectDropdown(IWebElement element,string value)
        {
            new OpenQA.Selenium.Support.UI.SelectElement(element).SelectByText(value);
        }
    }
}
