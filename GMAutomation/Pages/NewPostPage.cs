using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GMAutomation.Pages
{
    public class NewPostPage
    {
        public static bool PostEditorDisplayed()
        {
            IWebElement paragraphButton = Driver.Instance.FindElement(By.Id("mceu_1-open"));
            if (paragraphButton.Displayed)
            {
                return true;
            }
            return false;
        }
    }
}
