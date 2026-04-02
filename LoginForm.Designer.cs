namespace Student_Submission_Tracker
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.u_name = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.Role = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.roleselector = new System.Windows.Forms.ComboBox();
            this.login = new System.Windows.Forms.Button();
            this.dont = new System.Windows.Forms.Label();
            this.signup = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(199, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // u_name
            // 
            this.u_name.AutoSize = true;
            this.u_name.Location = new System.Drawing.Point(104, 126);
            this.u_name.Name = "u_name";
            this.u_name.Size = new System.Drawing.Size(61, 13);
            this.u_name.TabIndex = 1;
            this.u_name.Text = "Username :";
            this.u_name.Click += new System.EventHandler(this.label2_Click);
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(104, 164);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(59, 13);
            this.pass.TabIndex = 1;
            this.pass.Text = "Password :";
            this.pass.Click += new System.EventHandler(this.label2_Click);
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Location = new System.Drawing.Point(104, 207);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(35, 13);
            this.Role.TabIndex = 2;
            this.Role.Text = "Role :";
            // 
            // user_name
            // 
            this.user_name.Location = new System.Drawing.Point(171, 123);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(145, 20);
            this.user_name.TabIndex = 3;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(171, 164);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(145, 20);
            this.password.TabIndex = 4;
            this.password.UseSystemPasswordChar = true;
            // 
            // roleselector
            // 
            this.roleselector.FormattingEnabled = true;
            this.roleselector.Items.AddRange(new object[] {
            "Faculty",
            "Student"});
            this.roleselector.Location = new System.Drawing.Point(171, 204);
            this.roleselector.Name = "roleselector";
            this.roleselector.Size = new System.Drawing.Size(145, 21);
            this.roleselector.TabIndex = 5;
            this.roleselector.Text = "Select";
            // 
            // login
            // 
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Location = new System.Drawing.Point(206, 255);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 6;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // dont
            // 
            this.dont.AutoSize = true;
            this.dont.Location = new System.Drawing.Point(132, 300);
            this.dont.Name = "dont";
            this.dont.Size = new System.Drawing.Size(122, 13);
            this.dont.TabIndex = 7;
            this.dont.Tag = "";
            this.dont.Text = "Don\'t have an account?";
            // 
            // signup
            // 
            this.signup.AutoSize = true;
            this.signup.Location = new System.Drawing.Point(276, 300);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(45, 13);
            this.signup.TabIndex = 8;
            this.signup.TabStop = true;
            this.signup.Text = "Sign Up";
            this.signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signup_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(521, 526);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.dont);
            this.Controls.Add(this.login);
            this.Controls.Add(this.roleselector);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.u_name);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label u_name;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.ComboBox roleselector;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label dont;
        private System.Windows.Forms.LinkLabel signup;
    }
}

