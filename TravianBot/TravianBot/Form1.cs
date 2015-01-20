using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TravianBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IWebDriver driver = new ChromeDriver("C:\\Program Files (x86)\\Google\\Chrome\\Application");
            driver.Navigate().GoToUrl("http://www.google.ch");
            //driver.FindElement(By.Name("q")).SendKeys("Let's destroy this shit");
            IWebElement query = driver.FindElement(By.Name("q"));
            query.SendKeys("fdsdfs");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
