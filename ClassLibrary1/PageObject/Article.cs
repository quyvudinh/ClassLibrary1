using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.PageObject
{
    public class Article:CommonAction
    {
        public Article(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        private IWebDriver driver;
        string status, statusfilter;
        //Article button
        public By Articlebtn = By.ClassName("icon-stack");
        //New button
        public By New = By.Id("toolbar-new");
        //Article info
        public By Title = By.Id("jform_title");
        public By Statuscbb = By.Id("jform_state_chzn");
        public By Unpublish = By.XPath("//li[contains(.,'Unpublished')]");
        public By Archive = By.XPath("//li[contains(.,'Archived')]");
        public By Publish = By.XPath("//li[contains(.,'Published')]");
        public By Categorycbb = By.XPath("//div[@id='jform_catid_chzn']//b");
        public By SampleDataArticle = By.XPath("//div[@id='jform_catid_chzn']//li[text()='Sample Data-Articles']");
        public By ParkSite = By.XPath("//div[@id='jform_catid_chzn']//li[text()='- Park Site']");
        public By Text = By.Id("tinymce");
        //Status button
        public By Edit = By.Id("toolbar-edit");
        public By Publishbtn = By.Id("toolbar-publish");
        public By Unpublishbtn = By.Id("toolbar-unpublish");
        public By Archivebtn = By.Id("toolbar-archive");
        //Filter button
        public By Filter = By.ClassName("btn hasTooltip js-stools-btn-filter");
        //Status combobox
        public By Status = By.XPath("//div[@id='filter_published_chzn']//b");
        //Status filter
        public By Archivedfilter = By.XPath("//div[@id='filter_published_chzn']//li[contains(.,'Archived')]");
        public By Publishedfilter = By.XPath("//div[@id='filter_published_chzn']//li[contains(.,'Published')]");
        public By Unpublishedfilter = By.XPath("//div[@id='filter_published_chzn']//li[contains(.,'Unpublished')]");
        //Type save
        public By Savebtn = By.ClassName("btn-success");
        public By SaveandClosebtn = By.ClassName("button-save");
        //Message
        public By MessageSuccess = By.XPath("//div[@class = 'alert alert-success']/div[@class = 'alert-message']");

       

        #region Action
        public void CheckonCreatedArticle()
        {

        }
        public void ChangeArticleStatus(By button) 
        {
            driver.FindElement(button).Click();
        }
        public void FilterArticlebyStatus(By status)
        {
            driver.FindElement(Filter).Click();
            driver.FindElement(status).Click();
        }
        public void EnterArticleInfo(string title, By category, By status)
        {
            driver.SwitchTo().Frame("jform_articletext_ifr");
            driver.FindElement(Title).Clear();
            driver.FindElement(Title).SendKeys(title);
            driver.SwitchTo().DefaultContent();
            driver.FindElement(Statuscbb).Click();
            driver.FindElement(status).Click();
            driver.FindElement(Categorycbb).Click();
            driver.FindElement(category).Click();
        }
        public void CheckArticleSaved(By message)
        {
            
        }
        #endregion
    }
}
