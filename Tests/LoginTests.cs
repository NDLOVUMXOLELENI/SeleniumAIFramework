using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumAIFramework.Pages;
using NUnit.Allure.Core;
using Allure.NUnit;
using Allure.Commons;

namespace SeleniumAIFramework.Tests
{
    [TestFixture]
    [Allure.NUnit.AllureNUnitAttribute] // basic Allure reporting
    public class LoginTests
    {
        private IWebDriver? _driver;
        private LoginPage? _loginPage;

        [SetUp]
        public void SetUp()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            _driver = new ChromeDriver(options);
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            _loginPage = new LoginPage(_driver);
        }

        [TearDown]
        public void TearDown()
        {
            _driver?.Quit();
        }

        [Test]
        public void Login_WithValidCredentials_ShouldSucceed()
        {
            _loginPage!.LoginAs("standard_user", "secret_sauce");
            Assert.That(_driver!.Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
        }

        [Test]
        public void Login_WithInvalidCredentials_ShouldShowError()
        {
            _loginPage!.LoginAs("wrong_user", "wrong_password");
            string error = _loginPage!.GetErrorMessage();
            Assert.That(error.Contains("Epic sadface"), Is.True);
        }

        [Test]
        public void Login_WithBlankUsername_ShouldShowError()
        {
            _loginPage!.LoginAs("", "secret_sauce");
            string error = _loginPage!.GetErrorMessage();
            Assert.That(error.Contains("Username is required"), Is.True);
        }

        [Test]
        public void Login_WithBlankPassword_ShouldShowError()
        {
            _loginPage!.LoginAs("standard_user", "");
            string error = _loginPage!.GetErrorMessage();
            Assert.That(error.Contains("Password is required"), Is.True);
        }
    }
}
