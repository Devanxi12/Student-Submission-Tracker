using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace Student_Submission_Tracker
{
    public partial class register : Form
    {
        public register()
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
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }
        private void already_Click(object sender, EventArgs e)
        {

        }

        private void signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=StudentSubmission;Integrated Security=True";

        private void regi_Click(object sender, EventArgs e)
        {
            string name = txtname.Text.Trim();
            string username = txtuname.Text.Trim();
            string email = txtemail.Text.Trim();
            string password = txtpass.Text;
            string confirmPassword = txtcpass.Text;
            string role = comboBox1.Text;

            // 🔹 Validation
            if (name == "" || username == "" || email == "" || password == "" || role == "")
            {
                MessageBox.Show("All fields are required!");
                return;
            }
            string hashedPassword = HashPassword(txtpass.Text);
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // 🔹 Check user exists
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username=@username OR Email=@email";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@username", username);
                checkCmd.Parameters.AddWithValue("@email", email);

                con.Open();
                int userExists = (int)checkCmd.ExecuteScalar();
                con.Close();

                if (userExists > 0)
                {
                    MessageBox.Show("User already exists!");
                    return;
                }
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // 🔹 Insert user
                string query = "INSERT INTO Users (Name, Username, Email, Password, Role) VALUES (@name, @username, @email, @password, @role)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", hashedPassword);
                cmd.Parameters.AddWithValue("@role", role);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Registration Successful!");
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message); // 🔥 shows real error
                }
            }


            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void register_Load(object sender, EventArgs e)
        {

        }
    }
}
