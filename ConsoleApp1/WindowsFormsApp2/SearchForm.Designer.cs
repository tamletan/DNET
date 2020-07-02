namespace WindowsFormsApp2
{
    partial class SearchForm
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
            this.birthtxt = new System.Windows.Forms.DateTimePicker();
            this.genderlabel = new System.Windows.Forms.GroupBox();
            this.femalelabel = new System.Windows.Forms.RadioButton();
            this.malelabel = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.khoatxt = new System.Windows.Forms.ComboBox();
            this.khoalabel = new System.Windows.Forms.Label();
            this.dtblabel = new System.Windows.Forms.Label();
            this.dtbtxt = new System.Windows.Forms.TextBox();
            this.birthlabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.mssvlabel = new System.Windows.Forms.Label();
            this.mssvtxt = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.searchbutton = new System.Windows.Forms.Button();
            this.genderlabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // birthtxt
            // 
            this.birthtxt.Location = new System.Drawing.Point(135, 102);
            this.birthtxt.Name = "birthtxt";
            this.birthtxt.Size = new System.Drawing.Size(200, 20);
            this.birthtxt.TabIndex = 19;
            // 
            // genderlabel
            // 
            this.genderlabel.Controls.Add(this.femalelabel);
            this.genderlabel.Controls.Add(this.malelabel);
            this.genderlabel.Location = new System.Drawing.Point(43, 134);
            this.genderlabel.Name = "genderlabel";
            this.genderlabel.Size = new System.Drawing.Size(164, 49);
            this.genderlabel.TabIndex = 24;
            this.genderlabel.TabStop = false;
            this.genderlabel.Text = "Gender";
            // 
            // femalelabel
            // 
            this.femalelabel.AutoSize = true;
            this.femalelabel.Location = new System.Drawing.Point(96, 19);
            this.femalelabel.Name = "femalelabel";
            this.femalelabel.Size = new System.Drawing.Size(59, 17);
            this.femalelabel.TabIndex = 12;
            this.femalelabel.TabStop = true;
            this.femalelabel.Text = "Female";
            this.femalelabel.UseVisualStyleBackColor = true;
            // 
            // malelabel
            // 
            this.malelabel.AutoSize = true;
            this.malelabel.Location = new System.Drawing.Point(18, 19);
            this.malelabel.Name = "malelabel";
            this.malelabel.Size = new System.Drawing.Size(48, 17);
            this.malelabel.TabIndex = 11;
            this.malelabel.TabStop = true;
            this.malelabel.Text = "Male";
            this.malelabel.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(369, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(259, 43);
            this.listBox1.TabIndex = 25;
            // 
            // khoatxt
            // 
            this.khoatxt.FormattingEnabled = true;
            this.khoatxt.Location = new System.Drawing.Point(428, 27);
            this.khoatxt.Name = "khoatxt";
            this.khoatxt.Size = new System.Drawing.Size(200, 21);
            this.khoatxt.TabIndex = 21;
            // 
            // khoalabel
            // 
            this.khoalabel.AutoSize = true;
            this.khoalabel.Location = new System.Drawing.Point(366, 29);
            this.khoalabel.Name = "khoalabel";
            this.khoalabel.Size = new System.Drawing.Size(37, 13);
            this.khoalabel.TabIndex = 20;
            this.khoalabel.Text = "KHOA";
            // 
            // dtblabel
            // 
            this.dtblabel.AutoSize = true;
            this.dtblabel.Location = new System.Drawing.Point(366, 69);
            this.dtblabel.Name = "dtblabel";
            this.dtblabel.Size = new System.Drawing.Size(29, 13);
            this.dtblabel.TabIndex = 22;
            this.dtblabel.Text = "DTB";
            // 
            // dtbtxt
            // 
            this.dtbtxt.Location = new System.Drawing.Point(428, 66);
            this.dtbtxt.Name = "dtbtxt";
            this.dtbtxt.Size = new System.Drawing.Size(200, 20);
            this.dtbtxt.TabIndex = 23;
            // 
            // birthlabel
            // 
            this.birthlabel.AutoSize = true;
            this.birthlabel.Location = new System.Drawing.Point(40, 109);
            this.birthlabel.Name = "birthlabel";
            this.birthlabel.Size = new System.Drawing.Size(28, 13);
            this.birthlabel.TabIndex = 18;
            this.birthlabel.Text = "Birth";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(40, 69);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(35, 13);
            this.namelabel.TabIndex = 16;
            this.namelabel.Text = "Name";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(135, 66);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(200, 20);
            this.nametxt.TabIndex = 17;
            // 
            // mssvlabel
            // 
            this.mssvlabel.AutoSize = true;
            this.mssvlabel.Location = new System.Drawing.Point(40, 30);
            this.mssvlabel.Name = "mssvlabel";
            this.mssvlabel.Size = new System.Drawing.Size(37, 13);
            this.mssvlabel.TabIndex = 14;
            this.mssvlabel.Text = "MSSV";
            // 
            // mssvtxt
            // 
            this.mssvtxt.Location = new System.Drawing.Point(135, 27);
            this.mssvtxt.Name = "mssvtxt";
            this.mssvtxt.Size = new System.Drawing.Size(200, 20);
            this.mssvtxt.TabIndex = 15;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(43, 199);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(585, 207);
            this.dataGridView2.TabIndex = 26;
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(679, 27);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(80, 59);
            this.searchbutton.TabIndex = 27;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.birthtxt);
            this.Controls.Add(this.genderlabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.khoatxt);
            this.Controls.Add(this.khoalabel);
            this.Controls.Add(this.dtblabel);
            this.Controls.Add(this.dtbtxt);
            this.Controls.Add(this.birthlabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.mssvlabel);
            this.Controls.Add(this.mssvtxt);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.genderlabel.ResumeLayout(false);
            this.genderlabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker birthtxt;
        private System.Windows.Forms.GroupBox genderlabel;
        private System.Windows.Forms.RadioButton femalelabel;
        private System.Windows.Forms.RadioButton malelabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox khoatxt;
        private System.Windows.Forms.Label khoalabel;
        private System.Windows.Forms.Label dtblabel;
        private System.Windows.Forms.TextBox dtbtxt;
        private System.Windows.Forms.Label birthlabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label mssvlabel;
        private System.Windows.Forms.TextBox mssvtxt;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button searchbutton;
    }
}