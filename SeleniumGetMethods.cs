using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniumeatest
{
    class SeleniumGetMethods
    {
        public static string GetText(IWebElement element)
        {
            return element.GetAttribute("value");
        }
        public static string SelectFromDropDown(IWebElement element)
        {
            return new OpenQA.Selenium.Support.UI.SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }
    }
}
