namespace Academy
{
    partial class AddNewTeachers
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
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.lbBirthDate = new System.Windows.Forms.Label();
            this.tbBirthDate = new System.Windows.Forms.TextBox();
            this.inputMailTeacher = new System.Windows.Forms.TextBox();
            this.lbEMail = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btBrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoEllipsis = true;
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFirstName.Location = new System.Drawing.Point(435, 92);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(48, 23);
            this.lbFirstName.TabIndex = 0;
            this.lbFirstName.Text = "Имя";
            // 
            // tbFirstName
            // 
            this.tbFirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbFirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFirstName.Location = new System.Drawing.Point(225, 96);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(194, 31);
            this.tbFirstName.TabIndex = 1;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoEllipsis = true;
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLastName.Location = new System.Drawing.Point(435, 50);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(91, 23);
            this.lbLastName.TabIndex = 2;
            this.lbLastName.Text = "Фамилия";
            // 
            // tbLastName
            // 
            this.tbLastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLastName.Location = new System.Drawing.Point(225, 50);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(194, 31);
            this.tbLastName.TabIndex = 3;
            // 
            // lbMiddleName
            // 
            this.lbMiddleName.AutoEllipsis = true;
            this.lbMiddleName.AutoSize = true;
            this.lbMiddleName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMiddleName.Location = new System.Drawing.Point(435, 135);
            this.lbMiddleName.Name = "lbMiddleName";
            this.lbMiddleName.Size = new System.Drawing.Size(94, 23);
            this.lbMiddleName.TabIndex = 4;
            this.lbMiddleName.Text = "Отчество";
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbMiddleName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.tbMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMiddleName.Location = new System.Drawing.Point(225, 139);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(194, 31);
            this.tbMiddleName.TabIndex = 5;
            // 
            // btOK
            // 
            this.btOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btOK.Location = new System.Drawing.Point(500, 323);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(76, 35);
            this.btOK.TabIndex = 6;
            this.btOK.Text = "ОК";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btCancel.Location = new System.Drawing.Point(407, 323);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(76, 35);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // lbBirthDate
            // 
            this.lbBirthDate.AutoEllipsis = true;
            this.lbBirthDate.AutoSize = true;
            this.lbBirthDate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBirthDate.Location = new System.Drawing.Point(435, 178);
            this.lbBirthDate.Name = "lbBirthDate";
            this.lbBirthDate.Size = new System.Drawing.Size(141, 23);
            this.lbBirthDate.TabIndex = 8;
            this.lbBirthDate.Text = "Дата рождения";
            // 
            // tbBirthDate
            // 
            this.tbBirthDate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbBirthDate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.tbBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBirthDate.Location = new System.Drawing.Point(225, 181);
            this.tbBirthDate.Name = "tbBirthDate";
            this.tbBirthDate.Size = new System.Drawing.Size(194, 31);
            this.tbBirthDate.TabIndex = 9;
            // 
            // inputMailTeacher
            // 
            this.inputMailTeacher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.inputMailTeacher.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.inputMailTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputMailTeacher.Location = new System.Drawing.Point(225, 225);
            this.inputMailTeacher.Name = "inputMailTeacher";
            this.inputMailTeacher.Size = new System.Drawing.Size(194, 31);
            this.inputMailTeacher.TabIndex = 10;
            // 
            // lbEMail
            // 
            this.lbEMail.AutoEllipsis = true;
            this.lbEMail.AutoSize = true;
            this.lbEMail.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEMail.Location = new System.Drawing.Point(435, 221);
            this.lbEMail.Name = "lbEMail";
            this.lbEMail.Size = new System.Drawing.Size(69, 23);
            this.lbEMail.TabIndex = 11;
            this.lbEMail.Text = "E-Mail";
            // 
            // tbPhone
            // 
            this.tbPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPhone.Location = new System.Drawing.Point(225, 268);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(194, 31);
            this.tbPhone.TabIndex = 12;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoEllipsis = true;
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPhone.Location = new System.Drawing.Point(435, 264);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(85, 23);
            this.lbPhone.TabIndex = 13;
            this.lbPhone.Text = "Телефон";
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(46, 50);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(146, 238);
            this.pbImage.TabIndex = 14;
            this.pbImage.TabStop = false;
            // 
            // btBrowse
            // 
            this.btBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btBrowse.Location = new System.Drawing.Point(80, 303);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(76, 35);
            this.btBrowse.TabIndex = 15;
            this.btBrowse.Text = "Обзор";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // AddNewTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 373);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.lbEMail);
            this.Controls.Add(this.inputMailTeacher);
            this.Controls.Add(this.tbBirthDate);
            this.Controls.Add(this.lbBirthDate);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbMiddleName);
            this.Controls.Add(this.lbMiddleName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lbFirstName);
            this.Name = "AddNewTeachers";
            this.Text = "AddNewTeachers";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
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
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lbBirthDate;
        private System.Windows.Forms.TextBox tbBirthDate;
        private System.Windows.Forms.TextBox inputMailTeacher;
        private System.Windows.Forms.Label lbEMail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btBrowse;
    }
}