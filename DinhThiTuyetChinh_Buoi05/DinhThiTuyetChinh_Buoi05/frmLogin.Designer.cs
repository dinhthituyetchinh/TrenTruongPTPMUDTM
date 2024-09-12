namespace DinhThiTuyetChinh_Buoi05
{
    partial class LoginForm
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
            this.ucLogin2 = new md_Login.ucLogin();
            this.SuspendLayout();
            // 
            // ucLogin2
            // 
            this.ucLogin2.Location = new System.Drawing.Point(149, 26);
            this.ucLogin2.Name = "ucLogin2";
            this.ucLogin2.PConfig = null;
            this.ucLogin2.Size = new System.Drawing.Size(375, 215);
            this.ucLogin2.TabIndex = 0;
            this.ucLogin2.Tt = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 277);
            this.Controls.Add(this.ucLogin2);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private md_Login.ucLogin ucLogin2;
    }
}

