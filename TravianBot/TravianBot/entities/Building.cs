using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravianBot.entities
{
    public class Building
    {
        IWebElement myElement;
        IWebDriver myDriver;

        public Building(IWebElement element, IWebDriver driver)
        {
            myDriver = driver;
            myElement = element;
        }

        public int Id
        {
            get
            {
                return getId();
            }
        }

        public BuildingType Type
        {
            get
            {
                return getType();
            }
        }

        public Ressources Costs
        {
            get
            {
                return getCosts();
            }
        }

        public int Level
        {
            get
            {
                return getLevel();
            }
        }

        private int getLevel()
        {
            throw new NotImplementedException();
        }

        public Ressources getCosts()
        {
            throw new NotImplementedException();
        }

        private BuildingType getType()
        {
            throw new NotImplementedException();
        }

        private int getId()
        {
            throw new NotImplementedException();
        }

        private Dictionary<string, object> getAttributes()
        {
            IJavaScriptExecutor javascriptDriver = (IJavaScriptExecutor)myDriver;
            return javascriptDriver.ExecuteScript("var items = {}; for (index = 0; index < arguments[0].attributes.length; ++index) { items[arguments[0].attributes[index].name] = arguments[0].attributes[index].value }; return items;", myElement) as Dictionary<string, object>;
        }
    }
}
