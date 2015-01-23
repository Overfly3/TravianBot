using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravianBot.entities
{
    class Ressources
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
        private int getCereals()
        {
            return int.Parse(myDriver.FindElement(By.Id("l4")).Text);
        }
        private int getWood()
        {
            return int.Parse(myDriver.FindElement(By.Id("l1")).Text);
        }
        private int getIron()
        {
            return int.Parse(myDriver.FindElement(By.Id("l3")).Text);
        }
        private int getClay()
        {
            return int.Parse(myDriver.FindElement(By.Id("l2")).Text);
        }
    }
}
