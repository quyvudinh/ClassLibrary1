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

namespace ClassLibrary1.TestObject
{
    [TestClass]
    public class ArticleTest : Testbase
    {
        //IWebDriver driver;
        string title;
        Random rand = new Random();
        //public ArticleTest(IWebDriver driver) : base(driver)
        //{
        //    this.driver = driver;
        //}

        [TestMethod]
        public void TestCase1()
        {
            title = "Article " + rand.Next(10000);            
            article.ChangeArticleStatus(homepage.articlebtn);
            article.ChangeArticleStatus(article.New);
            article.EnterArticleInfo("Article 123", article.SampleDataArticle, article.Unpublish);
        }

        public void TestCase2()
        {

        }
    }
}
