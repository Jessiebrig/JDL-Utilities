using System;
using System.Windows.Forms;

namespace JDL_Utilities
{
    public partial class CMD_Utility_Form : Form
    {
        CMDBroker CMD;
        public CMD_Utility_Form()
        {
            InitializeComponent();
            CMD = new CMDBroker(this, Tbx_OUT);
        }
        public void CMD_Utility_Form_Load(object sender, EventArgs e)
        {
            CMD.Start();
        }
        public void LOG(string log) { Main.LOG(log); }

        public void Command(string input)
        {
            CMD.Command(input);
            Main.LOGdbg(input);
        }

        private void tbx_IN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                string input = Tbx_IN.Text.Trim();
                Inputs.Input(input);
                if (input == "cls")
                {
                    Tbx_OUT.Clear();
                }
                Tbx_IN.Clear();
            }
        }
    }
}
