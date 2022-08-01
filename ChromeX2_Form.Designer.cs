
namespace JDL_Utilities
{
    partial class ChromeX2_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cmb_Profiles = new System.Windows.Forms.ComboBox();
            this.Tbx_IN = new System.Windows.Forms.TextBox();
            this.Btn_Load_Profile = new System.Windows.Forms.Button();
            this.Tbx_OUT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cmb_Profiles
            // 
            this.Cmb_Profiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cmb_Profiles.FormattingEnabled = true;
            this.Cmb_Profiles.Location = new System.Drawing.Point(12, 6);
            this.Cmb_Profiles.Name = "Cmb_Profiles";
            this.Cmb_Profiles.Size = new System.Drawing.Size(220, 23);
            this.Cmb_Profiles.TabIndex = 0;
            // 
            // Tbx_IN
            // 
            this.Tbx_IN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_IN.AutoCompleteCustomSource.AddRange(new string[] {
            "i EnableDevMode Password",
            "i DisableDevMode Password",
            "i ShowConfigs Password",
            "i UpdateConfigs Password"});
            this.Tbx_IN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Tbx_IN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Tbx_IN.Location = new System.Drawing.Point(12, 35);
            this.Tbx_IN.Name = "Tbx_IN";
            this.Tbx_IN.Size = new System.Drawing.Size(326, 23);
            this.Tbx_IN.TabIndex = 1;
            this.Tbx_IN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tbx_IN_KeyDown);
            // 
            // Btn_Load_Profile
            // 
            this.Btn_Load_Profile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Load_Profile.Location = new System.Drawing.Point(238, 6);
            this.Btn_Load_Profile.Name = "Btn_Load_Profile";
            this.Btn_Load_Profile.Size = new System.Drawing.Size(100, 23);
            this.Btn_Load_Profile.TabIndex = 2;
            this.Btn_Load_Profile.Text = "Load";
            this.Btn_Load_Profile.UseVisualStyleBackColor = true;
            this.Btn_Load_Profile.Click += new System.EventHandler(this.Btn_Load_Profile_Click);
            // 
            // Tbx_OUT
            // 
            this.Tbx_OUT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_OUT.Location = new System.Drawing.Point(12, 63);
            this.Tbx_OUT.Multiline = true;
            this.Tbx_OUT.Name = "Tbx_OUT";
            this.Tbx_OUT.Size = new System.Drawing.Size(326, 23);
            this.Tbx_OUT.TabIndex = 3;
            // 
            // ChromeX2_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 98);
            this.Controls.Add(this.Tbx_OUT);
            this.Controls.Add(this.Btn_Load_Profile);
            this.Controls.Add(this.Tbx_IN);
            this.Controls.Add(this.Cmb_Profiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChromeX2_Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Tbx_IN;
        private System.Windows.Forms.Button Btn_Load_Profile;
        public System.Windows.Forms.ComboBox Cmb_Profiles;
        public System.Windows.Forms.TextBox Tbx_OUT;
    }
}