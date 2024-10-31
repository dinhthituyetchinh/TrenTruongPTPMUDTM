namespace _2001215640_DinhThiTuyetChinh_KT02
{
    partial class frmBai3
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
            this.btnLoaiSanPham = new System.Windows.Forms.Button();
            this.btnPhieuNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoaiSanPham
            // 
            this.btnLoaiSanPham.Location = new System.Drawing.Point(135, 157);
            this.btnLoaiSanPham.Name = "btnLoaiSanPham";
            this.btnLoaiSanPham.Size = new System.Drawing.Size(137, 23);
            this.btnLoaiSanPham.TabIndex = 0;
            this.btnLoaiSanPham.Text = "Loại Sản Phẩm";
            this.btnLoaiSanPham.UseVisualStyleBackColor = true;
            // 
            // btnPhieuNhap
            // 
            this.btnPhieuNhap.Location = new System.Drawing.Point(451, 157);
            this.btnPhieuNhap.Name = "btnPhieuNhap";
            this.btnPhieuNhap.Size = new System.Drawing.Size(75, 23);
            this.btnPhieuNhap.TabIndex = 1;
            this.btnPhieuNhap.Text = "Phiếu Nhập";
            this.btnPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 375);
            this.Controls.Add(this.btnPhieuNhap);
            this.Controls.Add(this.btnLoaiSanPham);
            this.Name = "frmBai3";
            this.Text = "frmBai3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoaiSanPham;
        private System.Windows.Forms.Button btnPhieuNhap;

    }
}