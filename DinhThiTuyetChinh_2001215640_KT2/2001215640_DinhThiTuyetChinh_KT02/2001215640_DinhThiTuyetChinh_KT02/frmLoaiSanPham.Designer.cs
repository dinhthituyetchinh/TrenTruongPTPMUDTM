namespace _2001215640_DinhThiTuyetChinh_KT02
{
    partial class frmLoaiSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiSanPham));
            System.Windows.Forms.Label maLoaiSanPhamLabel;
            System.Windows.Forms.Label tenLoaiSanPhamLabel;
            this.quanLySanPham = new _2001215640_DinhThiTuyetChinh_KT02.QuanLySanPham();
            this.loaiSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiSanPhamTableAdapter = new _2001215640_DinhThiTuyetChinh_KT02.QuanLySanPhamTableAdapters.LoaiSanPhamTableAdapter();
            this.tableAdapterManager = new _2001215640_DinhThiTuyetChinh_KT02.QuanLySanPhamTableAdapters.TableAdapterManager();
            this.loaiSanPhamBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.loaiSanPhamBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.loaiSanPhamDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiSanPhamTextBox = new System.Windows.Forms.TextBox();
            this.tenLoaiSanPhamTextBox = new System.Windows.Forms.TextBox();
            maLoaiSanPhamLabel = new System.Windows.Forms.Label();
            tenLoaiSanPhamLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSanPhamBindingNavigator)).BeginInit();
            this.loaiSanPhamBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSanPhamDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // quanLySanPham
            // 
            this.quanLySanPham.DataSetName = "QuanLySanPham";
            this.quanLySanPham.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiSanPhamBindingSource
            // 
            this.loaiSanPhamBindingSource.DataMember = "LoaiSanPham";
            this.loaiSanPhamBindingSource.DataSource = this.quanLySanPham;
            // 
            // loaiSanPhamTableAdapter
            // 
            this.loaiSanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiTietPhieuNhapTableAdapter = null;
            this.tableAdapterManager.LoaiSanPhamTableAdapter = this.loaiSanPhamTableAdapter;
            this.tableAdapterManager.NhaCungCapTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.SanPhamTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = _2001215640_DinhThiTuyetChinh_KT02.QuanLySanPhamTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // loaiSanPhamBindingNavigator
            // 
            this.loaiSanPhamBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.loaiSanPhamBindingNavigator.BindingSource = this.loaiSanPhamBindingSource;
            this.loaiSanPhamBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.loaiSanPhamBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.loaiSanPhamBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.loaiSanPhamBindingNavigatorSaveItem});
            this.loaiSanPhamBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.loaiSanPhamBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.loaiSanPhamBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.loaiSanPhamBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.loaiSanPhamBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.loaiSanPhamBindingNavigator.Name = "loaiSanPhamBindingNavigator";
            this.loaiSanPhamBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.loaiSanPhamBindingNavigator.Size = new System.Drawing.Size(718, 25);
            this.loaiSanPhamBindingNavigator.TabIndex = 0;
            this.loaiSanPhamBindingNavigator.Text = "bindingNavigator1";
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
            // loaiSanPhamBindingNavigatorSaveItem
            // 
            this.loaiSanPhamBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loaiSanPhamBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("loaiSanPhamBindingNavigatorSaveItem.Image")));
            this.loaiSanPhamBindingNavigatorSaveItem.Name = "loaiSanPhamBindingNavigatorSaveItem";
            this.loaiSanPhamBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.loaiSanPhamBindingNavigatorSaveItem.Text = "Save Data";
            this.loaiSanPhamBindingNavigatorSaveItem.Click += new System.EventHandler(this.loaiSanPhamBindingNavigatorSaveItem_Click);
            // 
            // loaiSanPhamDataGridView
            // 
            this.loaiSanPhamDataGridView.AutoGenerateColumns = false;
            this.loaiSanPhamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loaiSanPhamDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.loaiSanPhamDataGridView.DataSource = this.loaiSanPhamBindingSource;
            this.loaiSanPhamDataGridView.Location = new System.Drawing.Point(193, 194);
            this.loaiSanPhamDataGridView.Name = "loaiSanPhamDataGridView";
            this.loaiSanPhamDataGridView.Size = new System.Drawing.Size(272, 220);
            this.loaiSanPhamDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaLoaiSanPham";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaLoaiSanPham";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenLoaiSanPham";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenLoaiSanPham";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // maLoaiSanPhamLabel
            // 
            maLoaiSanPhamLabel.AutoSize = true;
            maLoaiSanPhamLabel.Location = new System.Drawing.Point(216, 85);
            maLoaiSanPhamLabel.Name = "maLoaiSanPhamLabel";
            maLoaiSanPhamLabel.Size = new System.Drawing.Size(100, 13);
            maLoaiSanPhamLabel.TabIndex = 2;
            maLoaiSanPhamLabel.Text = "Ma Loai San Pham:";
            // 
            // maLoaiSanPhamTextBox
            // 
            this.maLoaiSanPhamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loaiSanPhamBindingSource, "MaLoaiSanPham", true));
            this.maLoaiSanPhamTextBox.Location = new System.Drawing.Point(326, 82);
            this.maLoaiSanPhamTextBox.Name = "maLoaiSanPhamTextBox";
            this.maLoaiSanPhamTextBox.Size = new System.Drawing.Size(100, 20);
            this.maLoaiSanPhamTextBox.TabIndex = 3;
            // 
            // tenLoaiSanPhamLabel
            // 
            tenLoaiSanPhamLabel.AutoSize = true;
            tenLoaiSanPhamLabel.Location = new System.Drawing.Point(216, 111);
            tenLoaiSanPhamLabel.Name = "tenLoaiSanPhamLabel";
            tenLoaiSanPhamLabel.Size = new System.Drawing.Size(104, 13);
            tenLoaiSanPhamLabel.TabIndex = 4;
            tenLoaiSanPhamLabel.Text = "Ten Loai San Pham:";
            // 
            // tenLoaiSanPhamTextBox
            // 
            this.tenLoaiSanPhamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loaiSanPhamBindingSource, "TenLoaiSanPham", true));
            this.tenLoaiSanPhamTextBox.Location = new System.Drawing.Point(326, 108);
            this.tenLoaiSanPhamTextBox.Name = "tenLoaiSanPhamTextBox";
            this.tenLoaiSanPhamTextBox.Size = new System.Drawing.Size(100, 20);
            this.tenLoaiSanPhamTextBox.TabIndex = 5;
            // 
            // frmLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 459);
            this.Controls.Add(maLoaiSanPhamLabel);
            this.Controls.Add(this.maLoaiSanPhamTextBox);
            this.Controls.Add(tenLoaiSanPhamLabel);
            this.Controls.Add(this.tenLoaiSanPhamTextBox);
            this.Controls.Add(this.loaiSanPhamDataGridView);
            this.Controls.Add(this.loaiSanPhamBindingNavigator);
            this.Name = "frmLoaiSanPham";
            this.Text = "frmLoaiSanPham";
            this.Load += new System.EventHandler(this.frmLoaiSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLySanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSanPhamBindingNavigator)).EndInit();
            this.loaiSanPhamBindingNavigator.ResumeLayout(false);
            this.loaiSanPhamBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSanPhamDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuanLySanPham quanLySanPham;
        private System.Windows.Forms.BindingSource loaiSanPhamBindingSource;
        private QuanLySanPhamTableAdapters.LoaiSanPhamTableAdapter loaiSanPhamTableAdapter;
        private QuanLySanPhamTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator loaiSanPhamBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton loaiSanPhamBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView loaiSanPhamDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox maLoaiSanPhamTextBox;
        private System.Windows.Forms.TextBox tenLoaiSanPhamTextBox;
    }
}