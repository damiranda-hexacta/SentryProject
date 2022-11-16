using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Sentry.Framework.Utils
{
    public static class DriverManager
    {
        private static IWebDriver? driver;

        public static IWebDriver Driver {
            get {
                if (driver is null)
                {
                    ChromeOptions options = new ChromeOptions();
                    options.AddArguments("incognito");
                    options.AddArguments("--start-fullscreen");
                    driver = new ChromeDriver(Path.GetFullPath(@"../../../" + "Framework/Resources/drivers"), options);
                    driver.Url = "https://storefront.dev.cpcentral.com/order";
                    //driver.Manage().Window.FullScreen();
                } return driver;
            } }
    }
}

