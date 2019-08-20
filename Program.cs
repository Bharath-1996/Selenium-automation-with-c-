using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniumeatest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }
        [SetUp]
        public void initilizer()
        {
            PropertiesCollection.driver = new ChromeDriver();
            //PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
        }
        [Test]
        public void Execute()
        {
            LoginPageObject loginPageObject = new LoginPageObject();
            EaPageObject eaPageObject= loginPageObject.Login("execute", "automation");

            eaPageObject.Filluserform("youtube","bharath","chiluka");
            //PropertiesCollection.driver.FindElement(By.Name("Initial")).SendKeys("automate");
            //EaPageObject pageObject = new EaPageObject();
            //pageObject.txttext.SendKeys("automate");
            //pageObject.txtbtn.Click();
        }
    }
}
