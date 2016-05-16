using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;


namespace GMAutomation
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static string BaseAddress
        {

            get { return ConfigurationManager.AppSettings["EnvUrl"]; }

        }

        public static void Initialise()
        {
            DesiredCapabilities capability = DesiredCapabilities.Chrome();
            capability.SetCapability("browserstack.user", "gregmawson1");
            capability.SetCapability("browserstack.key", "ExfKsgDmyEkrQcqMfjgZ");

            capability.SetCapability("browser", "Chrome");
            capability.SetCapability("browser_version", "50.0");
            capability.SetCapability("os", "Windows");
            capability.SetCapability("os_version", "10");
            capability.SetCapability("resolution", "1024x768");


            Instance = new RemoteWebDriver(new Uri("http://hub.browserstack.com/wd/hub/"), capability);
            Instance.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(15));
        }

        public static void Close()

        {
            Instance.Quit();
        }
    }
}