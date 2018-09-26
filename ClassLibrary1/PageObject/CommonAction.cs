using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CommonAction
    {
        private IWebDriver driver;
        public CommonAction(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ClickObj(By element)
        {
            driver.FindElement(element).Click();
        }
    }
}
