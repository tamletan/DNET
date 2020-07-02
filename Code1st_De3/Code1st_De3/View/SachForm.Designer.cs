namespace Code1st_De2
{
    partial class SachForm
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
            this.NameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AuthorText = new System.Windows.Forms.TextBox();
            this.NXBText = new System.Windows.Forms.TextBox();
            this.PageText = new System.Windows.Forms.TextBox();
            this.QuantityText = new System.Windows.Forms.TextBox();
            this.LoaiCBBox = new System.Windows.Forms.ComboBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.XButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(106, 12);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(326, 20);
            this.NameText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tác Giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhà Xuất Bản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Loại Sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số Trang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số Lượng";
            // 
            // AuthorText
            // 
            this.AuthorText.Location = new System.Drawing.Point(106, 50);
            this.AuthorText.Name = "AuthorText";
            this.AuthorText.Size = new System.Drawing.Size(326, 20);
            this.AuthorText.TabIndex = 7;
            // 
            // NXBText
            // 
            this.NXBText.Location = new System.Drawing.Point(106, 94);
            this.NXBText.Name = "NXBText";
            this.NXBText.Size = new System.Drawing.Size(326, 20);
            this.NXBText.TabIndex = 8;
            // 
            // PageText
            // 
            this.PageText.Location = new System.Drawing.Point(106, 186);
            this.PageText.Name = "PageText";
            this.PageText.Size = new System.Drawing.Size(326, 20);
            this.PageText.TabIndex = 10;
            this.PageText.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // QuantityText
            // 
            this.QuantityText.Location = new System.Drawing.Point(106, 234);
            this.QuantityText.Name = "QuantityText";
            this.QuantityText.Size = new System.Drawing.Size(326, 20);
            this.QuantityText.TabIndex = 11;
            // 
            // LoaiCBBox
            // 
            this.LoaiCBBox.FormattingEnabled = true;
            this.LoaiCBBox.Location = new System.Drawing.Point(106, 139);
            this.LoaiCBBox.Name = "LoaiCBBox";
            this.LoaiCBBox.Size = new System.Drawing.Size(326, 21);
            this.LoaiCBBox.TabIndex = 12;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(49, 297);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(151, 54);
            this.OKButton.TabIndex = 13;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // XButton
            // 
            this.XButton.Location = new System.Drawing.Point(297, 297);
            this.XButton.Name = "XButton";
            this.XButton.Size = new System.Drawing.Size(151, 54);
            this.XButton.TabIndex = 14;
            this.XButton.Text = "Cancel";
            this.XButton.UseVisualStyleBackColor = true;
            this.XButton.Click += new System.EventHandler(this.XButton_Click);
            // 
            // SachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 388);
            this.Controls.Add(this.XButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.LoaiCBBox);
            this.Controls.Add(this.QuantityText);
            this.Controls.Add(this.PageText);
            this.Controls.Add(this.NXBText);
            this.Controls.Add(this.AuthorText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameText);
            this.Name = "SachForm";
            this.Text = "SachForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AuthorText;
        private System.Windows.Forms.TextBox NXBText;
        private System.Windows.Forms.TextBox PageText;
        private System.Windows.Forms.TextBox QuantityText;
        private System.Windows.Forms.ComboBox LoaiCBBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button XButton;
    }
}