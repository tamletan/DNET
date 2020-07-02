using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectDB
{
    public partial class Form1 : Form
    {
        DBHelp helper;
        public Form1()
        {
            InitializeComponent();
            helper = new DBHelp();
            helper.data.ConnectionString = @"Data Source=DESKTOP-BT9TDDG;Initial Catalog=WinFormDB;Integrated Security=True";
            BoxKHOA();
            BoxSort();
            mssvtxt.Enabled = false;
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = data;
            //cmd.CommandText = "select count(*) from Student";
            //string query = "select count(*) from Student";
            //string query = "insert into Faculty values('Dien tu vien thong')";
            //string query = "select MSSV,Sname,Fname,DTB from dbo.Faculty INNER JOIN dbo.Student ON Faculty.FID=Student.FID";
            //SqlCommand cmd = new SqlCommand(query, data);
            //SqlDataReader r;
            //SqlDataAdapter da = new SqlDataAdapter(query, data); //mac dinh dua vao selectcommand
            //DataSet ds = new DataSet();

            //data.Open();
            //int n = (int)cmd.ExecuteScalar();
            //MessageBox.Show(n.ToString());
            //cmd.ExecuteNonQuery();
            //r = cmd.ExecuteReader();
            //while(r.Read())
            //{
            //    khoatxt.Items.Add(r["Fname"]);
            //}
            //da.Fill(dataSet: ds, srcTable: "KHOA");
            //data.Close();
            //dataGridView1.DataSource = ds.Tables["KHOA"];
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            clean();
            showGridView();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            string name = nametxt.Text;
            string birth = birthtxt.Value.ToString();
            string gender = (malelabel.Checked) ? "1" : "0";
            string dtb = dtbtxt.Text;
            string fname = khoatxt.SelectedItem.ToString();
            string facultyID = helper.GetTable("select * from dbo.Faculty where Fname='" + fname + "'").Rows[0][0].ToString();

            //string query = "insert into Student values('" + name + "','" + birth + "'," + facultyID + "," + dtb + "," + gender + ")";

            string query = "insert into Student values(@name,@birth,@fid,@dtb,@gender)";
            SqlCommand cmd = new SqlCommand(query, helper.data);

            //cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            //cmd.Parameters.Add("@birth", SqlDbType.NVarChar).Value = birth;
            //cmd.Parameters.Add("@fid", SqlDbType.NVarChar).Value = facultyID;
            //cmd.Parameters.Add("@dtb", SqlDbType.NVarChar).Value = dtb;
            //cmd.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender;

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@birth", birth);
            cmd.Parameters.AddWithValue("@fid", facultyID);
            cmd.Parameters.AddWithValue("@dtb", dtb);
            cmd.Parameters.AddWithValue("@gender", gender);

            helper.ExcuteDB(cmd);

            showGridView();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            string mssv = mssvtxt.Text;
            string name = nametxt.Text;
            string birth = birthtxt.Value.ToString();
            string gender = (malelabel.Checked) ? "1" : "0";
            string dtb = dtbtxt.Text;
            string fname = khoatxt.SelectedItem.ToString();
            string facultyID = helper.GetTable("select * from dbo.Faculty where Fname='" + fname + "'").Rows[0][0].ToString();

            //string query = "update Student set Sname='" + name + "',Sbirth='" + birth + "',FID=" + facultyID + ",DTB=" + dtb + ",Gender=" + gender + " from Student where MSSV=" + mssv;
            
            string query = "update Student set Sname=@name,Sbirth=@birth,FID=@fid,DTB=@dtb,Gender=@gender from Student where MSSV=@mssv";
            SqlCommand cmd = new SqlCommand(query, helper.data);

            cmd.Parameters.AddWithValue("@mssv", mssv);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@birth", birth);
            cmd.Parameters.AddWithValue("@fid", facultyID);
            cmd.Parameters.AddWithValue("@dtb", dtb);
            cmd.Parameters.AddWithValue("@gender", gender);

            helper.ExcuteDB(cmd);

            showGridView();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            //string mssv = mssvtxt.Text;
            foreach(DataGridViewRow i in dataGridView1.SelectedRows)
            {
                string mssv = i.Cells["MSSV"].Value.ToString();
                string query = "delete from Student where MSSV = "+mssv;
                helper.ExcuteDB(query);
            }
            showGridView();
            clean();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string mssv = dataGridView1.SelectedRows[0].Cells["MSSV"].Value.ToString();
            string query = "select * from Student where MSSV=" + mssv;
            DataTable dt = helper.GetTable(query);
            mssvtxt.Text = dt.Rows[0]["MSSV"].ToString();
            nametxt.Text = dt.Rows[0]["Sname"].ToString();
            birthtxt.Value = Convert.ToDateTime(dt.Rows[0]["Sbirth"]);
            dtbtxt.Text = dt.Rows[0]["DTB"].ToString();
            FindKHOA(dt.Rows[0]["FID"].ToString());
            if (Convert.ToBoolean(dt.Rows[0]["Gender"])) malelabel.Checked = true;
            else femalelabel.Checked = true;
            //int j = 0;
            //for (int i = 0; i < khoatxt.Items.Count; i++)
            //{
            //    khoatxt.SelectedItem = khoatxt.Items[i];
            //    string value = khoatxt.SelectedValue.ToString();
            //    if (value == dt.Rows[0]["FID"])
            //        j = khoatxt.SelectedIndex;
            //}
            //khoatxt.SelectedItem = khoatxt.Items[j];
        }

        private void BoxKHOA()
        {
            string query = "select Fname from Faculty";
            SqlDataAdapter da = new SqlDataAdapter(query, helper.data);
            DataTable dt = new DataTable();
            helper.data.Open();
            da.Fill(dt);
            helper.data.Close();
            DataRow row = dt.NewRow();
            //row["FID"] = -1;
            row["Fname"] = "--select--";
            dt.Rows.InsertAt(row, 0);
            foreach (DataRow i in dt.Rows)
            {
                khoatxt.Items.Add(i["Fname"]);
            }
            khoatxt.SelectedItem = khoatxt.Items[0];
            //khoatxt.DataSource = dt;
            //khoatxt.DisplayMember = "Fname";
            //khoatxt.ValueMember = "FID";
        }

        private void BoxSort()
        {
            sorttxt.Items.Add("--select--");
            sorttxt.Items.Add("MSSV");
            sorttxt.Items.Add("Sname");
            sorttxt.Items.Add("Sbirth");
            sorttxt.Items.Add("Fname");
            sorttxt.Items.Add("DTB");
            sorttxt.Items.Add("Gender");
            sorttxt.SelectedItem = sorttxt.Items[0];
        }

        private void showGridView()
        {
            string query1 = "select MSSV,Sname,Sbirth,Fname,DTB,Gender from dbo.Faculty INNER JOIN dbo.Student ON Faculty.FID=Student.FID";
            dataGridView1.DataSource = helper.GetTable(query1);
        }

        private void FindKHOA(string id)
        {
            string query = "select Fname from Faculty where FID = "+id;
            //string result = helper.GetTable(query).Rows[0][0].ToString();

            SqlCommand cmd = new SqlCommand(query, helper.data);
            helper.data.Open();
            string result = cmd.ExecuteScalar().ToString();
            helper.data.Close();

            khoatxt.SelectedItem = khoatxt.Items[khoatxt.Items.IndexOf(result)];
        }

        private void clean()
        {
            mssvtxt.Text = null;
            nametxt.Text = null;
            birthtxt.Value = DateTime.Today;
            dtbtxt.Text = null;
            malelabel.Checked = false;
            femalelabel.Checked = false;
            khoatxt.SelectedItem = khoatxt.Items[0];
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            string search = searchtxt.Text;
            string query = "select MSSV,Sname,Sbirth,Fname,DTB,Gender from dbo.Faculty INNER JOIN dbo.Student ON Faculty.FID=Student.FID WHERE Student.Sname = '" + search+"'";
            dataGridView1.DataSource = helper.GetTable(query);
        }

        private void sortbutton_Click(object sender, EventArgs e)
        {
            string sort = sorttxt.SelectedItem.ToString();
            string query = "select MSSV,Sname,Sbirth,Fname,DTB,Gender from dbo.Faculty INNER JOIN dbo.Student ON Faculty.FID=Student.FID order by " + sort;
            dataGridView1.DataSource = helper.GetTable(query);
        }
    }
}
