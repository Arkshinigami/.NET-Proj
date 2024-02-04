using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management
{
    public partial class Students : Form
    {
        Functions Con;
        public Students()
        {
            InitializeComponent();
            Con = new Functions();
            ShowStudents();
            GetDeptment();
        }
        private void ShowStudents()
        {
            string query = "select * from StudentTb1";
            StudentList.DataSource = Con.GetData(query);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void GetDeptment()
        {
            string query = "select * from DepartmentTb1";
            DepCb.DisplayMember = Con.GetData(query).Columns["DepName"].ToString();
            DepCb.ValueMember = Con.GetData(query).Columns["DepId"].ToString();
            DepCb.DataSource = Con.GetData(query);
        }

        private void Students_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void clear()
        {
            stnametb.Text = "";
            stphonetb.Text = "";
            stparenttb.Text = "";
            staddtb.Text = "";
            gencb.SelectedIndex = -1;

        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (stnametb.Text == "" || stphonetb.Text == "" || stparenttb.Text == "" || staddtb.Text == "" || DepCb.SelectedIndex == -1 || gencb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    string TName = stnametb.Text;
                    string TGender = gencb.SelectedItem.ToString();
                    string Phone = stphonetb.Text;
                    string Parent = stparenttb.Text;
                    string Address = staddtb.Text;
                    int Dep = Convert.ToInt32(DepCb.SelectedValue.ToString());
                    string Query = "insert into StudentTb1 values('{0}','{1}','{2}','{3}','{4}',{5})";
                    Query = string.Format(Query, TName, TGender, Phone, Parent, Address, Dep);
                    Con.SETDATA(Query);
                    ShowStudents();
                    MessageBox.Show("Student Added!!!");
                    clear();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }
        }
        int key = 0;
        private void StudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            stnametb.Text = StudentList.SelectedRows[0].Cells[1].Value.ToString();
            gencb.SelectedItem = StudentList.SelectedRows[0].Cells[2].Value.ToString();
            stphonetb.Text = StudentList.SelectedRows[0].Cells[3].Value.ToString();
            stparenttb.Text = StudentList.SelectedRows[0].Cells[4].Value.ToString();
            staddtb.Text = StudentList.SelectedRows[0].Cells[5].Value.ToString();
            DepCb.SelectedValue = StudentList.SelectedRows[0].Cells[6].Value.ToString();
            if (stnametb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(StudentList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {

            if (stnametb.Text == "" || stphonetb.Text == "" || stparenttb.Text == "" || staddtb.Text == "" || DepCb.SelectedIndex == -1 || gencb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    string TName = stnametb.Text;
                    string TGender = gencb.SelectedItem.ToString();
                    string Phone = stphonetb.Text;
                    string Parent = stparenttb.Text;
                    string Address = staddtb.Text;
                    int Dep = Convert.ToInt32(DepCb.SelectedValue.ToString());
                    string Query = "Update StudentTb1 set StName= '{0}',StGen= '{1}',StPhone= '{2}',StParent= '{3}',StAdd= '{4}',StDepartment= {5} where StCode={6}";
                    Query = string.Format(Query, TName, TGender, Phone, Parent, Address, Dep, key);
                    Con.SETDATA(Query);
                    ShowStudents();
                    MessageBox.Show("Student Updated!!!");
                    clear();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {

            if (key == 0)
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    string TName = stnametb.Text;
                    string TGender = gencb.SelectedItem.ToString();
                    string Phone = stphonetb.Text;
                    string Parent = stparenttb.Text;
                    string Address = staddtb.Text;
                    int Dep = Convert.ToInt32(DepCb.SelectedValue.ToString());
                    string Query = "Delete from StudentTb1 where StCode={0}";
                    Query = string.Format(Query, key);
                    Con.SETDATA(Query);
                    ShowStudents();
                    MessageBox.Show("Student Deleted!!!");
                    clear();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void Deptbtn_Click(object sender, EventArgs e)
        {
            Department obj = new Department();
            obj.Show();
            this.Close();
        }

        private void DashboardLb1_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Close();
        }

        private void logoutlb1_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
