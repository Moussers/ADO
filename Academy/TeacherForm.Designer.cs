namespace Academy
{
    partial class TeacherForm
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
            this.lbSalary = new System.Windows.Forms.Label();
            this.tbSalary = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSalary.Location = new System.Drawing.Point(79, 274);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(113, 25);
            this.lbSalary.TabIndex = 17;
            this.lbSalary.Text = "Зарплата:";
            // 
            // tbSalary
            // 
            this.tbSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSalary.Location = new System.Drawing.Point(209, 279);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(251, 31);
            this.tbSalary.TabIndex = 18;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.lbSalary);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.Controls.SetChildIndex(this.tbLastName, 0);
            this.Controls.SetChildIndex(this.tbFirstName, 0);
            this.Controls.SetChildIndex(this.tbMiddleName, 0);
            this.Controls.SetChildIndex(this.dtpBirthDate, 0);
            this.Controls.SetChildIndex(this.pbPhoto, 0);
            this.Controls.SetChildIndex(this.tbEmail, 0);
            this.Controls.SetChildIndex(this.tbPhone, 0);
            this.Controls.SetChildIndex(this.lbSalary, 0);
            this.Controls.SetChildIndex(this.tbSalary, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.TextBox tbSalary;
    }
}