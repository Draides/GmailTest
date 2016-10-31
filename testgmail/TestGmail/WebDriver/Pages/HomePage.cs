using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGmail.Pages
{
    public class HomePage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        private const string SubmitWriteXpath = "//div[text()='НАПИСАТЬ']";
        private const string SubmitSentXpath = "//a[@class='J-Ke n0' and contains(text(), 'Отправленные')]";
        private const string SubmitDraftXpath = "//a[@class='J-Ke n0' and contains(text(), 'Черновики')]";
        private const string LastDraftXpath = "//table[@class='F cf zt']/tbody/tr[@class='zA yO']//div[@class='yW']/font[text()='Черновик']";
        private const string SubmitSendXpath = "//div[@class='T-I J-J5-Ji aoO T-I-atl L3']";
        private const string ChekerSendLetterXpath = "//div[@class='vh' and contains(text(), 'Письмо отправлено.')]";
        private const string LastSentXpath = "//table[@class='F cf zt']/tbody/tr[@class='zA yO']//div[@class='yW'and contains(text(), 'Кому:')]";
        private const string IconProfileXpath = "//span[@class='gb_8a gbii']";
        private const string SubmitExitId = "gb_71";

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }

        public IWebElement WriteButton
        {
            get { return driver.FindElement(By.XPath(SubmitWriteXpath)); }
        }

        public IWebElement SentButton
        {
            get { return driver.FindElement(By.XPath(SubmitSentXpath)); }
        }

        public IWebElement DraftButton
        {
            get { return driver.FindElement(By.XPath(SubmitDraftXpath)); }
        }

        public IWebElement LastDraft
        {
            get { return driver.FindElement(By.XPath(LastDraftXpath)); }
        }

        public IWebElement SendButton
        {
            get { return driver.FindElement(By.XPath(SubmitSendXpath)); }
        }

        public IWebElement ChekerSendLetter
        {
            get { return driver.FindElement(By.XPath(ChekerSendLetterXpath)); }
        }

        public IWebElement IconProdile
        {
            get { return driver.FindElement(By.XPath(IconProfileXpath)); }
        }

        public IWebElement ExitButton
        {
            get { return driver.FindElement(By.Id(SubmitExitId)); }
        }

        public IWebElement LastSent
        {
            get { return driver.FindElement(By.XPath(LastSentXpath)); }
        }

        public NewLetterForm SubmitWriteButton()
        {
            WriteButton.Click();
            return new NewLetterForm(driver);
        }

        public void SubmitDraft()
        {
            DraftButton.Click();
            LastDraft.Click();
            Console.WriteLine(driver.Title);
        }

        public void SendLetter()
        {
            SendButton.Click();

            IWebElement elem = ChekerSendLetter;
        }

        public void Exit()
        {
            IconProdile.Click();
            ExitButton.Click();
        }

        public void CheckAndDeleteLastSent()
        {
            SentButton.Click();

            Actions builder = new Actions(driver);
            builder.ContextClick(LastSent).Perform();

            //LastSent.Click();
        }
    }
}
