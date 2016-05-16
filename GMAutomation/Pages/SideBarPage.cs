using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GMAutomation
{
    public class SideBarPage
    {

        public static void CickTheButtonBlogPostsAdd()
        {
            IWebElement addNewBlogPostButton = Driver.Instance.FindElement(By.ClassName("add-new"));
            addNewBlogPostButton.Click();
        }

    }
}
