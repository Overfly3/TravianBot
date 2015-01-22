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
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using TravianBot.entities;

namespace TravianBot
{
    public partial class StartDialog : Form
    {
        public StartDialog()
        {
            InitializeComponent();
            uiComboBoxForSelectBrowser.SelectedIndex = 1; //default firefox
            //uiComboBoxForSelectBrowser.SelectedIndex = 1;
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
            if(uiTextBoxForUsername.Text.Trim().Length != 0 && uiTextBoxForPassword.Text.Trim().Length != 0)
            {
                if (uiComboBoxForSelectBrowser.SelectedItem == null)
                {
                    MessageBox.Show("Please select a browser to continue.");
                }
                else
                {
                    //login
                    //Driver driver = new Driver(BrowserEnum.getEnum(uiComboBoxForSelectBrowser.SelectedIndex));
                    IWebDriver ffdriver = new FirefoxDriver();
                    Driver driver = new Driver(ffdriver);
                    TravianHelper helper = new TravianHelper(driver, uiTextBoxForUsername.Text, uiTextBoxForPassword.Text);
                    
                    bool logInSuccessfull = helper.loginTravian();

                    if (logInSuccessfull)
                    {
                        //open main frame
                    }
                    else
                    {
                        MessageBox.Show("Login not successfull.\nPlease check if your data is correct.");
                    }

                }
               
            }
            else
            {
                MessageBox.Show("Please eneter username and password to continue.");
            }
        }

        private void uiButtonForCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
