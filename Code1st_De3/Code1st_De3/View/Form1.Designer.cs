namespace Code1st_De2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MuonTraBT = new System.Windows.Forms.Button();
            this.DocGiaBT = new System.Windows.Forms.Button();
            this.SachBT = new System.Windows.Forms.Button();
            this.NhanVienBT = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddBT = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(671, 388);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // MuonTraBT
            // 
            this.MuonTraBT.Location = new System.Drawing.Point(692, 9);
            this.MuonTraBT.Name = "MuonTraBT";
            this.MuonTraBT.Size = new System.Drawing.Size(163, 35);
            this.MuonTraBT.TabIndex = 1;
            this.MuonTraBT.Text = "Mượn Trả";
            this.MuonTraBT.UseVisualStyleBackColor = true;
            this.MuonTraBT.Click += new System.EventHandler(this.Show_Click);
            // 
            // DocGiaBT
            // 
            this.DocGiaBT.Location = new System.Drawing.Point(692, 60);
            this.DocGiaBT.Name = "DocGiaBT";
            this.DocGiaBT.Size = new System.Drawing.Size(163, 35);
            this.DocGiaBT.TabIndex = 2;
            this.DocGiaBT.Text = "Độc Giả";
            this.DocGiaBT.UseVisualStyleBackColor = true;
            this.DocGiaBT.Click += new System.EventHandler(this.DocGiaBT_Click);
            // 
            // SachBT
            // 
            this.SachBT.Location = new System.Drawing.Point(692, 111);
            this.SachBT.Name = "SachBT";
            this.SachBT.Size = new System.Drawing.Size(163, 35);
            this.SachBT.TabIndex = 3;
            this.SachBT.Text = "Sách";
            this.SachBT.UseVisualStyleBackColor = true;
            this.SachBT.Click += new System.EventHandler(this.SachBT_Click);
            // 
            // NhanVienBT
            // 
            this.NhanVienBT.Location = new System.Drawing.Point(692, 164);
            this.NhanVienBT.Name = "NhanVienBT";
            this.NhanVienBT.Size = new System.Drawing.Size(163, 35);
            this.NhanVienBT.TabIndex = 4;
            this.NhanVienBT.Text = "Nhân Viên";
            this.NhanVienBT.UseVisualStyleBackColor = true;
            this.NhanVienBT.Click += new System.EventHandler(this.NhanVienBT_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(15, 412);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(163, 35);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // AddBT
            // 
            this.AddBT.Location = new System.Drawing.Point(184, 412);
            this.AddBT.Name = "AddBT";
            this.AddBT.Size = new System.Drawing.Size(163, 35);
            this.AddBT.TabIndex = 6;
            this.AddBT.Text = "Thêm";
            this.AddBT.UseVisualStyleBackColor = true;
            this.AddBT.Click += new System.EventHandler(this.AddBT_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mượn Trả",
            "Đọc Giả",
            "Sách",
            "Nhân Viên"});
            this.comboBox1.Location = new System.Drawing.Point(353, 412);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 455);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AddBT);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.NhanVienBT);
            this.Controls.Add(this.SachBT);
            this.Controls.Add(this.DocGiaBT);
            this.Controls.Add(this.MuonTraBT);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button MuonTraBT;
        private System.Windows.Forms.Button DocGiaBT;
        private System.Windows.Forms.Button SachBT;
        private System.Windows.Forms.Button NhanVienBT;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddBT;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

