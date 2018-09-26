using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.PageObject
{
    public class Homepage
    {
        private IWebDriver driver;
        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public By articlebtn = By.ClassName("icon-stack");

        public void NavigateToArticle()
        {
            driver.FindElement(articlebtn).Click();
        }
    }
}
