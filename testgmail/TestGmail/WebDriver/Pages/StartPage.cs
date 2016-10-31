using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGmail.Pages
{
    public class StartPage
    {
        public const string BaseUrl = "https://www.google.com/gmail/about/";

        [FindsBy(How = How.XPath, Using = "//a[text()='Sign In']")]
        private IWebElement signInButton;


        private IWebDriver driver;


        public StartPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void OpenUrl()
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }

        public SignInPage OpenSignInPage()
        {
            signInButton.Click();
            return new SignInPage(driver);
        }
    }
}
