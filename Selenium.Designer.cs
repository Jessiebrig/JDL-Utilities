
namespace JDL_Utilities
{
    partial class Selenium
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
            this.Tbx_URL = new System.Windows.Forms.TextBox();
            this.Btn_Load_Profile = new System.Windows.Forms.Button();
            this.Cmb_Profiles = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Tbx_URL
            // 
            this.Tbx_URL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_URL.AutoCompleteCustomSource.AddRange(new string[] {
            "i EnableDevMode Password",
            "i DisableDevMode Password"});
            this.Tbx_URL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Tbx_URL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Tbx_URL.Location = new System.Drawing.Point(12, 12);
            this.Tbx_URL.Name = "Tbx_URL";
            this.Tbx_URL.Size = new System.Drawing.Size(476, 23);
            this.Tbx_URL.TabIndex = 3;
            this.Tbx_URL.Text = "https://www.google.com/";
            this.Tbx_URL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tbx_URL_KeyDown);
            // 
            // Btn_Load_Profile
            // 
            this.Btn_Load_Profile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Load_Profile.Location = new System.Drawing.Point(388, 41);
            this.Btn_Load_Profile.Name = "Btn_Load_Profile";
            this.Btn_Load_Profile.Size = new System.Drawing.Size(100, 23);
            this.Btn_Load_Profile.TabIndex = 5;
            this.Btn_Load_Profile.Text = "Load";
            this.Btn_Load_Profile.UseVisualStyleBackColor = true;
            this.Btn_Load_Profile.Click += new System.EventHandler(this.Btn_Load_Profile_Click);
            // 
            // Cmb_Profiles
            // 
            this.Cmb_Profiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cmb_Profiles.FormattingEnabled = true;
            this.Cmb_Profiles.Location = new System.Drawing.Point(162, 41);
            this.Cmb_Profiles.Name = "Cmb_Profiles";
            this.Cmb_Profiles.Size = new System.Drawing.Size(220, 23);
            this.Cmb_Profiles.TabIndex = 4;
            // 
            // Selenium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 260);
            this.Controls.Add(this.Btn_Load_Profile);
            this.Controls.Add(this.Cmb_Profiles);
            this.Controls.Add(this.Tbx_URL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Selenium";
            this.Text = "Selenium";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tbx_IN;
        private System.Windows.Forms.Button Btn_Load_Profile;
        public System.Windows.Forms.ComboBox Cmb_Profiles;
        private System.Windows.Forms.TextBox Tbx_URL;
    }
}