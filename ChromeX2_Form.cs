using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace JDL_Utilities
{
    public partial class ChromeX2_Form : Form
    {
        public ChromeX2_Form()
        {
            InitializeComponent();
        }
        public int Profile_Index;
        public string[] ProfileArray;
        string Profiles;
        public void LoadProfiles(ComboBox comboBox)
        {
            Profiles = null;
            //Cmb_Profiles.Items.Clear();
            comboBox.Items.Clear();
            try
            {
                for (int i = 0; i < Properties.Settings.Default.Profiles.Count; i++)
                {
                    if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.Profiles[i]))
                    { 
                        if (Properties.Settings.Default.Profiles[i].Contains("Black"))
                        {
                            if (Configs.GetSet.DevMode)
                            {
                                Profiles += Properties.Settings.Default.Profiles[i] + Environment.NewLine;
                            }
                            else
                            {
                                Profiles += "Profile_Locked " + Environment.NewLine;
                            }
                        }
                        else
                        {
                            Profiles += Properties.Settings.Default.Profiles[i] + Environment.NewLine;
                        }
                    }
                }
                ProfileArray = Profiles.Split('\n');
                ProfileArray = ProfileArray.Where(s => s.Trim() != string.Empty).ToArray();// remove the last empty line from Environment.NewLine;
                foreach (string profile in ProfileArray)
                {
                    string[] user = profile.Split(' ');
                    if (Configs.GetSet.DevMode)
                    {
                        //Cmb_Profiles.Items.Add($"{user[0]} {user[1]}");
                        comboBox.Items.Add($"{user[0]} {user[1]}");
                    }
                    else
                    {
                        //Cmb_Profiles.Items.Add(user[0]);
                        comboBox.Items.Add(user[0]);
                    }
                }
                //Cmb_Profiles.SelectedIndex = 0;
                comboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Main.LOGdbg(ex.ToString());
            }
        }

        private void Btn_Load_Profile_Click(object sender, EventArgs e)
        {
            Profile_Index = Cmb_Profiles.SelectedIndex;
            string[] Path = ProfileArray[Cmb_Profiles.SelectedIndex].Split(" ");
            if (Path[0].Contains("Chrome"))
            {
                Chrome(Path[1]);
            }
            else if (Path[0].Contains("Brave"))
            {
                Brave(Path[1]);
            }
        }
        public void ShowConfigs()
        {
            Tbx_OUT.Clear();
            foreach (string config in Properties.Settings.Default.Profiles)
            {
                Tbx_OUT.Text += config + Environment.NewLine;
            }
        }
        
        private void Tbx_IN_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                string input = Tbx_IN.Text.Trim();
                Inputs.Input(input);
                LoadProfiles(Main.ChromeX2.Cmb_Profiles);
            }
        }
        private void Chrome(string path)
        {
            string command = $"{Configs.GetSet.Chromedir} --user-data-dir={path}";
            Main.QuickCMD(command);
        }
        private void Brave(string path)
        {
            string command = $"{Configs.GetSet.Bravedir} --user-data-dir={path}";
            Main.QuickCMD(command);
        }
        //
        bool error;
        static string saving;

        public void SaveConfig()
        {
            try
            {
                string[] ConfigArray = Tbx_OUT.Text.Split('\n');
                ConfigArray = ConfigArray.Where(s => s.Trim() != string.Empty).ToArray();
                foreach (string config in ConfigArray)
                {
                    Main.LOGdbg(config);
                    saving = config;
                    string[] con = saving.Split(' ');
                    if (con[1] == null)
                    {
                        error = true;
                    }
                }
                if (!error)
                {
                    Properties.Settings.Default.Profiles.Clear();
                    Tbx_OUT.Clear();
                    foreach (string config in ConfigArray)
                    {
                        Properties.Settings.Default.Profiles.Add(config);
                        Tbx_OUT.Text += config + Environment.NewLine;
                    }
                    Properties.Settings.Default.Save();
                    Main.LOG("Save Successfully..");
                }
            }
            catch (Exception ex)
            {
                Main.LOG($"Error Saving => {saving}");
                Main.LOGdbg(ex.ToString());
            }
        }
    }
}
