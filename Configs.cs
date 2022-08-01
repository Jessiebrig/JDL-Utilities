

namespace JDL_Utilities
{
    public class Configs
    {
        public struct GetSet
        {
            static bool devmode = false;
            //string
            static public string Chromedir
            {
                get { return Properties.Settings.Default.Chrome_Directory; }
                set { Properties.Settings.Default.Chrome_Directory = value; }
            }
            static public string Bravedir
            {
                get { return Properties.Settings.Default.Brave_Directory; }
                set { Properties.Settings.Default.Brave_Directory = value; }
            }
            //
            //bool
            static public bool DevMode
            {
                get { return devmode; }
                set 
                {
                    devmode = value; 
                    if (devmode) { Main.Advance.Label_Mode.Text = "Developer Mode"; } 
                    else { Main.Advance.Label_Mode.Text = "User Mode"; }
                } 
            }
        }
    }
}
