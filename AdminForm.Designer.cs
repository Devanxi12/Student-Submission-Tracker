namespace Student_Submission_Tracker
{
    partial class AdminForm
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
            this.logout_btn = new System.Windows.Forms.Button();
            this.add_ass = new System.Windows.Forms.Button();
            this.view_student = new System.Windows.Forms.Button();
            this.View_sub = new System.Windows.Forms.Button();
            this.admin_view = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.admin_view)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(449, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Form";
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(571, 273);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(152, 28);
            this.logout_btn.TabIndex = 1;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // add_ass
            // 
            this.add_ass.Location = new System.Drawing.Point(285, 273);
            this.add_ass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add_ass.Name = "add_ass";
            this.add_ass.Size = new System.Drawing.Size(161, 28);
            this.add_ass.TabIndex = 3;
            this.add_ass.Text = "Add Assignment";
            this.add_ass.UseVisualStyleBackColor = true;
            this.add_ass.Click += new System.EventHandler(this.add_ass_Click_1);
            // 
            // view_student
            // 
            this.view_student.Location = new System.Drawing.Point(285, 124);
            this.view_student.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.view_student.Name = "view_student";
            this.view_student.Size = new System.Drawing.Size(161, 28);
            this.view_student.TabIndex = 4;
            this.view_student.Text = "View Student";
            this.view_student.UseVisualStyleBackColor = true;
            this.view_student.Click += new System.EventHandler(this.view_student_Click_1);
            // 
            // View_sub
            // 
            this.View_sub.Location = new System.Drawing.Point(571, 124);
            this.View_sub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.View_sub.Name = "View_sub";
            this.View_sub.Size = new System.Drawing.Size(152, 28);
            this.View_sub.TabIndex = 5;
            this.View_sub.Text = "View Submissions";
            this.View_sub.UseVisualStyleBackColor = true;
            this.View_sub.Click += new System.EventHandler(this.View_sub_Click_1);
            // 
            // admin_view
            // 
            this.admin_view.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.admin_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admin_view.Location = new System.Drawing.Point(317, 382);
            this.admin_view.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.admin_view.Name = "admin_view";
            this.admin_view.Size = new System.Drawing.Size(405, 267);
            this.admin_view.TabIndex = 6;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1184, 807);
            this.Controls.Add(this.admin_view);
            this.Controls.Add(this.View_sub);
            this.Controls.Add(this.view_student);
            this.Controls.Add(this.add_ass);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.admin_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button add_ass;
        private System.Windows.Forms.Button view_student;
        private System.Windows.Forms.Button View_sub;
        private System.Windows.Forms.DataGridView admin_view;
    }
}