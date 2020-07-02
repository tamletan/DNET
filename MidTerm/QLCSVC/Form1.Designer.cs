namespace QLCSVC
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
            this.Data = new System.Windows.Forms.DataGridView();
            this.showbutton = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.delbutton = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            this.sortbutton = new System.Windows.Forms.Button();
            this.sortbox = new System.Windows.Forms.ComboBox();
            this.searchtext = new System.Windows.Forms.TextBox();
            this.tangbox = new System.Windows.Forms.ComboBox();
            this.loaipbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.SuspendLayout();
            // 
            // Data
            // 
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Location = new System.Drawing.Point(12, 12);
            this.Data.Name = "Data";
            this.Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data.Size = new System.Drawing.Size(630, 346);
            this.Data.TabIndex = 0;
            this.Data.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Data_RowHeaderMouseClick);
            // 
            // showbutton
            // 
            this.showbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.showbutton.Location = new System.Drawing.Point(12, 375);
            this.showbutton.Name = "showbutton";
            this.showbutton.Size = new System.Drawing.Size(75, 30);
            this.showbutton.TabIndex = 1;
            this.showbutton.Text = "Show";
            this.showbutton.UseVisualStyleBackColor = true;
            this.showbutton.Click += new System.EventHandler(this.showbutton_Click);
            // 
            // addbutton
            // 
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.addbutton.Location = new System.Drawing.Point(290, 375);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 30);
            this.addbutton.TabIndex = 2;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // delbutton
            // 
            this.delbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.delbutton.Location = new System.Drawing.Point(567, 375);
            this.delbutton.Name = "delbutton";
            this.delbutton.Size = new System.Drawing.Size(75, 30);
            this.delbutton.TabIndex = 3;
            this.delbutton.Text = "Delete";
            this.delbutton.UseVisualStyleBackColor = true;
            this.delbutton.Click += new System.EventHandler(this.delbutton_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchbutton.Location = new System.Drawing.Point(685, 220);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 30);
            this.searchbutton.TabIndex = 4;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // sortbutton
            // 
            this.sortbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sortbutton.Location = new System.Drawing.Point(685, 314);
            this.sortbutton.Name = "sortbutton";
            this.sortbutton.Size = new System.Drawing.Size(75, 30);
            this.sortbutton.TabIndex = 5;
            this.sortbutton.Text = "Sort";
            this.sortbutton.UseVisualStyleBackColor = true;
            this.sortbutton.Click += new System.EventHandler(this.sortbutton_Click);
            // 
            // sortbox
            // 
            this.sortbox.FormattingEnabled = true;
            this.sortbox.Location = new System.Drawing.Point(648, 280);
            this.sortbox.Name = "sortbox";
            this.sortbox.Size = new System.Drawing.Size(147, 21);
            this.sortbox.TabIndex = 6;
            // 
            // searchtext
            // 
            this.searchtext.Location = new System.Drawing.Point(648, 180);
            this.searchtext.Name = "searchtext";
            this.searchtext.Size = new System.Drawing.Size(147, 20);
            this.searchtext.TabIndex = 7;
            // 
            // tangbox
            // 
            this.tangbox.FormattingEnabled = true;
            this.tangbox.Location = new System.Drawing.Point(648, 60);
            this.tangbox.Name = "tangbox";
            this.tangbox.Size = new System.Drawing.Size(147, 21);
            this.tangbox.TabIndex = 8;
            this.tangbox.SelectedIndexChanged += new System.EventHandler(this.tangbox_SelectedIndexChanged);
            // 
            // loaipbox
            // 
            this.loaipbox.FormattingEnabled = true;
            this.loaipbox.Location = new System.Drawing.Point(648, 120);
            this.loaipbox.Name = "loaipbox";
            this.loaipbox.Size = new System.Drawing.Size(147, 21);
            this.loaipbox.TabIndex = 9;
            this.loaipbox.SelectedIndexChanged += new System.EventHandler(this.loaipbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(648, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(645, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Loai Phong";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loaipbox);
            this.Controls.Add(this.tangbox);
            this.Controls.Add(this.searchtext);
            this.Controls.Add(this.sortbox);
            this.Controls.Add(this.sortbutton);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.delbutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.showbutton);
            this.Controls.Add(this.Data);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Data;
        private System.Windows.Forms.Button showbutton;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button delbutton;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Button sortbutton;
        private System.Windows.Forms.ComboBox sortbox;
        private System.Windows.Forms.TextBox searchtext;
        private System.Windows.Forms.ComboBox tangbox;
        private System.Windows.Forms.ComboBox loaipbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

