using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code1st_De2
{
    public partial class Form1 : Form
    {
        public static BLL bll { get; set; }
        int trigger { get; set; }
        public delegate void SignalTrans(int ID, bool signal);
        public static event SignalTrans ST;
        public Form1()
        {
            InitializeComponent();
            bll = new BLL();
            trigger = 0;
        }

        private void Show_Click(object sender, EventArgs e)
        {
            trigger = 1;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bll.show();
        }

        private void DocGiaBT_Click(object sender, EventArgs e)
        {
            trigger = 2;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bll.showDocGia();
        }

        private void SachBT_Click(object sender, EventArgs e)
        {
            trigger = 3;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bll.showSach();
        }

        private void NhanVienBT_Click(object sender, EventArgs e)
        {
            trigger = 4;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bll.showNhanVien();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int ID = 0;
            switch(trigger)
            {
                case 1:
                    {
                        MuonTraForm Form = new MuonTraForm();
                        Form.Show();
                        ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"]);
                        ST.Invoke(ID,true);
                    }break;
                case 2:
                    {
                        DocGiaForm Form = new DocGiaForm();
                        Form.Show();
                        ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"]);
                        ST.Invoke(ID, true);
                    }
                    break;
                case 3:
                    {
                        SachForm Form = new SachForm();
                        Form.Show();
                        ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                        ST.Invoke(ID, true);
                    }
                    break;
                case 4:
                    {
                        NhanVienForm Form = new NhanVienForm();
                        Form.Show();
                        ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"]);
                        ST.Invoke(ID, true);
                    }
                    break;
                default:
                    break;
            }
        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        MuonTraForm Form = new MuonTraForm();
                        Form.Show();
                    }
                    break;
                case 1:
                    {
                        DocGiaForm Form = new DocGiaForm();
                        Form.Show();
                    }
                    break;
                case 2:
                    {
                        SachForm Form = new SachForm();
                        Form.Show();
                    }
                    break;
                case 3:
                    {
                        NhanVienForm Form = new NhanVienForm();
                        Form.Show();
                    }
                    break;

            }
        }
    }
}
