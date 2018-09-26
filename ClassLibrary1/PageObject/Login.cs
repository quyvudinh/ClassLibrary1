using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace ClassLibrary1.PageObject
{
    public class Login
    {
        private IWebDriver driver;

        public Login(IWebDriver driver)
        {
            this.driver = driver;
        }

        public By username = By.Id("mod-login-username");
        public By password = By.Id("mod-login-password");
        public By loginbutton = By.ClassName("login-button");



        public void goToPage()
        {
            driver.Navigate().GoToUrl("http://192.168.190.247/joomlatest/administrator/index.php");
        }

        public void login(string us, string pw)
        {
            driver.FindElement(username).SendKeys(us);
            driver.FindElement(password).SendKeys(pw);
            driver.FindElement(loginbutton).Click();
        }


    }
}
