namespace Academy
{
    partial class AddNewStudents
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
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbMiddleName = new System.Windows.Forms.Label();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbBirthDate = new System.Windows.Forms.Label();
            this.tbBirthDate = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.tbEMail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btBrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbFirstName.Location = new System.Drawing.Point(415, 54);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(46, 24);
            this.lbFirstName.TabIndex = 0;
            this.lbFirstName.Text = "Имя";
            // 
            // tbFirstName
            // 
            this.tbFirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbFirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.tbFirstName.Location = new System.Drawing.Point(240, 54);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(165, 20);
            this.tbFirstName.TabIndex = 1;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbLastName.Location = new System.Drawing.Point(414, 99);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(91, 24);
            this.lbLastName.TabIndex = 2;
            this.lbLastName.Text = "Фамилия";
            // 
            // tbLastName
            // 
            this.tbLastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.tbLastName.Location = new System.Drawing.Point(240, 99);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(165, 20);
            this.tbLastName.TabIndex = 3;
            // 
            // lbMiddleName
            // 
            this.lbMiddleName.AutoSize = true;
            this.lbMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbMiddleName.Location = new System.Drawing.Point(415, 144);
            this.lbMiddleName.Name = "lbMiddleName";
            this.lbMiddleName.Size = new System.Drawing.Size(98, 24);
            this.lbMiddleName.TabIndex = 4;
            this.lbMiddleName.Text = "Отчество";
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbMiddleName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.tbMiddleName.Location = new System.Drawing.Point(240, 144);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(165, 20);
            this.tbMiddleName.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOk.Location = new System.Drawing.Point(478, 324);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(87, 35);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancel.Location = new System.Drawing.Point(374, 324);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 35);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbBirthDate
            // 
            this.lbBirthDate.AutoSize = true;
            this.lbBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbBirthDate.Location = new System.Drawing.Point(415, 189);
            this.lbBirthDate.Name = "lbBirthDate";
            this.lbBirthDate.Size = new System.Drawing.Size(150, 24);
            this.lbBirthDate.TabIndex = 8;
            this.lbBirthDate.Text = "Дата рождения";
            // 
            // tbBirthDate
            // 
            this.tbBirthDate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbBirthDate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.tbBirthDate.Location = new System.Drawing.Point(240, 189);
            this.tbBirthDate.Name = "tbBirthDate";
            this.tbBirthDate.Size = new System.Drawing.Size(165, 20);
            this.tbBirthDate.TabIndex = 9;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbPhone.Location = new System.Drawing.Point(415, 279);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(90, 24);
            this.lbPhone.TabIndex = 10;
            this.lbPhone.Text = "Телефон";
            // 
            // tbEMail
            // 
            this.tbEMail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbEMail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.tbEMail.Location = new System.Drawing.Point(240, 234);
            this.tbEMail.Name = "tbEMail";
            this.tbEMail.Size = new System.Drawing.Size(165, 20);
            this.tbEMail.TabIndex = 11;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbEmail.Location = new System.Drawing.Point(415, 234);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(63, 24);
            this.lbEmail.TabIndex = 12;
            this.lbEmail.Text = "E-Mail";
            // 
            // tbPhone
            // 
            this.tbPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.tbPhone.Location = new System.Drawing.Point(240, 279);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(165, 20);
            this.tbPhone.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(32, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 249);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btBrowse
            // 
            this.btBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btBrowse.Location = new System.Drawing.Point(62, 324);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(87, 35);
            this.btBrowse.TabIndex = 15;
            this.btBrowse.Text = "Обзор";
            this.btBrowse.UseVisualStyleBackColor = true;
            // 
            // AddNewStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 380);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.tbEMail);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.tbBirthDate);
            this.Controls.Add(this.lbBirthDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbMiddleName);
            this.Controls.Add(this.lbMiddleName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lbFirstName);
            this.Name = "AddNewStudents";
            this.Text = "AddNewStudents";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbMiddleName;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbBirthDate;
        private System.Windows.Forms.TextBox tbBirthDate;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox tbEMail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btBrowse;
    }
}