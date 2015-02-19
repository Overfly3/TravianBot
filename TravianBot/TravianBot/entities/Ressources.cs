using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravianBot.entities
{
    public class Ressources
    {
        IWebDriver myDriver;
        public Ressources(IWebDriver driver)
        {
            myDriver = driver;
        }
        public int Wood
        {
            get
            {
                return getWood();
            }
        }
        public int Iron
        {
            get
            {
                return getIron();
            }
        }
        public int Clay
        {
            get
            {
                return getClay();
            }
        }
        public int Cereals
        {
            get
            {
                return getCereals();
            }
        }

        public int FreeCereals
        {
            get
            {
                return getFreeCereals();
            }
        }

        private int getCereals()
        {
            return int.Parse(myDriver.FindElement(By.Id("l4")).Text.Replace(".", string.Empty));
        }
        private int getWood()
        {
            return int.Parse(myDriver.FindElement(By.Id("l1")).Text.Replace(".", string.Empty));
        }
        private int getIron()
        {
            return int.Parse(myDriver.FindElement(By.Id("l3")).Text.Replace(".",string.Empty));
        }
        private int getClay()
        {
            return int.Parse(myDriver.FindElement(By.Id("l2")).Text.Replace(".", string.Empty));
        }
        private int getFreeCereals()
        {
            return int.Parse(myDriver.FindElement(By.Id("l5")).Text.Replace(".", string.Empty));
        }
    }
}
