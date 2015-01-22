using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TravianBot.entities
{
    class TravianHelper
    {
        private Driver Driver;
        private String username;
        private String password;
        private TravianBot.Driver driver;
        public TravianHelper(Driver driver, String username, String password)
        {
            this.Driver = driver;
        }

        public bool loginTravian()
        {
            String old_url;
            String new_url;

            Driver.myDriver.Navigate().GoToUrl("http://ts2.travian.de/");

            Driver.myDriver.FindElement(By.Name("name")).SendKeys(username.Trim());
            Driver.myDriver.FindElement(By.Name("password")).SendKeys(password.Trim());

            old_url = Driver.myDriver.Url;
            Driver.myDriver.FindElement(By.Name("s1")).Click();

            new_url = Driver.myDriver.Url;

            return (old_url != new_url) ? true : false;
        }
    }
}
