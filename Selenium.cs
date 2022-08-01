using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JDL_Utilities
{
    public partial class Selenium : Form
    {
        public Selenium()
        {
            InitializeComponent();
            WebDriver = new WebDriver();
        }

        WebDriver WebDriver;

        private void Btn_Load_Profile_Click(object sender, EventArgs e)
        {
            string[] Path = Main.ChromeX2.ProfileArray[Cmb_Profiles.SelectedIndex].Split(" ");
            if (Path[0].Contains("Chrome"))
            {
                //Chrome(Path[1]);
                WebDriver.Load_WebDriver(Path[1]);
            }
            else if (Path[0].Contains("Brave"))
            {
                //Brave(Path[1]);
                //WebDriver.Load_WebDriver(Path[1]);
            }
        }

        private void Tbx_URL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    e.SuppressKeyPress = true;
                    string URL = Tbx_URL.Text.Trim();
                    WebDriver.Navi(URL);
                }
                catch (Exception ex)
                {
                    Main.LOG(ex.ToString());
                }
            }
        }
    }
}
