namespace KTGK
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.txtMaDP = new System.Windows.Forms.TextBox();
            this.txtTenDP = new System.Windows.Forms.TextBox();
            this.txtSoCa = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSapXep = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNguyCo = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvDiaPhuong = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.colMDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCaNhiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiaPhuong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtSoCa);
            this.groupBox1.Controls.Add(this.txtTenDP);
            this.groupBox1.Controls.Add(this.txtMaDP);
            this.groupBox1.Controls.Add(this.cboTrangThai);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 355);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin địa phương";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Địa Phương";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Địa Phương";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số ca nhiễm mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trạng Thái";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(216, 236);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(217, 33);
            this.cboTrangThai.TabIndex = 4;
            // 
            // txtMaDP
            // 
            this.txtMaDP.Location = new System.Drawing.Point(216, 50);
            this.txtMaDP.Name = "txtMaDP";
            this.txtMaDP.Size = new System.Drawing.Size(217, 31);
            this.txtMaDP.TabIndex = 5;
            // 
            // txtTenDP
            // 
            this.txtTenDP.Location = new System.Drawing.Point(216, 116);
            this.txtTenDP.Name = "txtTenDP";
            this.txtTenDP.Size = new System.Drawing.Size(217, 31);
            this.txtTenDP.TabIndex = 6;
            // 
            // txtSoCa
            // 
            this.txtSoCa.Location = new System.Drawing.Point(216, 179);
            this.txtSoCa.Name = "txtSoCa";
            this.txtSoCa.Size = new System.Drawing.Size(217, 31);
            this.txtSoCa.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(216, 284);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 52);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(326, 284);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 52);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1424, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSapXep,
            this.menuNguyCo,
            this.xuấtBáoCáoToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(149, 38);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // menuSapXep
            // 
            this.menuSapXep.Name = "menuSapXep";
            this.menuSapXep.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuSapXep.Size = new System.Drawing.Size(517, 44);
            this.menuSapXep.Text = "Sắp xếp theo số ca nhiễm";
            this.menuSapXep.Click += new System.EventHandler(this.menuSapXep_Click);
            // 
            // menuNguyCo
            // 
            this.menuNguyCo.Name = "menuNguyCo";
            this.menuNguyCo.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuNguyCo.Size = new System.Drawing.Size(517, 44);
            this.menuNguyCo.Text = "Các địa phương nhóm nguy cơ";
            this.menuNguyCo.Click += new System.EventHandler(this.menuNguyCo_Click);
            // 
            // xuấtBáoCáoToolStripMenuItem
            // 
            this.xuấtBáoCáoToolStripMenuItem.Name = "xuấtBáoCáoToolStripMenuItem";
            this.xuấtBáoCáoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.xuấtBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(517, 44);
            this.xuấtBáoCáoToolStripMenuItem.Text = "Xuất báo cáo";
            this.xuấtBáoCáoToolStripMenuItem.Click += new System.EventHandler(this.xuấtBáoCáoToolStripMenuItem_Click);
            // 
            // dgvDiaPhuong
            // 
            this.dgvDiaPhuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiaPhuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMDP,
            this.colTenDP,
            this.colCaNhiem,
            this.colTrangThai});
            this.dgvDiaPhuong.Location = new System.Drawing.Point(517, 129);
            this.dgvDiaPhuong.Name = "dgvDiaPhuong";
            this.dgvDiaPhuong.RowHeadersWidth = 82;
            this.dgvDiaPhuong.RowTemplate.Height = 33;
            this.dgvDiaPhuong.Size = new System.Drawing.Size(895, 409);
            this.dgvDiaPhuong.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(396, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(474, 55);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tình Hình Dịch Covid";
            // 
            // colMDP
            // 
            this.colMDP.HeaderText = "Mã Địa Phương";
            this.colMDP.MinimumWidth = 10;
            this.colMDP.Name = "colMDP";
            this.colMDP.Width = 200;
            // 
            // colTenDP
            // 
            this.colTenDP.HeaderText = "Tên Địa Phương";
            this.colTenDP.MinimumWidth = 10;
            this.colTenDP.Name = "colTenDP";
            this.colTenDP.Width = 200;
            // 
            // colCaNhiem
            // 
            this.colCaNhiem.HeaderText = "Ca Nhiễm";
            this.colCaNhiem.MinimumWidth = 10;
            this.colCaNhiem.Name = "colCaNhiem";
            this.colCaNhiem.Width = 200;
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.MinimumWidth = 10;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 565);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvDiaPhuong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Quản Lí Tình Hình";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiaPhuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenDP;
        private System.Windows.Forms.TextBox txtMaDP;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoCa;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSapXep;
        private System.Windows.Forms.ToolStripMenuItem menuNguyCo;
        private System.Windows.Forms.ToolStripMenuItem xuấtBáoCáoToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvDiaPhuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaNhiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}

