using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TravianBot.entities
{
    class Buildings
    {
        IWebDriver myDriver;

        public Buildings(IWebDriver driver)
        {
            myDriver = driver;
        }

        IList<IWebElement> BuildingsList
        {
            get
            {
                return getBuildings();
            }
        }

        private IList<IWebElement> getBuildings()
        {
            return myDriver.FindElements(By.CssSelector("#clickareas > area"));
        }


    }
}
