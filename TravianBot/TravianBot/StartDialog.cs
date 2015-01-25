using System;
using System.Configuration;
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
using TravianBot.dialogs;

namespace TravianBot
{
    public partial class StartDialog : Form
    {
        public StartDialog()
        {
            InitializeComponent();
            setUi();
        }

        private void setUi()
        {
            addConfigsToDialog();
        }

        private void addConfigsToDialog()
        {
            //instance the config
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            //get settings settings
            if (config.AppSettings.Settings["username"] != null)
            {
                uiTextBoxForUsername.Text = config.AppSettings.Settings["username"].Value;
            }
            if (config.AppSettings.Settings["password"] != null)
            {
                uiTextBoxForPassword.Text = config.AppSettings.Settings["password"].Value;
            }
            if (config.AppSettings.Settings["browser"] != null)
            {
                uiComboBoxForSelectBrowser.SelectedIndex = int.Parse(config.AppSettings.Settings["browser"].Value);
            }
            else
            {
                uiComboBoxForSelectBrowser.SelectedIndex = 1;
            }
            config.AppSettings.Settings.Add("username", uiTextBoxForUsername.Text);
            config.AppSettings.Settings.Add("password", uiTextBoxForPassword.Text);
            config.AppSettings.Settings.Add("browser", uiComboBoxForSelectBrowser.SelectedIndex.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void uiButtonForConfirm_Click(object sender, EventArgs e)
        {
            saveSettingsToAppConfig();
            if(uiTextBoxForUsername.Text.Trim().Length != 0 && uiTextBoxForPassword.Text.Trim().Length != 0)
            {
                if (uiComboBoxForSelectBrowser.SelectedItem == null)
                {
                    MessageBox.Show("Please select a browser to continue.");
                }
                else
                {
                    //login
                    Driver driver = new Driver(BrowserEnum.getEnum(uiComboBoxForSelectBrowser.SelectedIndex));
                    TravianHelper helper = new TravianHelper(driver, uiTextBoxForUsername.Text, uiTextBoxForPassword.Text);
                    
                    bool logInSuccessfull = helper.loginTravian();

                    if (logInSuccessfull)
                    {
                        //helper.GetRessources();
                        helper.GetBuildings();
                        MainDialog mainDialog = new MainDialog();
                        mainDialog.Show();
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

        private void saveSettingsToAppConfig()
        {
            //instance the config
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            //add settings
            if (config.AppSettings.Settings["username"] != null)
            {
                config.AppSettings.Settings["username"].Value = uiTextBoxForUsername.Text;
            }
            else
            {
                config.AppSettings.Settings.Add("username", uiTextBoxForUsername.Text);
            }
            if (config.AppSettings.Settings["password"] != null)
            {
                config.AppSettings.Settings["password"].Value = uiTextBoxForPassword.Text;
            }
            else
            {
                config.AppSettings.Settings.Add("password", uiTextBoxForPassword.Text);
            }
            if (config.AppSettings.Settings["browser"] != null)
            {
                config.AppSettings.Settings["browser"].Value = uiComboBoxForSelectBrowser.SelectedIndex.ToString();
            }
            else
            {
                config.AppSettings.Settings.Add("browser", uiComboBoxForSelectBrowser.SelectedIndex.ToString());
            }

            //save settings
            config.Save(ConfigurationSaveMode.Minimal);
        }

        private void uiButtonForCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
