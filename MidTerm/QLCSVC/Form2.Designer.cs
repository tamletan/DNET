namespace QLCSVC
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
            this.okbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.maptext = new System.Windows.Forms.TextBox();
            this.tenptext = new System.Windows.Forms.TextBox();
            this.maplabel = new System.Windows.Forms.Label();
            this.tenplabel = new System.Windows.Forms.Label();
            this.tanglabel = new System.Windows.Forms.Label();
            this.loaiplabel = new System.Windows.Forms.Label();
            this.tthailabel = new System.Windows.Forms.Label();
            this.ngaylabel = new System.Windows.Forms.Label();
            this.tangbox = new System.Windows.Forms.ComboBox();
            this.loaipbox = new System.Windows.Forms.ComboBox();
            this.ngaypicker = new System.Windows.Forms.DateTimePicker();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // okbutton
            // 
            this.okbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.okbutton.Location = new System.Drawing.Point(75, 300);
            this.okbutton.Name = "okbutton";
            this.okbutton.Size = new System.Drawing.Size(75, 30);
            this.okbutton.TabIndex = 1;
            this.okbutton.Text = "OK";
            this.okbutton.UseVisualStyleBackColor = true;
            this.okbutton.Click += new System.EventHandler(this.okbutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cancelbutton.Location = new System.Drawing.Point(375, 300);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 30);
            this.cancelbutton.TabIndex = 2;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // maptext
            // 
            this.maptext.Location = new System.Drawing.Point(235, 30);
            this.maptext.Name = "maptext";
            this.maptext.Size = new System.Drawing.Size(200, 20);
            this.maptext.TabIndex = 1;
            // 
            // tenptext
            // 
            this.tenptext.Location = new System.Drawing.Point(235, 70);
            this.tenptext.Name = "tenptext";
            this.tenptext.Size = new System.Drawing.Size(200, 20);
            this.tenptext.TabIndex = 3;
            // 
            // maplabel
            // 
            this.maplabel.AutoSize = true;
            this.maplabel.BackColor = System.Drawing.SystemColors.Control;
            this.maplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.maplabel.Location = new System.Drawing.Point(100, 30);
            this.maplabel.Name = "maplabel";
            this.maplabel.Size = new System.Drawing.Size(72, 17);
            this.maplabel.TabIndex = 0;
            this.maplabel.Text = "Ma Phong";
            // 
            // tenplabel
            // 
            this.tenplabel.AutoSize = true;
            this.tenplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tenplabel.Location = new System.Drawing.Point(100, 70);
            this.tenplabel.Name = "tenplabel";
            this.tenplabel.Size = new System.Drawing.Size(78, 17);
            this.tenplabel.TabIndex = 2;
            this.tenplabel.Text = "Ten Phong";
            // 
            // tanglabel
            // 
            this.tanglabel.AutoSize = true;
            this.tanglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tanglabel.Location = new System.Drawing.Point(100, 110);
            this.tanglabel.Name = "tanglabel";
            this.tanglabel.Size = new System.Drawing.Size(41, 17);
            this.tanglabel.TabIndex = 4;
            this.tanglabel.Text = "Tang";
            // 
            // loaiplabel
            // 
            this.loaiplabel.AutoSize = true;
            this.loaiplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.loaiplabel.Location = new System.Drawing.Point(100, 150);
            this.loaiplabel.Name = "loaiplabel";
            this.loaiplabel.Size = new System.Drawing.Size(80, 17);
            this.loaiplabel.TabIndex = 6;
            this.loaiplabel.Text = "Loai Phong";
            // 
            // tthailabel
            // 
            this.tthailabel.AutoSize = true;
            this.tthailabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tthailabel.Location = new System.Drawing.Point(100, 190);
            this.tthailabel.Name = "tthailabel";
            this.tthailabel.Size = new System.Drawing.Size(78, 17);
            this.tthailabel.TabIndex = 8;
            this.tthailabel.Text = "Trang Thai";
            // 
            // ngaylabel
            // 
            this.ngaylabel.AutoSize = true;
            this.ngaylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ngaylabel.Location = new System.Drawing.Point(100, 230);
            this.ngaylabel.Name = "ngaylabel";
            this.ngaylabel.Size = new System.Drawing.Size(100, 17);
            this.ngaylabel.TabIndex = 10;
            this.ngaylabel.Text = "Ngay Su Dung";
            // 
            // tangbox
            // 
            this.tangbox.FormattingEnabled = true;
            this.tangbox.Location = new System.Drawing.Point(235, 110);
            this.tangbox.Name = "tangbox";
            this.tangbox.Size = new System.Drawing.Size(200, 21);
            this.tangbox.TabIndex = 5;
            // 
            // loaipbox
            // 
            this.loaipbox.FormattingEnabled = true;
            this.loaipbox.Location = new System.Drawing.Point(235, 150);
            this.loaipbox.Name = "loaipbox";
            this.loaipbox.Size = new System.Drawing.Size(200, 21);
            this.loaipbox.TabIndex = 7;
            // 
            // ngaypicker
            // 
            this.ngaypicker.Location = new System.Drawing.Point(235, 230);
            this.ngaypicker.Name = "ngaypicker";
            this.ngaypicker.Size = new System.Drawing.Size(200, 20);
            this.ngaypicker.TabIndex = 11;
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radio1.Location = new System.Drawing.Point(235, 188);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(81, 21);
            this.radio1.TabIndex = 12;
            this.radio1.TabStop = true;
            this.radio1.Text = "Su Dung";
            this.radio1.UseVisualStyleBackColor = true;
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radio2.Location = new System.Drawing.Point(324, 188);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(126, 21);
            this.radio2.TabIndex = 13;
            this.radio2.TabStop = true;
            this.radio2.Text = "Dang Sua Chua";
            this.radio2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 362);
            this.Controls.Add(this.radio2);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.radio1);
            this.Controls.Add(this.okbutton);
            this.Controls.Add(this.ngaypicker);
            this.Controls.Add(this.loaipbox);
            this.Controls.Add(this.maplabel);
            this.Controls.Add(this.tangbox);
            this.Controls.Add(this.maptext);
            this.Controls.Add(this.ngaylabel);
            this.Controls.Add(this.tenptext);
            this.Controls.Add(this.tthailabel);
            this.Controls.Add(this.tenplabel);
            this.Controls.Add(this.loaiplabel);
            this.Controls.Add(this.tanglabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button okbutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.TextBox maptext;
        private System.Windows.Forms.TextBox tenptext;
        private System.Windows.Forms.Label maplabel;
        private System.Windows.Forms.Label tenplabel;
        private System.Windows.Forms.Label tanglabel;
        private System.Windows.Forms.Label loaiplabel;
        private System.Windows.Forms.Label tthailabel;
        private System.Windows.Forms.Label ngaylabel;
        private System.Windows.Forms.ComboBox tangbox;
        private System.Windows.Forms.ComboBox loaipbox;
        private System.Windows.Forms.DateTimePicker ngaypicker;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.RadioButton radio2;
    }
}