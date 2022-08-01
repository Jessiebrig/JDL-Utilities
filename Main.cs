using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JDL_Utilities
{
    public partial class Main : Form
    {
        public Main()
        {
            main = this;
            InitializeComponent();
        }

        public static Main main;
        public static ChromeX2_Form ChromeX2;
        public static Selenium Selenium;
        public static CMD_Utility_Form CMD_Utility;
        public static Advance_Form Advance;

        static Process CMD;
        public static void QuickCMD(string command)
        {
            CMD = new Process();
            CMD.StartInfo.CreateNoWindow = true;
            CMD.StartInfo.FileName = "cmd.exe";
            CMD.StartInfo.Arguments = $"/C {command}";
            CMD.Start();
            Thread.Sleep(100);
            CMD.Kill();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            Advance = new Advance_Form();//Create instance for  Settings_Form right away
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            Panel_Main.Visible = true;
            Panel_Child.Visible = false;
        }
        
        private void Btn_ChromeX2_Click(object sender, EventArgs e)
        {
            if (ChromeX2 == null)
            {
                ChromeX2 = new ChromeX2_Form();
            }
            OpenChildForm(ChromeX2);
            Main.ChromeX2.LoadProfiles(Main.ChromeX2.Cmb_Profiles);
            Main.ChromeX2.Cmb_Profiles.SelectedIndex = Main.ChromeX2.Profile_Index;
        }
        private void Btn_Selenium_Click(object sender, EventArgs e)
        {
            if (Selenium == null)
            {
                Selenium = new Selenium();
                if (ChromeX2 == null)
                {
                    ChromeX2 = new ChromeX2_Form();
                }
            }
            OpenChildForm(Selenium);
            Main.ChromeX2.LoadProfiles(Main.Selenium.Cmb_Profiles);
            //Main.Selenium.Cmb_Profiles.SelectedIndex = Main.Selenium.Profile_Index;
        }
        private void Btn_CMD_Util_Click(object sender, EventArgs e)
        {
            if (CMD_Utility == null)
            {
                CMD_Utility = new CMD_Utility_Form();
            }
            OpenChildForm(CMD_Utility);
        }
        private void Btn_Advance_Click(object sender, EventArgs e)
        {
            OpenChildForm(Advance);
        }

        private void OpenChildForm(Form childform)
        {
            try
            {
                Panel_Main.Visible = false;
                Panel_Child.Visible = true;
                Panel_Child.Controls.Clear();
                childform.TopLevel = false;
                childform.FormBorderStyle = FormBorderStyle.None;
                childform.Dock = DockStyle.Fill;
                Panel_Child.Controls.Add(childform);
                Panel_Child.Tag = childform;
                childform.BringToFront();
                childform.Show();
            }
            catch (Exception ex) { LOG(ex.Message); }
        }

        public static void LOG(string log)
        {
            main.Invoke(new Action(() =>
            {
                main.Tbx_LOG.AppendText(log + Environment.NewLine);
                main.Tbx_LOG.ScrollToCaret();
            }));
        }
        public static void LOGdbg(string log)
        {
            if (Configs.GetSet.DevMode) { LOG(log); }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        
    }
}
