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

        public BuildingTypeEnum Type
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

        private BuildingTypeEnum getType()
        {
            /**<area alt=" shape="poly" coords="280,113,301,98,301,99,329,100,349,114,348,169,327,181,298,181,278,168" href="build.php?id=26">
             * 
             * Hauptgebäude <span class=&quot;level&quot;>Stufe 1</span>||Kosten für Ausbau auf Stufe 2:<br />
					<div class=&quot;showCosts&quot;>
				<span class=&quot;resources r1&quot;>
				<img class=&quot;r1&quot; src=&quot;img/x.gif&quot; />90
				</span> 
				<span class=&quot;resources r2&quot;>
				<img class=&quot;r2&quot; src=&quot;img/x.gif&quot; />50
				</span> 
				<span class=&quot;resources r3&quot;>
				<img class=&quot;r3&quot; src=&quot;img/x.gif&quot; />75
				</span> 
				<span class=&quot;resources r4&quot;>
				<img class=&quot;r4&quot; src=&quot;img/x.gif&quot; />25
				</span> <div class=&quot;clear&quot;></div>"$
             * 
             * <area alt="Bauplatz" shape="poly" coords="516,196,538,182,538,182,566,183,585,198,585,212,564,224,534,224,515,211" href="build.php?id=25">**/
            throw new NotImplementedException();
        }

        private int getId()
        {


            // example link: build.php?id=30
            Dictionary<string, object> attributes = getAttributes();
            string link = attributes["href"].ToString();
            return int.Parse(link.Replace("build.php?id=", ""));
        }

        private Dictionary<string, object> getAttributes()
        {
            IJavaScriptExecutor javascriptDriver = (IJavaScriptExecutor)myDriver;
            return javascriptDriver.ExecuteScript("var items = {}; for (index = 0; index < arguments[0].attributes.length; ++index) { items[arguments[0].attributes[index].name] = arguments[0].attributes[index].value }; return items;", myElement) as Dictionary<string, object>;
        }

        public Dictionary<string, object> Attributes
        {
            get
            {
                return getAttributes();
            }
        }
    }
}
