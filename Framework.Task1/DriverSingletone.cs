using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Collections.Specialized;

namespace Framework.Task1
{
    public class DriverSingletone
    {
        private static IWebDriver? driver;

        private DriverSingletone()
        {
        }

        public static IWebDriver GetDriver(string driverName)
        {
            if (driver is null)
            {
                driver = driverName.ToLower() switch
                {
                    "firefox" => new FirefoxDriver(),
                    _ => new ChromeDriver(),
                };

                driver.Manage().Window.Maximize();
            }

            return driver;
        }

        public static void CloseDriver()
        {
            driver?.Quit();
            driver = null;
        }
    }
}
