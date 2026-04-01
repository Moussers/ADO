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
            this.FrName = new System.Windows.Forms.Label();
            this.inputFrName = new System.Windows.Forms.TextBox();
            this.LsName = new System.Windows.Forms.Label();
            this.inputLsName = new System.Windows.Forms.TextBox();
            this.MidName = new System.Windows.Forms.Label();
            this.inputMidName = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FrName
            // 
            this.FrName.AutoSize = true;
            this.FrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FrName.Location = new System.Drawing.Point(336, 80);
            this.FrName.Name = "FrName";
            this.FrName.Size = new System.Drawing.Size(46, 24);
            this.FrName.TabIndex = 0;
            this.FrName.Text = "Имя";
            // 
            // inputFrName
            // 
            this.inputFrName.Location = new System.Drawing.Point(96, 80);
            this.inputFrName.Name = "inputFrName";
            this.inputFrName.Size = new System.Drawing.Size(165, 20);
            this.inputFrName.TabIndex = 1;
            // 
            // LsName
            // 
            this.LsName.AutoSize = true;
            this.LsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LsName.Location = new System.Drawing.Point(336, 145);
            this.LsName.Name = "LsName";
            this.LsName.Size = new System.Drawing.Size(91, 24);
            this.LsName.TabIndex = 2;
            this.LsName.Text = "Фамилия";
            // 
            // inputLsName
            // 
            this.inputLsName.Location = new System.Drawing.Point(96, 145);
            this.inputLsName.Name = "inputLsName";
            this.inputLsName.Size = new System.Drawing.Size(165, 20);
            this.inputLsName.TabIndex = 3;
            // 
            // MidName
            // 
            this.MidName.AutoSize = true;
            this.MidName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.MidName.Location = new System.Drawing.Point(336, 221);
            this.MidName.Name = "MidName";
            this.MidName.Size = new System.Drawing.Size(98, 24);
            this.MidName.TabIndex = 4;
            this.MidName.Text = "Отчество";
            // 
            // inputMidName
            // 
            this.inputMidName.Location = new System.Drawing.Point(96, 226);
            this.inputMidName.Name = "inputMidName";
            this.inputMidName.Size = new System.Drawing.Size(165, 20);
            this.inputMidName.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOk.Location = new System.Drawing.Point(340, 306);
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
            this.btnCancel.Location = new System.Drawing.Point(212, 306);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 35);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddNewStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 353);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.inputMidName);
            this.Controls.Add(this.MidName);
            this.Controls.Add(this.inputLsName);
            this.Controls.Add(this.LsName);
            this.Controls.Add(this.inputFrName);
            this.Controls.Add(this.FrName);
            this.Name = "AddNewStudents";
            this.Text = "AddNewStudents";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FrName;
        private System.Windows.Forms.TextBox inputFrName;
        private System.Windows.Forms.Label LsName;
        private System.Windows.Forms.TextBox inputLsName;
        private System.Windows.Forms.Label MidName;
        private System.Windows.Forms.TextBox inputMidName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}