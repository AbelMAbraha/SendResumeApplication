namespace SendCV
{
    partial class Form1
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
            this.sendCV = new System.Windows.Forms.Button();
            this.cv = new System.Windows.Forms.Button();
            this.coverLetter = new System.Windows.Forms.Button();
            this.cvLabel = new System.Windows.Forms.Label();
            this.coverLetterLabel = new System.Windows.Forms.Label();
            this.emailAccount = new System.Windows.Forms.TextBox();
            this.emailPassword = new System.Windows.Forms.TextBox();
            this.emailAccountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.companyEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Occupation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerCompInfo = new System.Windows.Forms.Button();
            this.compEmail = new System.Windows.Forms.TextBox();
            this.compName = new System.Windows.Forms.TextBox();
            this.dropdownOccupations = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.subjectEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sendCV
            // 
            this.sendCV.Location = new System.Drawing.Point(12, 424);
            this.sendCV.Name = "sendCV";
            this.sendCV.Size = new System.Drawing.Size(486, 23);
            this.sendCV.TabIndex = 0;
            this.sendCV.Text = "Send CV";
            this.sendCV.UseVisualStyleBackColor = true;
            this.sendCV.Click += new System.EventHandler(this.sendCV_Click);
            // 
            // cv
            // 
            this.cv.Location = new System.Drawing.Point(12, 12);
            this.cv.Name = "cv";
            this.cv.Size = new System.Drawing.Size(219, 23);
            this.cv.TabIndex = 1;
            this.cv.Text = "Select CV";
            this.cv.UseVisualStyleBackColor = true;
            this.cv.Click += new System.EventHandler(this.cv_Click);
            // 
            // coverLetter
            // 
            this.coverLetter.Location = new System.Drawing.Point(282, 12);
            this.coverLetter.Name = "coverLetter";
            this.coverLetter.Size = new System.Drawing.Size(216, 23);
            this.coverLetter.TabIndex = 2;
            this.coverLetter.Text = "Select Cover Letter";
            this.coverLetter.UseVisualStyleBackColor = true;
            this.coverLetter.Click += new System.EventHandler(this.coverLetter_Click);
            // 
            // cvLabel
            // 
            this.cvLabel.AutoSize = true;
            this.cvLabel.Location = new System.Drawing.Point(12, 38);
            this.cvLabel.Name = "cvLabel";
            this.cvLabel.Size = new System.Drawing.Size(0, 13);
            this.cvLabel.TabIndex = 3;
            // 
            // coverLetterLabel
            // 
            this.coverLetterLabel.AutoSize = true;
            this.coverLetterLabel.Location = new System.Drawing.Point(248, 38);
            this.coverLetterLabel.Name = "coverLetterLabel";
            this.coverLetterLabel.Size = new System.Drawing.Size(0, 13);
            this.coverLetterLabel.TabIndex = 4;
            // 
            // emailAccount
            // 
            this.emailAccount.Location = new System.Drawing.Point(12, 398);
            this.emailAccount.Name = "emailAccount";
            this.emailAccount.Size = new System.Drawing.Size(213, 20);
            this.emailAccount.TabIndex = 5;
            // 
            // emailPassword
            // 
            this.emailPassword.Location = new System.Drawing.Point(279, 398);
            this.emailPassword.Name = "emailPassword";
            this.emailPassword.Size = new System.Drawing.Size(219, 20);
            this.emailPassword.TabIndex = 6;
            this.emailPassword.UseSystemPasswordChar = true;
            // 
            // emailAccountLabel
            // 
            this.emailAccountLabel.AutoSize = true;
            this.emailAccountLabel.Location = new System.Drawing.Point(12, 382);
            this.emailAccountLabel.Name = "emailAccountLabel";
            this.emailAccountLabel.Size = new System.Drawing.Size(32, 13);
            this.emailAccountLabel.TabIndex = 7;
            this.emailAccountLabel.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyEmail,
            this.Subject,
            this.Occupation,
            this.companyName});
            this.dataGridView1.Location = new System.Drawing.Point(15, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(483, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // companyEmail
            // 
            this.companyEmail.HeaderText = "Company Email";
            this.companyEmail.Name = "companyEmail";
            this.companyEmail.Width = 110;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            this.Subject.Width = 110;
            // 
            // Occupation
            // 
            this.Occupation.HeaderText = "Occupation";
            this.Occupation.Name = "Occupation";
            this.Occupation.Width = 110;
            // 
            // companyName
            // 
            this.companyName.HeaderText = "Company Name";
            this.companyName.Name = "companyName";
            this.companyName.Width = 110;
            // 
            // registerCompInfo
            // 
            this.registerCompInfo.Location = new System.Drawing.Point(15, 183);
            this.registerCompInfo.Name = "registerCompInfo";
            this.registerCompInfo.Size = new System.Drawing.Size(483, 23);
            this.registerCompInfo.TabIndex = 10;
            this.registerCompInfo.Text = "Register Company Information";
            this.registerCompInfo.UseVisualStyleBackColor = true;
            this.registerCompInfo.Click += new System.EventHandler(this.registerCompInfo_Click);
            // 
            // compEmail
            // 
            this.compEmail.Location = new System.Drawing.Point(15, 157);
            this.compEmail.Name = "compEmail";
            this.compEmail.Size = new System.Drawing.Size(215, 20);
            this.compEmail.TabIndex = 11;
            // 
            // compName
            // 
            this.compName.Location = new System.Drawing.Point(283, 157);
            this.compName.Name = "compName";
            this.compName.Size = new System.Drawing.Size(215, 20);
            this.compName.TabIndex = 12;
            // 
            // dropdownOccupations
            // 
            this.dropdownOccupations.FormattingEnabled = true;
            this.dropdownOccupations.Location = new System.Drawing.Point(16, 114);
            this.dropdownOccupations.Name = "dropdownOccupations";
            this.dropdownOccupations.Size = new System.Drawing.Size(215, 21);
            this.dropdownOccupations.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Company Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Company Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Occupation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Subject (email)";
            // 
            // subjectEmail
            // 
            this.subjectEmail.Location = new System.Drawing.Point(283, 111);
            this.subjectEmail.Name = "subjectEmail";
            this.subjectEmail.Size = new System.Drawing.Size(215, 20);
            this.subjectEmail.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 460);
            this.Controls.Add(this.subjectEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dropdownOccupations);
            this.Controls.Add(this.compName);
            this.Controls.Add(this.compEmail);
            this.Controls.Add(this.registerCompInfo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailAccountLabel);
            this.Controls.Add(this.emailPassword);
            this.Controls.Add(this.emailAccount);
            this.Controls.Add(this.coverLetterLabel);
            this.Controls.Add(this.cvLabel);
            this.Controls.Add(this.coverLetter);
            this.Controls.Add(this.cv);
            this.Controls.Add(this.sendCV);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendCV;
        private System.Windows.Forms.Button cv;
        private System.Windows.Forms.Button coverLetter;
        private System.Windows.Forms.Label cvLabel;
        private System.Windows.Forms.Label coverLetterLabel;
        private System.Windows.Forms.TextBox emailAccount;
        private System.Windows.Forms.TextBox emailPassword;
        private System.Windows.Forms.Label emailAccountLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button registerCompInfo;
        private System.Windows.Forms.TextBox compEmail;
        private System.Windows.Forms.TextBox compName;
        private System.Windows.Forms.ComboBox dropdownOccupations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Occupation;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox subjectEmail;
    }
}

