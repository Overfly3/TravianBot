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
    public partial class StartDialog : Form
    {
        public StartDialog()
        {
            InitializeComponent();
            /** example code
            IWebDriver driver = new ChromeDriver("C:\\Program Files (x86)\\Google\\Chrome\\Application");
            driver.Navigate().GoToUrl("http://www.google.ch");
            IWebElement query = driver.FindElement(By.Name("q"));
            query.SendKeys("fdsdfs"); **/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void uiButtonForConfirm_Click(object sender, EventArgs e)
        {

        }

        private void uiButtonForCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
