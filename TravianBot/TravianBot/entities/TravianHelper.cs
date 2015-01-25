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

        public Ressources GetRessources()
        {
            Village village = new Village(Driver.WebDriver);
            return village.Ressources;
        }

        public Buildings GetBuildings()
         {
            Village village = new Village(Driver.WebDriver);
            return village.Buildings;
        }

        public bool loginTravian()
        {
            String old_url;
            String new_url;

            Driver.WebDriver.Navigate().GoToUrl("http://ts2.travian.de/");

            Driver.WebDriver.FindElement(By.Name("name")).SendKeys(myUserName.Trim());
            Driver.WebDriver.FindElement(By.Name("password")).SendKeys(myPassword.Trim());

            old_url = Driver.WebDriver.Url;
            Driver.WebDriver.FindElement(By.Name("s1")).Click();

            new_url = Driver.WebDriver.Url;
            Driver.WebDriver.Navigate().GoToUrl("http://ts2.travian.de/dorf2.php");

            return (old_url != new_url) ? true : false;
        }
    }
}
