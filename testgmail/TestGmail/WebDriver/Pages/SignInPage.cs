using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGmail.Pages
{
    public class SignInPage
    {
        private WebDriverWait wait;

        private const string LoginInputId = "Email";
        private const string PasswordInputId = "Passwd";
        private const string NextButtonId = "next";
        private const string SubmitButtonId = "signIn";

        private IWebDriver driver;

        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            driver.Navigate().GoToUrl("https://accounts.google.com/AccountChooser?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&hl=en&service=mail&scc=1");
        }

        public IWebElement LoginInput
        {
            get { return driver.FindElement(By.Id(LoginInputId)); }
        }

        public IWebElement PasswordInput
        {
            get { return wait.Until(ExpectedConditions.ElementIsVisible(By.Id(PasswordInputId))); }
        }

        public IWebElement NextButton
        {
            get { return driver.FindElement(By.Id(NextButtonId)); }
        }

        public IWebElement SubmitButton
        {
            get { return wait.Until(ExpectedConditions.ElementIsVisible(By.Id(SubmitButtonId))); }
        }


        public HomePage SignIn(User user)
        {
            LoginInput.SendKeys(user.Name);
            NextButton.Click();
            PasswordInput.SendKeys(user.Password);
            SubmitButton.Click();

            return new HomePage(driver);
        }
    }
}
