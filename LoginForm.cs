using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Student_Submission_Tracker
{
    public partial class LoginForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=StudentSubmission;Integrated Security=True";

        public LoginForm()
        {
            InitializeComponent();
        }

        
        public string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha.ComputeHash(bytes);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                    sb.Append(b.ToString("x2"));

                return sb.ToString();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void login_Click(object sender, EventArgs e)
        {
            string hashedPassword = HashPassword(password.Text);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Username=@username AND Password=@password AND Role=@role";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", user_name.Text.Trim());
                
                cmd.Parameters.AddWithValue("@password", hashedPassword);
                cmd.Parameters.AddWithValue("@role", roleselector.Text);

                con.Open();
                int userFound = (int)cmd.ExecuteScalar();
                con.Close();

                if (userFound > 0)
                {
                    MessageBox.Show("Login Successful!");

                    this.Hide();

                  if (roleselector.Text == "Faculty")
                    {
                        AdminForm af = new AdminForm(user_name.Text);
                        af.Show();
                    }
                    else if (roleselector.Text == "Student")
                    {
                        StudentForm stf = new StudentForm(user_name.Text);
                        stf.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Credentials or Wrong Role!");
                }
            }

        }
        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        private void signup_LinkClicked(object sender, EventArgs e)
        {
            register rf = new register();
            rf.Show();
            this.Hide();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}