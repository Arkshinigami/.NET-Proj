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
    public partial class Dashboard : Form
    {
        Functions Con;
        public Dashboard()
        {
            InitializeComponent();
            Con= new Functions();
            CountStudents();
            CountDepartment();
            CountMaleSt();
        }
        private void CountStudents()
        {

            string query = "select count(*) as Stud from StudentTb1";
            foreach (DataRow dr in Con.GetData(query).Rows)
            {
                Studentlb4.Text = dr["Stud"].ToString();
            }
          
        }
        private void CountDepartment()
        {

            string query = "select count(*) as Dep from DepartmentTb1";
            foreach (DataRow dr in Con.GetData(query).Rows)
            {
                deptnumlb.Text = dr["Dep"].ToString();
            }
        
        }
        private void CountMaleSt()
        {
            string Gen = "Male";
            string query = "select count(*) as Male from StudentTb1 where StGen='{0}'";
            query = string.Format(query, Gen);
            foreach (DataRow dr in Con.GetData(query).Rows)
            {
                Malestudlb.Text = dr["Male"].ToString();
            }

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void studentlb3_Click(object sender, EventArgs e)
        {
            Students obj = new Students();
            obj.Show();
            this.Close();
        }

        private void deptlb3_Click(object sender, EventArgs e)
        {
            Department obj = new Department();
            obj.Show();
            this.Close();
        }

        private void logoutlb3_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
