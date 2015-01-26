using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravianBot.entities
{
    class Village
    {
        IWebDriver myDriver;
        public Village(IWebDriver driver)
        {
            myDriver = driver;
        }
        public Ressources Ressources
        {
            get
            {
                return new Ressources(myDriver);
            }
        }
        public List<Building> Buildings
        {
            get
            {
                return getBuildings();
            }
        }

        private List<Building> getBuildings()
        {
            List<Building> buildings = new List<Building>();
            foreach (IWebElement element in myDriver.FindElements(By.TagName("area")))
            {
                buildings.Add(new Building(element, myDriver));
            }
            return buildings;
        }
    }
}
