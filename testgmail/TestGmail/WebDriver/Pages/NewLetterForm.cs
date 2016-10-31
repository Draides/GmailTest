using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGmail.Pages
{
    public class NewLetterForm
    {
        private IWebDriver driver;

        private const string InputToName = "to";
        private const string InputSubjectName = "subjectbox";
        private const string BodyInputXpath = "//div[@class='Am Al editable LW-avf']";
        private const string CheckIsSaveLetterXPath = "//span[@class='oG aOy' and text()='Сохранено']";
        private const string SaveAndCloseClassName = "Ha";

        public NewLetterForm(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement ToInput
        {
            get { return driver.FindElement(By.Name(InputToName)); }
        }

        public IWebElement SubjectInput
        {
            get { return driver.FindElement(By.Name(InputSubjectName)); }
        }
        public IWebElement BodyInput
        {
            get { return driver.FindElement(By.XPath(BodyInputXpath)); }
        }
        public IWebElement CheckIsSaveLetter
        {
            get { return driver.FindElement(By.XPath(CheckIsSaveLetterXPath)); }
        }
        public IWebElement SaveAndCloseButton
        {
            get { return driver.FindElement(By.ClassName(SaveAndCloseClassName)); }
        }

        public void CreateLetterInDraft(Message message)
        {
            ToInput.Click();
            ToInput.SendKeys(message.To);
            SubjectInput.SendKeys(message.Subject);
            BodyInput.Click();
            BodyInput.SendKeys(message.Body);
            IWebElement elem = CheckIsSaveLetter;
            SaveAndCloseButton.Click();
        }
    }
}
