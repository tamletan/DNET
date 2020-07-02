namespace _3layers
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
            this.sorttxt = new System.Windows.Forms.ComboBox();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sortbutton = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            this.showbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.birthtxt = new System.Windows.Forms.DateTimePicker();
            this.genderlabel = new System.Windows.Forms.GroupBox();
            this.femalelabel = new System.Windows.Forms.RadioButton();
            this.malelabel = new System.Windows.Forms.RadioButton();
            this.khoatxt = new System.Windows.Forms.ComboBox();
            this.khoalabel = new System.Windows.Forms.Label();
            this.dtblabel = new System.Windows.Forms.Label();
            this.dtbtxt = new System.Windows.Forms.TextBox();
            this.birthlabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.mssvlabel = new System.Windows.Forms.Label();
            this.mssvtxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.genderlabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sorttxt
            // 
            this.sorttxt.FormattingEnabled = true;
            this.sorttxt.Location = new System.Drawing.Point(620, 319);
            this.sorttxt.Name = "sorttxt";
            this.sorttxt.Size = new System.Drawing.Size(160, 21);
            this.sorttxt.TabIndex = 63;
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(620, 229);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(160, 20);
            this.searchtxt.TabIndex = 62;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(585, 177);
            this.dataGridView1.TabIndex = 61;
            // 
            // sortbutton
            // 
            this.sortbutton.Location = new System.Drawing.Point(660, 349);
            this.sortbutton.Name = "sortbutton";
            this.sortbutton.Size = new System.Drawing.Size(80, 25);
            this.sortbutton.TabIndex = 60;
            this.sortbutton.Text = "Sort";
            this.sortbutton.UseVisualStyleBackColor = true;
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(660, 259);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(80, 25);
            this.searchbutton.TabIndex = 59;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            // 
            // showbutton
            // 
            this.showbutton.Location = new System.Drawing.Point(690, 179);
            this.showbutton.Name = "showbutton";
            this.showbutton.Size = new System.Drawing.Size(80, 25);
            this.showbutton.TabIndex = 58;
            this.showbutton.Text = "Show";
            this.showbutton.UseVisualStyleBackColor = true;
            this.showbutton.Click += new System.EventHandler(this.showbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(690, 139);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(80, 25);
            this.deletebutton.TabIndex = 57;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(690, 99);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(80, 25);
            this.updatebutton.TabIndex = 56;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = true;
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(690, 59);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(80, 25);
            this.addbutton.TabIndex = 55;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            // 
            // birthtxt
            // 
            this.birthtxt.Location = new System.Drawing.Point(115, 126);
            this.birthtxt.Name = "birthtxt";
            this.birthtxt.Size = new System.Drawing.Size(200, 20);
            this.birthtxt.TabIndex = 49;
            // 
            // genderlabel
            // 
            this.genderlabel.Controls.Add(this.femalelabel);
            this.genderlabel.Controls.Add(this.malelabel);
            this.genderlabel.Location = new System.Drawing.Point(23, 158);
            this.genderlabel.Name = "genderlabel";
            this.genderlabel.Size = new System.Drawing.Size(164, 49);
            this.genderlabel.TabIndex = 54;
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
            // khoatxt
            // 
            this.khoatxt.FormattingEnabled = true;
            this.khoatxt.Location = new System.Drawing.Point(408, 51);
            this.khoatxt.Name = "khoatxt";
            this.khoatxt.Size = new System.Drawing.Size(200, 21);
            this.khoatxt.TabIndex = 51;
            // 
            // khoalabel
            // 
            this.khoalabel.AutoSize = true;
            this.khoalabel.Location = new System.Drawing.Point(346, 53);
            this.khoalabel.Name = "khoalabel";
            this.khoalabel.Size = new System.Drawing.Size(37, 13);
            this.khoalabel.TabIndex = 50;
            this.khoalabel.Text = "KHOA";
            // 
            // dtblabel
            // 
            this.dtblabel.AutoSize = true;
            this.dtblabel.Location = new System.Drawing.Point(346, 93);
            this.dtblabel.Name = "dtblabel";
            this.dtblabel.Size = new System.Drawing.Size(29, 13);
            this.dtblabel.TabIndex = 52;
            this.dtblabel.Text = "DTB";
            // 
            // dtbtxt
            // 
            this.dtbtxt.Location = new System.Drawing.Point(408, 90);
            this.dtbtxt.Name = "dtbtxt";
            this.dtbtxt.Size = new System.Drawing.Size(200, 20);
            this.dtbtxt.TabIndex = 53;
            // 
            // birthlabel
            // 
            this.birthlabel.AutoSize = true;
            this.birthlabel.Location = new System.Drawing.Point(20, 133);
            this.birthlabel.Name = "birthlabel";
            this.birthlabel.Size = new System.Drawing.Size(28, 13);
            this.birthlabel.TabIndex = 48;
            this.birthlabel.Text = "Birth";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(20, 93);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(35, 13);
            this.namelabel.TabIndex = 46;
            this.namelabel.Text = "Name";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(115, 90);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(200, 20);
            this.nametxt.TabIndex = 47;
            // 
            // mssvlabel
            // 
            this.mssvlabel.AutoSize = true;
            this.mssvlabel.Location = new System.Drawing.Point(20, 54);
            this.mssvlabel.Name = "mssvlabel";
            this.mssvlabel.Size = new System.Drawing.Size(37, 13);
            this.mssvlabel.TabIndex = 44;
            this.mssvlabel.Text = "MSSV";
            // 
            // mssvtxt
            // 
            this.mssvtxt.Location = new System.Drawing.Point(115, 51);
            this.mssvtxt.Name = "mssvtxt";
            this.mssvtxt.Size = new System.Drawing.Size(200, 20);
            this.mssvtxt.TabIndex = 45;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.genderlabel.ResumeLayout(false);
            this.genderlabel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sorttxt;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button sortbutton;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Button showbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.DateTimePicker birthtxt;
        private System.Windows.Forms.GroupBox genderlabel;
        private System.Windows.Forms.RadioButton femalelabel;
        private System.Windows.Forms.RadioButton malelabel;
        private System.Windows.Forms.ComboBox khoatxt;
        private System.Windows.Forms.Label khoalabel;
        private System.Windows.Forms.Label dtblabel;
        private System.Windows.Forms.TextBox dtbtxt;
        private System.Windows.Forms.Label birthlabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label mssvlabel;
        private System.Windows.Forms.TextBox mssvtxt;
    }
}

