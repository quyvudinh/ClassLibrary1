using ClassLibrary1.PageObject;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace ClassLibrary1
{
    [TestClass]
   public class Testbase
    {
    //    public IWebDriver driver;
        string title;
        public IWebDriver driver;
        Random rand = new Random();
        public Article article;
        public Homepage homepage;
        Login login;

        [TestInitialize]
        public void TestIntitialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            article = new Article(driver);
            homepage = new Homepage(driver);            
            login = new Login(driver);           

            //Testbase testbase = new Testbase(driver);
                        
            login.goToPage();
            login.login("quy", "quyquy");
        }

        [TestCleanup]
        public void TestCleanup()
        {
           driver.Quit();           
        }
        
        //public void Entertextbox(By element, string text)
        //{
            //Article article = new Article(driver);
            //driver.SwitchTo().Frame("jform_articletext_ifr");
            //driver.FindElement(element).Clear();
            //driver.FindElement(element).SendKeys(text);
            //driver.SwitchTo().DefaultContent();
        //}
    }
}
