namespace Student_Submission_Tracker
{
    partial class AssignmentForm
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
            this.assign_title = new System.Windows.Forms.Label();
            this.Desc = new System.Windows.Forms.Label();
            this.Exist_Ass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.assign_manage = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // assign_title
            // 
            this.assign_title.AutoSize = true;
            this.assign_title.Location = new System.Drawing.Point(62, 147);
            this.assign_title.Name = "assign_title";
            this.assign_title.Size = new System.Drawing.Size(95, 15);
            this.assign_title.TabIndex = 0;
            this.assign_title.Text = "Assignment Title";
            // 
            // Desc
            // 
            this.Desc.AutoSize = true;
            this.Desc.Location = new System.Drawing.Point(62, 202);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(67, 15);
            this.Desc.TabIndex = 1;
            this.Desc.Text = "Description";
            // 
            // Exist_Ass
            // 
            this.Exist_Ass.AutoSize = true;
            this.Exist_Ass.Location = new System.Drawing.Point(226, 437);
            this.Exist_Ass.Name = "Exist_Ass";
            this.Exist_Ass.Size = new System.Drawing.Size(119, 15);
            this.Exist_Ass.TabIndex = 1;
            this.Exist_Ass.Text = "Existing Assignments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Deadline";
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(103, 350);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(87, 27);
            this.save_button.TabIndex = 2;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(378, 350);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(87, 27);
            this.back_button.TabIndex = 2;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(244, 350);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(87, 27);
            this.clear_button.TabIndex = 2;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(174, 284);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(233, 23);
            this.dtpDueDate.TabIndex = 3;
            // 
            // assign_manage
            // 
            this.assign_manage.AutoSize = true;
            this.assign_manage.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assign_manage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.assign_manage.Location = new System.Drawing.Point(197, 33);
            this.assign_manage.Name = "assign_manage";
            this.assign_manage.Size = new System.Drawing.Size(270, 26);
            this.assign_manage.TabIndex = 4;
            this.assign_manage.Text = "Assignment Management";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(203, 188);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(203, 64);
            this.txtDescription.TabIndex = 5;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(203, 143);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(203, 23);
            this.txtTitle.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(103, 488);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(392, 193);
            this.dataGridView1.TabIndex = 6;
            // 
            // AssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(721, 693);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.assign_manage);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exist_Ass);
            this.Controls.Add(this.Desc);
            this.Controls.Add(this.assign_title);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AssignmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment";
            this.Load += new System.EventHandler(this.AssignmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label assign_title;
        private System.Windows.Forms.Label Desc;
        private System.Windows.Forms.Label Exist_Ass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label assign_manage;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}