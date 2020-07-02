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
    
    public partial class Form2 : Form
    {
        BLL_Room BLLRoom;
        bool Trigger = true;
        public delegate void SignalTransfer(bool A);
        public event SignalTransfer ST;
        public Form2()
        {
            InitializeComponent();
            IDBox.Enabled = false;
            string ConnectionSource = @"Data Source=DESKTOP-NANVVB6\SQLEXPRESS;Initial Catalog=CoSoVatChat;Integrated Security=True";
            BLLRoom = new BLL_Room(ConnectionSource);
            Form1.SignalTrans += new Form1.UpdateRoom(UpdateLoad);
            LoadComboBox();
        }
        private void LoadComboBox()
        {
            ClassBox.Items.Clear();
            DataTable temp = BLLRoom.GetRoomTable();
            DataRow row = temp.NewRow();
            row["RoomClass"] = 0;
            row["Descript"] = "--select--";
            temp.Rows.InsertAt(row, 0);
            ClassBox.DataSource = temp;
            ClassBox.DisplayMember = "Descript";
            ClassBox.ValueMember = "RoomClass";
        }
        private void UpdateLoad(int id)
        {
            Room A = new Room();
            A = BLLRoom.BLLGetRoom(id);
            IDBox.Text = A.RoomID.ToString();
            NameBox.Text = A.RoomName;
            CapBox.Text = A.Capacity.ToString();
            StageBox.SelectedItem = A.Stage.ToString();
            switch(A.RoomLevel)
            {
                case 1:
                    ClassBox.SelectedItem = "Phong Hoc";
                    break;
                case 2:
                    ClassBox.SelectedItem = "Phong Hop";
                    break;
                case 3:
                    ClassBox.SelectedItem = "Phong Thuc Hanh";
                    break;
                case 4:
                    ClassBox.SelectedItem = "Phong Kho";
                    break;
                case 5:
                    ClassBox.SelectedItem = "Phong Hanh Chinh";
                    break;
            }
            dateTimePicker1.Value = A.dayUse;   
            if (A.Stat == true) checkBox1.Checked = true;
            else checkBox1.Checked = false;
            Trigger = false;
        }
        private void OKButton_Click(object sender, EventArgs e)
        {               
            if (NameBox.Text.Length == 0 ||
                    StageBox.SelectedItem.ToString().Length == 0 ||
                    ClassBox.SelectedItem.ToString().Length == 0 ||
                    CapBox.Text.Length == 0)
                    MessageBox.Show("Vui long nhap het!!!");
            else
                {
                                       
                    int id=1;                
                    int Class = Convert.ToInt32(ClassBox.SelectedValue.ToString());               
                    if (IDBox.Text != "") id = Convert.ToInt32(IDBox.Text);
                    Room A = new Room
                    {
                        RoomID = id,
                        RoomName = NameBox.Text,
                        RoomLevel = Class,
                        Stage = Convert.ToInt32(StageBox.SelectedItem),
                        Capacity = Convert.ToInt32(CapBox.Text),
                        Stat = checkBox1.Checked == true,
                        dayUse = dateTimePicker1.Value
                    };
                    if (Trigger) BLLRoom.BLLAdd(A);
                    else BLLRoom.Update(A);
                    ST.Invoke(true);
                    Close();
                    
                }           
        }
    }
}
