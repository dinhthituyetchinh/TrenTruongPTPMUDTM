namespace DinhThiTuyetChinh_Buoi05
{
    partial class frmConfigDB
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
            this.ucDB1 = new mdDB.ucDB();
            this.SuspendLayout();
            // 
            // ucDB1
            // 
            this.ucDB1.Location = new System.Drawing.Point(99, 42);
            this.ucDB1.Name = "ucDB1";
            this.ucDB1.Size = new System.Drawing.Size(421, 254);
            this.ucDB1.TabIndex = 0;
            // 
            // frmConfigDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 355);
            this.Controls.Add(this.ucDB1);
            this.Name = "frmConfigDB";
            this.Text = "frmConfigDB";
            this.ResumeLayout(false);

        }

        #endregion

        private mdDB.ucDB ucDB1;
    }
}