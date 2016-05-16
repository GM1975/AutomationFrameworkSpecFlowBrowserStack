using OpenQA.Selenium;


namespace GMAutomation.Pages
{
    public class TopBarPage
    {
        public static void ClickMySite()
        {
            IWebElement mySiteButton = Driver.Instance.FindElement(By.ClassName("masterbar__item-content"));
            mySiteButton.Click();
        }

    }
}
