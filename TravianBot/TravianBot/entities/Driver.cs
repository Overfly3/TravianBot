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
        public IWebDriver myDriver;
        public Driver(BrowserEnum.Browser driver)
        {
            //this.myDriver = getDriver(driver);
            this.myDriver = new FirefoxDriver();
        }

        public Driver(IWebDriver driver)
        {
            this.myDriver = driver;
        }
        
        private IWebDriver getDriver(BrowserEnum.Browser driver)
        {
            switch (driver)
            {
                case BrowserEnum.Browser.Firefox:
                    return new FirefoxDriver();
                case BrowserEnum.Browser.GoogleChrome:
                    return new ChromeDriver();
                case BrowserEnum.Browser.InternetExplorer:
                    return new InternetExplorerDriver();
            }
            return new FirefoxDriver();
        }
    }
}
