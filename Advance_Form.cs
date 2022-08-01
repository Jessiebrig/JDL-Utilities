using System;
using System.Windows.Forms;

namespace JDL_Utilities
{
    public partial class Advance_Form : Form
    {
        public Advance_Form()
        {
            InitializeComponent();
        }

        private void Settings_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void Tbx_IN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                string input = Tbx_IN.Text.Trim();
                Inputs.Input(input);
            }
        }
    }
}
