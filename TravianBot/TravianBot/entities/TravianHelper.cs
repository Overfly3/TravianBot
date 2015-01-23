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
        private String myUserName;
        private String myPassword;
        private TravianBot.Driver driver;
        public TravianHelper(Driver driver, String username, String password)
        {
            myUserName = username;
            myPassword = password;
            this.Driver = driver;
        }

        public bool loginTravian()
        {
            String old_url;
            String new_url;

            Driver.myDriver.Navigate().GoToUrl("http://ts2.travian.de/");

            Driver.myDriver.FindElement(By.Name("name")).SendKeys(myUserName.Trim());
            Driver.myDriver.FindElement(By.Name("password")).SendKeys(myPassword.Trim());

            old_url = Driver.myDriver.Url;
            Driver.myDriver.FindElement(By.Name("s1")).Click();

            new_url = Driver.myDriver.Url;

            return (old_url != new_url) ? true : false;
        }
    }
}
