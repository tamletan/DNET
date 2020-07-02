namespace WindowsFormsApp2
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
            this.mssvtxt = new System.Windows.Forms.TextBox();
            this.mssvlabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.birthlabel = new System.Windows.Forms.Label();
            this.dtblabel = new System.Windows.Forms.Label();
            this.dtbtxt = new System.Windows.Forms.TextBox();
            this.khoalabel = new System.Windows.Forms.Label();
            this.khoatxt = new System.Windows.Forms.ComboBox();
            this.malelabel = new System.Windows.Forms.RadioButton();
            this.femalelabel = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.genderlabel = new System.Windows.Forms.GroupBox();
            this.birthtxt = new System.Windows.Forms.DateTimePicker();
            this.addbutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.showbutton = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            this.sortbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.sorttxt = new System.Windows.Forms.ComboBox();
            this.genderlabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mssvtxt
            // 
            this.mssvtxt.Location = new System.Drawing.Point(125, 12);
            this.mssvtxt.Name = "mssvtxt";
            this.mssvtxt.Size = new System.Drawing.Size(200, 20);
            this.mssvtxt.TabIndex = 1;
            // 
            // mssvlabel
            // 
            this.mssvlabel.AutoSize = true;
            this.mssvlabel.Location = new System.Drawing.Point(30, 15);
            this.mssvlabel.Name = "mssvlabel";
            this.mssvlabel.Size = new System.Drawing.Size(37, 13);
            this.mssvlabel.TabIndex = 0;
            this.mssvlabel.Text = "MSSV";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(30, 54);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(35, 13);
            this.namelabel.TabIndex = 2;
            this.namelabel.Text = "Name";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(125, 51);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(200, 20);
            this.nametxt.TabIndex = 3;
            // 
            // birthlabel
            // 
            this.birthlabel.AutoSize = true;
            this.birthlabel.Location = new System.Drawing.Point(30, 94);
            this.birthlabel.Name = "birthlabel";
            this.birthlabel.Size = new System.Drawing.Size(28, 13);
            this.birthlabel.TabIndex = 4;
            this.birthlabel.Text = "Birth";
            // 
            // dtblabel
            // 
            this.dtblabel.AutoSize = true;
            this.dtblabel.Location = new System.Drawing.Point(356, 54);
            this.dtblabel.Name = "dtblabel";
            this.dtblabel.Size = new System.Drawing.Size(29, 13);
            this.dtblabel.TabIndex = 8;
            this.dtblabel.Text = "DTB";
            // 
            // dtbtxt
            // 
            this.dtbtxt.Location = new System.Drawing.Point(418, 51);
            this.dtbtxt.Name = "dtbtxt";
            this.dtbtxt.Size = new System.Drawing.Size(200, 20);
            this.dtbtxt.TabIndex = 9;
            // 
            // khoalabel
            // 
            this.khoalabel.AutoSize = true;
            this.khoalabel.Location = new System.Drawing.Point(356, 14);
            this.khoalabel.Name = "khoalabel";
            this.khoalabel.Size = new System.Drawing.Size(37, 13);
            this.khoalabel.TabIndex = 6;
            this.khoalabel.Text = "KHOA";
            // 
            // khoatxt
            // 
            this.khoatxt.FormattingEnabled = true;
            this.khoatxt.Location = new System.Drawing.Point(418, 12);
            this.khoatxt.Name = "khoatxt";
            this.khoatxt.Size = new System.Drawing.Size(200, 21);
            this.khoatxt.TabIndex = 7;
            this.khoatxt.SelectedIndexChanged += new System.EventHandler(this.khoatxt_SelectedIndexChanged);
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(359, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(259, 43);
            this.listBox1.TabIndex = 13;
            // 
            // genderlabel
            // 
            this.genderlabel.Controls.Add(this.femalelabel);
            this.genderlabel.Controls.Add(this.malelabel);
            this.genderlabel.Location = new System.Drawing.Point(33, 119);
            this.genderlabel.Name = "genderlabel";
            this.genderlabel.Size = new System.Drawing.Size(164, 49);
            this.genderlabel.TabIndex = 10;
            this.genderlabel.TabStop = false;
            this.genderlabel.Text = "Gender";
            // 
            // birthtxt
            // 
            this.birthtxt.Location = new System.Drawing.Point(125, 87);
            this.birthtxt.Name = "birthtxt";
            this.birthtxt.Size = new System.Drawing.Size(200, 20);
            this.birthtxt.TabIndex = 5;
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(700, 20);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(80, 25);
            this.addbutton.TabIndex = 14;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(700, 60);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(80, 25);
            this.updatebutton.TabIndex = 15;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(700, 100);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(80, 25);
            this.deletebutton.TabIndex = 16;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // showbutton
            // 
            this.showbutton.Location = new System.Drawing.Point(700, 140);
            this.showbutton.Name = "showbutton";
            this.showbutton.Size = new System.Drawing.Size(80, 25);
            this.showbutton.TabIndex = 17;
            this.showbutton.Text = "Show";
            this.showbutton.UseVisualStyleBackColor = true;
            this.showbutton.Click += new System.EventHandler(this.showbutton_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(670, 220);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(80, 25);
            this.searchbutton.TabIndex = 18;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // sortbutton
            // 
            this.sortbutton.Location = new System.Drawing.Point(670, 310);
            this.sortbutton.Name = "sortbutton";
            this.sortbutton.Size = new System.Drawing.Size(80, 25);
            this.sortbutton.TabIndex = 19;
            this.sortbutton.Text = "Sort";
            this.sortbutton.UseVisualStyleBackColor = true;
            this.sortbutton.Click += new System.EventHandler(this.sortbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(585, 177);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(630, 190);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(160, 20);
            this.searchtxt.TabIndex = 21;
            // 
            // sorttxt
            // 
            this.sorttxt.FormattingEnabled = true;
            this.sorttxt.Location = new System.Drawing.Point(630, 280);
            this.sorttxt.Name = "sorttxt";
            this.sorttxt.Size = new System.Drawing.Size(160, 21);
            this.sorttxt.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 373);
            this.Controls.Add(this.sorttxt);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sortbutton);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.showbutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.addbutton);
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
            this.Name = "Form1";
            this.Text = "Information";
            this.genderlabel.ResumeLayout(false);
            this.genderlabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mssvtxt;
        private System.Windows.Forms.Label mssvlabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label birthlabel;
        private System.Windows.Forms.Label dtblabel;
        private System.Windows.Forms.TextBox dtbtxt;
        private System.Windows.Forms.Label khoalabel;
        private System.Windows.Forms.ComboBox khoatxt;
        private System.Windows.Forms.RadioButton malelabel;
        private System.Windows.Forms.RadioButton femalelabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox genderlabel;
        private System.Windows.Forms.DateTimePicker birthtxt;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button showbutton;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Button sortbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.ComboBox sorttxt;
    }
}

