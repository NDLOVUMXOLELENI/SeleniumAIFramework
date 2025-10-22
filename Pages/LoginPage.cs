using OpenQA.Selenium;

namespace SeleniumAIFramework.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        // Constructor
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Locators
        private IWebElement UsernameField => _driver.FindElement(By.Id("user-name"));
        private IWebElement PasswordField => _driver.FindElement(By.Id("password"));
        private IWebElement LoginButton => _driver.FindElement(By.Id("login-button"));
        private IWebElement ErrorMessage => _driver.FindElement(By.CssSelector("h3[data-test='error']"));

        // Actions
        public void EnterUsername(string username)
        {
            UsernameField.Clear();
            UsernameField.SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            PasswordField.Clear();
            PasswordField.SendKeys(password);
        }

        public void ClickLogin()
        {
            LoginButton.Click();
        }

        public string GetErrorMessage()
        {
            try
            {
                return ErrorMessage.Text;
            }
            catch (NoSuchElementException)
            {
                return string.Empty;
            }
        }

        // Combined action for convenience
        public void LoginAs(string username, string password)
        {
            EnterUsername(username);
            EnterPassword(password);
            ClickLogin();
        }
    }
}
