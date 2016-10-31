using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestGmail.Pages;

namespace TestGmail
{
    public class TestClass
    {
        private IWebDriver driver;

        [SetUp]
        public void TestInit()
        {
            driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }

        [TearDown]
        public void TestEnd()
        {
            driver.Dispose();
        }


        [Test]
        public void TestDraftAndSendMessage()
        {
            StartPage startPage = new StartPage(driver);
            startPage.OpenUrl();
            SignInPage signInPage = startPage.OpenSignInPage();
            /*HomePage homePage = signInPage.SignIn(Properties.user);
            NewLetterForm newLetterForm = homePage.SubmitWriteButton();
            newLetterForm.CreateLetterInDraft(Properties.message);
            homePage.SubmitDraft();

            homePage.SendLetter();
            homePage.Exit();*/
        }






       /* [Test]
        public void TestDeleteSentMessage()
        {
            StartPage startPage = new StartPage(driver);
            startPage.OpenUrl();
            SignInPage signInPage = startPage.OpenSignInPage();
            HomePage homePage = signInPage.SignIn(Properties.user);

            homePage.CheckAndDeleteLastSent();
            Thread.Sleep(3000);
        }

        [Test]
        public void TestFindingElements()
        {
            StartPage startPage = new StartPage(driver);
            startPage.OpenUrl();
            SignInPage signInPage = startPage.OpenSignInPage();
            HomePage homePage = signInPage.SignIn(Properties.user);


            IWebElement element = homePage.DraftButton;
            element = element.FindElement(By.XPath("ancestor::div[@class='aim']/preceding-sibling::div[3]"));
            // element = element.FindElement(By.XPath("ancestor::div[@class='aim']"));
            //Console.WriteLine(element.GetAttribute("class"));
            // element = element.FindElement(By.XPath("./preceding-sibling::div[2]"));
            //element = element.FindElement(By.XPath("./.."));
            element.Click();
            Thread.Sleep(4000);

        } */
    }
}
