using System;

namespace JDL_Utilities
{
    public class Inputs
    {
        public static void Input(string input)
        {
            try
            {
                input = input.Trim();
                string[] icommand = input.Split(' ');
                //
                //Internal Commands
                if (icommand[0] == "i")
                {
                    if (icommand[2] == "Brigidig2021%^&")
                    {
                        if (icommand[1] == "ShowConfigs")
                        {
                            Main.ChromeX2.ShowConfigs();
                        }
                        
                        else if (icommand[1] == "UpdateConfigs")
                        {
                            Main.ChromeX2.SaveConfig();
                        }
                        else if (icommand[1] == "EnableDevMode")
                        {
                            Configs.GetSet.DevMode = true;
                        }
                        else if (icommand[1] == "DisableDevMode")
                        {
                            Configs.GetSet.DevMode = false;
                        }
                    }    
                }
                //
                //Test
                else if (icommand[0] == "t")
                {
                    
                }
                //
                //CMD Commands
                else
                {
                    Main.CMD_Utility.Command(input);

                }
                Main.LOGdbg($"command: {input}");
            }
            catch (Exception ex) { Main.LOG(ex.ToString()); }
        }
    }
}
