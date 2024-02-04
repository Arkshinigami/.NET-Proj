namespace Student_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (Uname.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else if (Uname.Text == "Admin" || Password.Text == "Password")
            {
                Students Obj=new Students();
                Obj.Show();
                this.Hide();    
            }else
            {
                MessageBox.Show("Wrong User Name or Password!!!");
                Uname.Text = "";
                Password.Text = "";
            }
        }
    }
}