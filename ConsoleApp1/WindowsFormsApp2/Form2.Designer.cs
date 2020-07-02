namespace WindowsFormsApp2
{
    partial class Form2
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
            this.mssvlabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.birthlabel = new System.Windows.Forms.Label();
            this.khoalabel = new System.Windows.Forms.Label();
            this.genderlabel = new System.Windows.Forms.Label();
            this.dtblabel = new System.Windows.Forms.Label();
            this.mssvtxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.birthtxt = new System.Windows.Forms.TextBox();
            this.khoatxt = new System.Windows.Forms.TextBox();
            this.gendertxt = new System.Windows.Forms.TextBox();
            this.dtbtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mssvlabel
            // 
            this.mssvlabel.AutoSize = true;
            this.mssvlabel.Location = new System.Drawing.Point(30, 23);
            this.mssvlabel.Name = "mssvlabel";
            this.mssvlabel.Size = new System.Drawing.Size(37, 13);
            this.mssvlabel.TabIndex = 0;
            this.mssvlabel.Text = "MSSV";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(30, 93);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(35, 13);
            this.namelabel.TabIndex = 1;
            this.namelabel.Text = "Name";
            // 
            // birthlabel
            // 
            this.birthlabel.AutoSize = true;
            this.birthlabel.Location = new System.Drawing.Point(30, 163);
            this.birthlabel.Name = "birthlabel";
            this.birthlabel.Size = new System.Drawing.Size(28, 13);
            this.birthlabel.TabIndex = 2;
            this.birthlabel.Text = "Birth";
            // 
            // khoalabel
            // 
            this.khoalabel.AutoSize = true;
            this.khoalabel.Location = new System.Drawing.Point(330, 23);
            this.khoalabel.Name = "khoalabel";
            this.khoalabel.Size = new System.Drawing.Size(37, 13);
            this.khoalabel.TabIndex = 3;
            this.khoalabel.Text = "KHOA";
            // 
            // genderlabel
            // 
            this.genderlabel.AutoSize = true;
            this.genderlabel.Location = new System.Drawing.Point(330, 93);
            this.genderlabel.Name = "genderlabel";
            this.genderlabel.Size = new System.Drawing.Size(42, 13);
            this.genderlabel.TabIndex = 4;
            this.genderlabel.Text = "Gender";
            // 
            // dtblabel
            // 
            this.dtblabel.AutoSize = true;
            this.dtblabel.Location = new System.Drawing.Point(330, 163);
            this.dtblabel.Name = "dtblabel";
            this.dtblabel.Size = new System.Drawing.Size(29, 13);
            this.dtblabel.TabIndex = 5;
            this.dtblabel.Text = "DTB";
            // 
            // mssvtxt
            // 
            this.mssvtxt.Location = new System.Drawing.Point(80, 20);
            this.mssvtxt.Name = "mssvtxt";
            this.mssvtxt.ReadOnly = true;
            this.mssvtxt.Size = new System.Drawing.Size(200, 20);
            this.mssvtxt.TabIndex = 6;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(80, 90);
            this.nametxt.Name = "nametxt";
            this.nametxt.ReadOnly = true;
            this.nametxt.Size = new System.Drawing.Size(200, 20);
            this.nametxt.TabIndex = 7;
            // 
            // birthtxt
            // 
            this.birthtxt.Location = new System.Drawing.Point(80, 160);
            this.birthtxt.Name = "birthtxt";
            this.birthtxt.ReadOnly = true;
            this.birthtxt.Size = new System.Drawing.Size(200, 20);
            this.birthtxt.TabIndex = 8;
            // 
            // khoatxt
            // 
            this.khoatxt.Location = new System.Drawing.Point(380, 20);
            this.khoatxt.Name = "khoatxt";
            this.khoatxt.ReadOnly = true;
            this.khoatxt.Size = new System.Drawing.Size(200, 20);
            this.khoatxt.TabIndex = 9;
            // 
            // gendertxt
            // 
            this.gendertxt.Location = new System.Drawing.Point(380, 90);
            this.gendertxt.Name = "gendertxt";
            this.gendertxt.ReadOnly = true;
            this.gendertxt.Size = new System.Drawing.Size(200, 20);
            this.gendertxt.TabIndex = 10;
            // 
            // dtbtxt
            // 
            this.dtbtxt.Location = new System.Drawing.Point(380, 160);
            this.dtbtxt.Name = "dtbtxt";
            this.dtbtxt.ReadOnly = true;
            this.dtbtxt.Size = new System.Drawing.Size(200, 20);
            this.dtbtxt.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 231);
            this.Controls.Add(this.dtbtxt);
            this.Controls.Add(this.gendertxt);
            this.Controls.Add(this.khoatxt);
            this.Controls.Add(this.birthtxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.mssvtxt);
            this.Controls.Add(this.dtblabel);
            this.Controls.Add(this.genderlabel);
            this.Controls.Add(this.khoalabel);
            this.Controls.Add(this.birthlabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.mssvlabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mssvlabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label birthlabel;
        private System.Windows.Forms.Label khoalabel;
        private System.Windows.Forms.Label genderlabel;
        private System.Windows.Forms.Label dtblabel;
        private System.Windows.Forms.TextBox mssvtxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox birthtxt;
        private System.Windows.Forms.TextBox khoatxt;
        private System.Windows.Forms.TextBox gendertxt;
        private System.Windows.Forms.TextBox dtbtxt;
    }
}