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
    public partial class Department : Form
    {
        Functions Con;
        public Department()
        {
            InitializeComponent();
            Con = new Functions();
            ShowDep();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void ShowDep()
        {
            string query = "select * from DepartmentTb1";
            DeptList.DataSource = Con.GetData(query);
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (DeptNameTb.Text == "" || DetailsTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    string DName = DeptNameTb.Text;
                    string Details = DetailsTb.Text;
                    string Query = "insert into DepartmentTb1 values('{0}','{1}')";
                    Query = string.Format(Query, DName, Details);
                    Con.SETDATA(Query);
                    ShowDep();
                    MessageBox.Show("Department Added!!!");
                    clear();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }
        }

        int key = 0;
        private void DeptList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DeptNameTb.Text = DeptList.SelectedRows[0].Cells[1].Value.ToString();
            DetailsTb.Text = DeptList.SelectedRows[0].Cells[1].Value.ToString();
            if (DeptNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DeptList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (DeptNameTb.Text == "" || DetailsTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    string DName = DeptNameTb.Text;
                    string Details = DetailsTb.Text;
                    string Query = "update DepartmentTb1 set DepName='{0}',DepDetails='{1}' where DepId = '{2}'";
                    Query = string.Format(Query, DName, Details, key);
                    Con.SETDATA(Query);
                    ShowDep();
                    MessageBox.Show("Department Updated!!!");
                    clear();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }
        }
        private void clear()
        {
            DeptNameTb.Text = "";
            DetailsTb.Text = "";
        }
        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select a department!!");
            }
            else
            {
                try
                {
                    string DName = DeptNameTb.Text;
                    string Details = DetailsTb.Text;
                    string Query = "Delete from DepartmentTb1 where DepId = '{0}'";
                    Query = string.Format(Query, key);
                    Con.SETDATA(Query);
                    ShowDep();
                    MessageBox.Show("Department Deleted!!!");
                    clear();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Close();
        }
        //studentlb2 down here
        private void label11_Click(object sender, EventArgs e)
        {
            Students obj = new Students();
            obj.Show();
            this.Close();
        }

        private void Dashboardlb2_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
