namespace _2001215640_DinhThiTuyetChinh_KT02
{
    partial class frmPhieuNhap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuNhap));
            System.Windows.Forms.Label maPhieuNhapLabel;
            System.Windows.Forms.Label maNCCLabel;
            System.Windows.Forms.Label ngayNhapLabel;
            System.Windows.Forms.Label thanhTienLabel;
            this.quanLySanPham = new _2001215640_DinhThiTuyetChinh_KT02.QuanLySanPham();
            this.phieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new _2001215640_DinhThiTuyetChinh_KT02.QuanLySanPhamTableAdapters.PhieuNhapTableAdapter();
            this.tableAdapterManager = new _2001215640_DinhThiTuyetChinh_KT02.QuanLySanPhamTableAdapters.TableAdapterManager();
            this.phieuNhapBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.phieuNhapBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.maPhieuNhapTextBox = new System.Windows.Forms.TextBox();
            this.maNCCTextBox = new System.Windows.Forms.TextBox();
            this.ngayNhapDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.thanhTienTextBox = new System.Windows.Forms.TextBox();
            this.phieuNhapDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            maPhieuNhapLabel = new System.Windows.Forms.Label();
            maNCCLabel = new System.Windows.Forms.Label();
            ngayNhapLabel = new System.Windows.Forms.Label();
            thanhTienLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingNavigator)).BeginInit();
            this.phieuNhapBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // quanLySanPham
            // 
            this.quanLySanPham.DataSetName = "QuanLySanPham";
            this.quanLySanPham.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phieuNhapBindingSource
            // 
            this.phieuNhapBindingSource.DataMember = "PhieuNhap";
            this.phieuNhapBindingSource.DataSource = this.quanLySanPham;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiTietPhieuNhapTableAdapter = null;
            this.tableAdapterManager.LoaiSanPhamTableAdapter = null;
            this.tableAdapterManager.NhaCungCapTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.SanPhamTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = _2001215640_DinhThiTuyetChinh_KT02.QuanLySanPhamTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // phieuNhapBindingNavigator
            // 
            this.phieuNhapBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.phieuNhapBindingNavigator.BindingSource = this.phieuNhapBindingSource;
            this.phieuNhapBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.phieuNhapBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.phieuNhapBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.phieuNhapBindingNavigatorSaveItem});
            this.phieuNhapBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.phieuNhapBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.phieuNhapBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.phieuNhapBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.phieuNhapBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.phieuNhapBindingNavigator.Name = "phieuNhapBindingNavigator";
            this.phieuNhapBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.phieuNhapBindingNavigator.Size = new System.Drawing.Size(678, 25);
            this.phieuNhapBindingNavigator.TabIndex = 0;
            this.phieuNhapBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // phieuNhapBindingNavigatorSaveItem
            // 
            this.phieuNhapBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.phieuNhapBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("phieuNhapBindingNavigatorSaveItem.Image")));
            this.phieuNhapBindingNavigatorSaveItem.Name = "phieuNhapBindingNavigatorSaveItem";
            this.phieuNhapBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.phieuNhapBindingNavigatorSaveItem.Text = "Save Data";
            this.phieuNhapBindingNavigatorSaveItem.Click += new System.EventHandler(this.phieuNhapBindingNavigatorSaveItem_Click);
            // 
            // maPhieuNhapLabel
            // 
            maPhieuNhapLabel.AutoSize = true;
            maPhieuNhapLabel.Location = new System.Drawing.Point(156, 52);
            maPhieuNhapLabel.Name = "maPhieuNhapLabel";
            maPhieuNhapLabel.Size = new System.Drawing.Size(84, 13);
            maPhieuNhapLabel.TabIndex = 1;
            maPhieuNhapLabel.Text = "Ma Phieu Nhap:";
            // 
            // maPhieuNhapTextBox
            // 
            this.maPhieuNhapTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuNhapBindingSource, "MaPhieuNhap", true));
            this.maPhieuNhapTextBox.Location = new System.Drawing.Point(246, 49);
            this.maPhieuNhapTextBox.Name = "maPhieuNhapTextBox";
            this.maPhieuNhapTextBox.Size = new System.Drawing.Size(200, 20);
            this.maPhieuNhapTextBox.TabIndex = 2;
            // 
            // maNCCLabel
            // 
            maNCCLabel.AutoSize = true;
            maNCCLabel.Location = new System.Drawing.Point(156, 78);
            maNCCLabel.Name = "maNCCLabel";
            maNCCLabel.Size = new System.Drawing.Size(50, 13);
            maNCCLabel.TabIndex = 3;
            maNCCLabel.Text = "Ma NCC:";
            // 
            // maNCCTextBox
            // 
            this.maNCCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuNhapBindingSource, "MaNCC", true));
            this.maNCCTextBox.Location = new System.Drawing.Point(246, 75);
            this.maNCCTextBox.Name = "maNCCTextBox";
            this.maNCCTextBox.Size = new System.Drawing.Size(200, 20);
            this.maNCCTextBox.TabIndex = 4;
            // 
            // ngayNhapLabel
            // 
            ngayNhapLabel.AutoSize = true;
            ngayNhapLabel.Location = new System.Drawing.Point(156, 105);
            ngayNhapLabel.Name = "ngayNhapLabel";
            ngayNhapLabel.Size = new System.Drawing.Size(64, 13);
            ngayNhapLabel.TabIndex = 5;
            ngayNhapLabel.Text = "Ngay Nhap:";
            // 
            // ngayNhapDateTimePicker
            // 
            this.ngayNhapDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.phieuNhapBindingSource, "NgayNhap", true));
            this.ngayNhapDateTimePicker.Location = new System.Drawing.Point(246, 101);
            this.ngayNhapDateTimePicker.Name = "ngayNhapDateTimePicker";
            this.ngayNhapDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ngayNhapDateTimePicker.TabIndex = 6;
            // 
            // thanhTienLabel
            // 
            thanhTienLabel.AutoSize = true;
            thanhTienLabel.Location = new System.Drawing.Point(156, 130);
            thanhTienLabel.Name = "thanhTienLabel";
            thanhTienLabel.Size = new System.Drawing.Size(65, 13);
            thanhTienLabel.TabIndex = 7;
            thanhTienLabel.Text = "Thanh Tien:";
            // 
            // thanhTienTextBox
            // 
            this.thanhTienTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuNhapBindingSource, "ThanhTien", true));
            this.thanhTienTextBox.Location = new System.Drawing.Point(246, 127);
            this.thanhTienTextBox.Name = "thanhTienTextBox";
            this.thanhTienTextBox.Size = new System.Drawing.Size(200, 20);
            this.thanhTienTextBox.TabIndex = 8;
            // 
            // phieuNhapDataGridView
            // 
            this.phieuNhapDataGridView.AutoGenerateColumns = false;
            this.phieuNhapDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phieuNhapDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.phieuNhapDataGridView.DataSource = this.phieuNhapBindingSource;
            this.phieuNhapDataGridView.Location = new System.Drawing.Point(101, 229);
            this.phieuNhapDataGridView.Name = "phieuNhapDataGridView";
            this.phieuNhapDataGridView.Size = new System.Drawing.Size(454, 220);
            this.phieuNhapDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaPhieuNhap";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaPhieuNhap";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaNCC";
            this.dataGridViewTextBoxColumn2.HeaderText = "MaNCC";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NgayNhap";
            this.dataGridViewTextBoxColumn3.HeaderText = "NgayNhap";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ThanhTien";
            this.dataGridViewTextBoxColumn4.HeaderText = "ThanhTien";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 538);
            this.Controls.Add(this.phieuNhapDataGridView);
            this.Controls.Add(maPhieuNhapLabel);
            this.Controls.Add(this.maPhieuNhapTextBox);
            this.Controls.Add(maNCCLabel);
            this.Controls.Add(this.maNCCTextBox);
            this.Controls.Add(ngayNhapLabel);
            this.Controls.Add(this.ngayNhapDateTimePicker);
            this.Controls.Add(thanhTienLabel);
            this.Controls.Add(this.thanhTienTextBox);
            this.Controls.Add(this.phieuNhapBindingNavigator);
            this.Name = "frmPhieuNhap";
            this.Text = "frmPhieuNhap";
            this.Load += new System.EventHandler(this.frmPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLySanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingNavigator)).EndInit();
            this.phieuNhapBindingNavigator.ResumeLayout(false);
            this.phieuNhapBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuanLySanPham quanLySanPham;
        private System.Windows.Forms.BindingSource phieuNhapBindingSource;
        private QuanLySanPhamTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private QuanLySanPhamTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator phieuNhapBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton phieuNhapBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox maPhieuNhapTextBox;
        private System.Windows.Forms.TextBox maNCCTextBox;
        private System.Windows.Forms.DateTimePicker ngayNhapDateTimePicker;
        private System.Windows.Forms.TextBox thanhTienTextBox;
        private System.Windows.Forms.DataGridView phieuNhapDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}