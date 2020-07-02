using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCSVC
{
    
    public partial class Form1 : Form
    {
        public delegate void UpdateRoom(int A);
        public static event UpdateRoom SignalTrans;
        BLL_Room BLLRoom;
        public Form1()
        {
            InitializeComponent();
            string ConnectionSource = @"Data Source=DESKTOP-NANVVB6\SQLEXPRESS;Initial Catalog=CoSoVatChat;Integrated Security=True";
            BLLRoom = new BLL_Room(ConnectionSource);
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            Form2 F = new Form2();
            F.Show();
            F.ST += new Form2.SignalTransfer(RefreshDGV);
        }
        private void RefreshDGV(bool sig)
        {
            if(sig)
            {
                DGView.DataSource = null;
                DGView.DataSource = BLLRoom.BLLGetRoomList();               
            }
        }
        private void SortCBBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ShowButton_Click(object sender, EventArgs e)
        {
            this.RefreshDGV(true);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult DR = new DialogResult();
            DR = MessageBox.Show("Ban that su muon xoa ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DR == DialogResult.Yes)
            {
                foreach(DataGridViewRow i in DGView.SelectedRows)
                {
                    BLLRoom.BLLDelete(Convert.ToInt32(i.Cells[0].Value));
                }
            }
            this.RefreshDGV(true);
        }
        
        private void DGView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RID = Convert.ToInt32(DGView.SelectedRows[0].Cells["RoomID"].Value);
            Form2 F = new Form2();
            F.Show();
            if (SignalTrans != null) SignalTrans.Invoke(RID);
            this.RefreshDGV(true);
        }

        private void StageBox_TextChanged(object sender, EventArgs e)
        {
            /*if (DGView.DataSource != null)
            {
                List<Room> Temp = new List<Room>();
                foreach(DataGridViewRow i in DGView.Rows)
                {
                    if(i.Cells["Stage"].Value == StageBox.SelectedItem)
                    {
                        Temp.Add(i);
                    }
                }
            }
            else
            {}*/        
                ClassBox.SelectedIndex = 0;
                DGView.DataSource = null;
                DGView.DataSource = BLLRoom.StageSearch(Convert.ToInt32(StageBox.SelectedItem));
            
        }
        private void ClassBox_TextChanged(object sender, EventArgs e)
        { 
                StageBox.SelectedIndex = 0;
                int Class = 0;
                switch (ClassBox.SelectedItem)
                {
                    case "Phong Hoc":
                        Class = 1;
                        break;
                    case "Phong Hop":
                        Class = 2;
                        break;
                    case "Phong Thuc Hanh":
                        Class = 3;
                        break;
                    case "Kho":
                        Class = 4;
                        break;
                    case "Phong Hanh Chinh":
                        Class = 5;
                        break;
                }
                DGView.DataSource = null;
                DGView.DataSource = BLLRoom.StageSearch(Class);           
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DGView.DataSource = null;
            DGView.DataSource =  BLLRoom.Search(SearchBox.Text);
        }

        private void DGView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
