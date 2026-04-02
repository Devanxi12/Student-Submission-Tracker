using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Submission_Tracker
{
    public partial class AssignmentForm : Form
    {
        public AssignmentForm()
        {
            InitializeComponent();
        }
        public string facultyName;
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=StudentSubmission;Integrated Security=True";
        private void LoadAssignments()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Assignments";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
    }
        

        private void back_button_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm(facultyName);
            af.Show();
            this.Hide();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtDescription.Clear();
            dtpDueDate.Value = DateTime.Now;
        }
        
        private void save_button_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Assignments (Title, Description, FacultyName, DueDate) VALUES (@title, @desc, @faculty, @date)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@title", txtTitle.Text); // Subject name
                cmd.Parameters.AddWithValue("@desc", txtDescription.Text); 
                cmd.Parameters.AddWithValue("@date", dtpDueDate.Value);
                cmd.Parameters.AddWithValue("@faculty", facultyName);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            
            MessageBox.Show("Assignment Saved Successfully!");
            LoadAssignments();
        }

        private void AssignmentForm_Load(object sender, EventArgs e)
        {
            LoadAssignments();
        }
    }
}
