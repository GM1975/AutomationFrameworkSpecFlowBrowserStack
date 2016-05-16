using OpenQA.Selenium;


namespace GMAutomation
{
    public class LoginPage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress);

        }


        public static void LoginAs(string userName, string password)
        {

            IWebElement userNameInput = Driver.Instance.FindElement(By.Id("user_login"));
            userNameInput.SendKeys(userName);

            IWebElement passwordInput = Driver.Instance.FindElement(By.Id("user_pass"));
            passwordInput.SendKeys(password);

            IWebElement logInButton = Driver.Instance.FindElement(By.Id("wp-submit"));
            logInButton.Click();

    
        }

        
    }
}
