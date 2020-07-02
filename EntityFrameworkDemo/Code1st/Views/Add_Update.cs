using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code1st
{
    public partial class Add_Update : Form
    {
        private bool signal;
        private int IDSV;
   
        public Add_Update()
        {
            InitializeComponent();
            
            LoadFalculty();
            this.signal = false;
            IDTxtBox.Enabled = false;
            Form1.ST += new Form1.SignalTransfer(LoadStudent);
        }
        private void LoadStudent(int IDSV,bool signal)
        {
            this.signal = signal;
            this.IDSV = IDSV;
            SinhVien A = Form1.BLLSV.LoadStudent(IDSV);
            NameTxtBox.Text = A.TenSV;
            ScoreTxtBox.Text = A.Diem.ToString();
            if (A.Gioitinh) MaleRB.Checked = true;
            else FemaleRB.Checked = true;
            FalcCBBox.SelectedValue = A.FID;
            dateTimePicker1.Value = A.Ngaysinh;           
        }
        private void LoadFalculty()
        {           
            FalcCBBox.DisplayMember = "TenKhoa";
            FalcCBBox.ValueMember = "ID";
            FalcCBBox.DataSource = Form1.BLLSV.ForCBBox();
        }
        private void OKButton_Click(object sender, EventArgs e)
        {
            SinhVien obj = new SinhVien
            {
                TenSV = NameTxtBox.Text,
                Diem = Convert.ToDouble(ScoreTxtBox.Text),
                FID = Convert.ToInt32(FalcCBBox.SelectedValue),
                Gioitinh = MaleRB.Checked == true,
                Ngaysinh = dateTimePicker1.Value
            };
            if (signal == false) Form1.BLLSV.Add(obj);
            else Form1.BLLSV.Update(obj,IDSV);
            Close();
        }
    }
}
