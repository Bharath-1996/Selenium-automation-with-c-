using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniumeatest
{
    public class EaPageObject
    {
        public EaPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txttext { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]

        public IWebElement txtFirstname { get; set; }
        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtmiddlename { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement txtbtn { get; set; }

          public void Filluserform(string initial,string firstname,string middlename)
        {
            //fill the data using custome methods
            SeleniumSetMethods.EnterText(txttext, "initial");
            SeleniumSetMethods.EnterText(txtFirstname, "bharath");
            SeleniumSetMethods.EnterText(txtmiddlename, "chiluka");
            SeleniumSetMethods.Click(txtbtn);


            //txttext.SendKeys(initial);
            //txtFirstname.SendKeys(firstname);
            //txtmiddlename.SendKeys(middlename);
            //txtbtn.Click();
        }

    }
}
