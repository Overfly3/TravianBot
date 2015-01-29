using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using TravianBot.entities;

namespace TravianBot
{
    class Driver
    {
        public IWebDriver WebDriver
        {
            set;
            get
            {
                return getDriver();
            }
        }

        private BrowserEnum.Browser selectedBrowser;
        public Driver(BrowserEnum.Browser driver)
        {
            this.WebDriver = getDriver(driver);
            this.selectedBrowser = driver;
        }

        public Driver(IWebDriver driver)
        {
            this.WebDriver = driver;
        }
        
        private IWebDriver getDriver(BrowserEnum.Browser driver)
        {
            switch (driver)
            {
                case BrowserEnum.Browser.Firefox:
                    return new FirefoxDriver();
                case BrowserEnum.Browser.GoogleChrome:
                    return new ChromeDriver("C:\\Program Files (x86)\\Google\\Chrome\\Application");
                case BrowserEnum.Browser.InternetExplorer:
                    return new InternetExplorerDriver();
                default:
                    throw new Exception("Driver not found "+driver.ToString());
            }
        }

        private IWebDriver getDriver()
        {
            if (WebDriver.ToString().Contains("null"))
            {
                return getDriver(selectedBrowser);
            }
            else
            {
                return WebDriver;
            }
        }
    }
}
