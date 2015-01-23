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
    }
}
