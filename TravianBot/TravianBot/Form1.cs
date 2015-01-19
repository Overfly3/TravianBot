using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatiN.Core;
using WatiN.Core.Interfaces;
using WatiN.Core.Logging;
using WatiN.Core.DialogHandlers;

namespace TravianBot
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();

            test();
        }

        private void test()
        {
            SearchForWatiNOnGoogle();
        }

        public void SearchForWatiNOnGoogle()
        {
            using (var browser = new IE("http://www.google.com"))
            {
                browser.TextField(Find.ByName("q")).TypeText("WatiN");
                browser.Button(Find.ByName("btnG")).Click();
            }
        } 
    }
}
