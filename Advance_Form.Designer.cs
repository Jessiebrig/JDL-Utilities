
namespace JDL_Utilities
{
    partial class Advance_Form
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
            this.Tbx_IN = new System.Windows.Forms.TextBox();
            this.Label_Mode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tbx_IN
            // 
            this.Tbx_IN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_IN.AutoCompleteCustomSource.AddRange(new string[] {
            "i EnableDevMode Password",
            "i DisableDevMode Password"});
            this.Tbx_IN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Tbx_IN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Tbx_IN.Location = new System.Drawing.Point(12, 225);
            this.Tbx_IN.Name = "Tbx_IN";
            this.Tbx_IN.Size = new System.Drawing.Size(476, 23);
            this.Tbx_IN.TabIndex = 2;
            this.Tbx_IN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tbx_IN_KeyDown);
            // 
            // Label_Mode
            // 
            this.Label_Mode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Mode.AutoSize = true;
            this.Label_Mode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Mode.Location = new System.Drawing.Point(363, 9);
            this.Label_Mode.Name = "Label_Mode";
            this.Label_Mode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label_Mode.Size = new System.Drawing.Size(86, 21);
            this.Label_Mode.TabIndex = 3;
            this.Label_Mode.Text = "User Mode";
            this.Label_Mode.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Settings_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 260);
            this.Controls.Add(this.Label_Mode);
            this.Controls.Add(this.Tbx_IN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings_Form";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tbx_IN;
        public System.Windows.Forms.Label Label_Mode;
    }
}