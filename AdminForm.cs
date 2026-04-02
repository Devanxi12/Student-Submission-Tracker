using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_Submission_Tracker
{
    public partial class AdminForm : Form
    {

        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=StudentSubmission;Integrated Security=True";


        public string facultyName;


        public AdminForm(string fname)
        {
            InitializeComponent();
            facultyName = fname;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Faculty: " + facultyName);
            if (string.IsNullOrEmpty(facultyName))
            {
                MessageBox.Show("Faculty not found!");
                return;
            }

            LoadStudentStatus();
        }

        private void LoadStudentStatus()
{
    using (SqlConnection con = new SqlConnection(connectionString))
    {
                string query = @"
                SELECT 
                    U.Username AS StudentName,
                    A.Title AS AssignmentTitle,
                    CASE 
                        WHEN S.Id IS NOT NULL THEN 'Submitted'
                        ELSE 'Pending'
                    END AS Status
                FROM Users U
                CROSS JOIN Assignments A
                LEFT JOIN Submission S 
                    ON S.StudentName = U.Username   
                    AND S.AssignmentTitle = A.Title
                WHERE U.Role = 'Student'
                AND A.FacultyName = @fname
                ORDER BY U.Username";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@fname", facultyName);

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);

        admin_view.DataSource = dt;
    }
}


        private void add_ass_Click(object sender, EventArgs e)
        {
            
        }

        private void view_student_Click_1(object sender, EventArgs e)
        {
            ViewStudent vs = new ViewStudent();
            vs.Show();
            this.Hide();
        }

        private void View_sub_Click_1(object sender, EventArgs e)
        {
            View_Submissions vf = new View_Submissions();
            vf.Show();
            this.Hide();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }


        private void admin_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void add_ass_Click_1(object sender, EventArgs e)
        {
            AssignmentForm asf = new AssignmentForm();
            asf.Show();
            this.Hide();
        }
    }
}