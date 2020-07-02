namespace QLGV
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
            this.searchtext = new System.Windows.Forms.TextBox();
            this.DVDTlabel = new System.Windows.Forms.Label();
            this.CSlabel = new System.Windows.Forms.Label();
            this.DVDTbox = new System.Windows.Forms.ComboBox();
            this.CSbox = new System.Windows.Forms.ComboBox();
            this.sortbox = new System.Windows.Forms.ComboBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.sortbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.showtbtn = new System.Windows.Forms.Button();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.editbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchtext
            // 
            this.searchtext.Location = new System.Drawing.Point(122, 395);
            this.searchtext.Name = "searchtext";
            this.searchtext.Size = new System.Drawing.Size(200, 20);
            this.searchtext.TabIndex = 39;
            // 
            // DVDTlabel
            // 
            this.DVDTlabel.AutoSize = true;
            this.DVDTlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DVDTlabel.Location = new System.Drawing.Point(343, 9);
            this.DVDTlabel.Name = "DVDTlabel";
            this.DVDTlabel.Size = new System.Drawing.Size(100, 17);
            this.DVDTlabel.TabIndex = 38;
            this.DVDTlabel.Text = "Đơn vị đào tạo";
            // 
            // CSlabel
            // 
            this.CSlabel.AutoSize = true;
            this.CSlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CSlabel.Location = new System.Drawing.Point(12, 9);
            this.CSlabel.Name = "CSlabel";
            this.CSlabel.Size = new System.Drawing.Size(46, 17);
            this.CSlabel.TabIndex = 37;
            this.CSlabel.Text = "Cơ Sở";
            // 
            // DVDTbox
            // 
            this.DVDTbox.FormattingEnabled = true;
            this.DVDTbox.Location = new System.Drawing.Point(340, 28);
            this.DVDTbox.Name = "DVDTbox";
            this.DVDTbox.Size = new System.Drawing.Size(121, 21);
            this.DVDTbox.TabIndex = 36;
            // 
            // CSbox
            // 
            this.CSbox.FormattingEnabled = true;
            this.CSbox.Location = new System.Drawing.Point(9, 29);
            this.CSbox.Name = "CSbox";
            this.CSbox.Size = new System.Drawing.Size(121, 21);
            this.CSbox.TabIndex = 35;
            this.CSbox.SelectedIndexChanged += new System.EventHandler(this.CSbox_SelectedIndexChanged);
            // 
            // sortbox
            // 
            this.sortbox.FormattingEnabled = true;
            this.sortbox.Location = new System.Drawing.Point(566, 394);
            this.sortbox.Name = "sortbox";
            this.sortbox.Size = new System.Drawing.Size(180, 21);
            this.sortbox.TabIndex = 34;
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(9, 392);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 33;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // sortbtn
            // 
            this.sortbtn.Location = new System.Drawing.Point(450, 392);
            this.sortbtn.Name = "sortbtn";
            this.sortbtn.Size = new System.Drawing.Size(75, 23);
            this.sortbtn.TabIndex = 32;
            this.sortbtn.Text = "Sort";
            this.sortbtn.UseVisualStyleBackColor = true;
            this.sortbtn.Click += new System.EventHandler(this.sortbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(671, 351);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 31;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(247, 351);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 30;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // showtbtn
            // 
            this.showtbtn.Location = new System.Drawing.Point(9, 351);
            this.showtbtn.Name = "showtbtn";
            this.showtbtn.Size = new System.Drawing.Size(75, 23);
            this.showtbtn.TabIndex = 27;
            this.showtbtn.Text = "Show";
            this.showtbtn.UseVisualStyleBackColor = true;
            this.showtbtn.Click += new System.EventHandler(this.showtbtn_Click);
            // 
            // DataView
            // 
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Location = new System.Drawing.Point(9, 72);
            this.DataView.Name = "DataView";
            this.DataView.Size = new System.Drawing.Size(737, 264);
            this.DataView.TabIndex = 26;
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(450, 351);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(75, 23);
            this.editbtn.TabIndex = 40;
            this.editbtn.Text = "Edit";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 427);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.searchtext);
            this.Controls.Add(this.DVDTlabel);
            this.Controls.Add(this.CSlabel);
            this.Controls.Add(this.DVDTbox);
            this.Controls.Add(this.CSbox);
            this.Controls.Add(this.sortbox);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.sortbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.showtbtn);
            this.Controls.Add(this.DataView);
            this.Name = "Form1";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchtext;
        private System.Windows.Forms.Label DVDTlabel;
        private System.Windows.Forms.Label CSlabel;
        private System.Windows.Forms.ComboBox DVDTbox;
        private System.Windows.Forms.ComboBox CSbox;
        private System.Windows.Forms.ComboBox sortbox;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button sortbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button showtbtn;
        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.Button editbtn;
    }
}

