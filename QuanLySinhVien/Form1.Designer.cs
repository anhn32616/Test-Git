namespace QuanLySinhVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbLopSH = new System.Windows.Forms.ComboBox();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.dgvListSV = new System.Windows.Forms.DataGridView();
            this.btShow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.btSort = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp SH:";
            // 
            // cbLopSH
            // 
            this.cbLopSH.FormattingEnabled = true;
            this.cbLopSH.Location = new System.Drawing.Point(131, 51);
            this.cbLopSH.Name = "cbLopSH";
            this.cbLopSH.Size = new System.Drawing.Size(121, 24);
            this.cbLopSH.TabIndex = 2;
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(671, 51);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(137, 22);
            this.txbSearch.TabIndex = 3;
            // 
            // dgvListSV
            // 
            this.dgvListSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListSV.Location = new System.Drawing.Point(28, 41);
            this.dgvListSV.Name = "dgvListSV";
            this.dgvListSV.ReadOnly = true;
            this.dgvListSV.RowHeadersVisible = false;
            this.dgvListSV.RowHeadersWidth = 30;
            this.dgvListSV.RowTemplate.Height = 24;
            this.dgvListSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListSV.Size = new System.Drawing.Size(812, 275);
            this.dgvListSV.TabIndex = 4;
            // 
            // btShow
            // 
            this.btShow.Location = new System.Drawing.Point(28, 348);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(90, 50);
            this.btShow.TabIndex = 5;
            this.btShow.Text = "Show";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSort);
            this.groupBox1.Controls.Add(this.btSort);
            this.groupBox1.Controls.Add(this.btDel);
            this.groupBox1.Controls.Add(this.btEdit);
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Controls.Add(this.dgvListSV);
            this.groupBox1.Controls.Add(this.btShow);
            this.groupBox1.Location = new System.Drawing.Point(73, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 429);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách SV";
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "MSSV tăng dần",
            "MSSV giảm dần",
            "Tên từ A->Z",
            "Tên từ Z->A",
            "Ngày sinh tăng dần",
            "Ngày sinh giảm dần"});
            this.cbSort.Location = new System.Drawing.Point(642, 362);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(198, 24);
            this.cbSort.TabIndex = 10;
            // 
            // btSort
            // 
            this.btSort.Location = new System.Drawing.Point(527, 348);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(90, 50);
            this.btSort.TabIndex = 9;
            this.btSort.Text = "Sort";
            this.btSort.UseVisualStyleBackColor = true;
            this.btSort.Click += new System.EventHandler(this.btSort_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(401, 348);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(90, 50);
            this.btDel.TabIndex = 8;
            this.btDel.Text = "Del";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(275, 348);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(90, 50);
            this.btEdit.TabIndex = 7;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(156, 348);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(90, 50);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(829, 43);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(84, 38);
            this.btSearch.TabIndex = 11;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 559);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.cbLopSH);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh Sách Sinh Viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLopSH;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.DataGridView dgvListSV;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Button btSort;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btSearch;
    }
}

