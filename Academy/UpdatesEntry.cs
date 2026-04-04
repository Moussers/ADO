using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
    public partial class UpdatesEntry : StudentForm
    {
        DataTable curGroup;
        public UpdatesEntry(int stud_id)
        {
            InitializeComponent();
            tbLastName.Text = DataBase.connector.Select($"SELECT last_name FROM Students WHERE stud_id = {stud_id}").Rows[0][0].ToString();
            tbFirstName.Text = DataBase.connector.Select($"SELECT first_name FROM Students WHERE stud_id = {stud_id}").Rows[0][0].ToString();
            tbMiddleName.Text = DataBase.connector.Select($"SELECT middle_name FROM Students WHERE stud_id = {stud_id}").Rows[0][0].ToString();
            dtpBirthDate.Text = DataBase.connector.Select($"SELECT birth_date FROM Students WHERE stud_id = {stud_id}").Rows[0][0].ToString();
            tbEmail.Text = DataBase.connector.Select($"SELECT email FROM Students WHERE stud_id = {stud_id}").Rows[0][0].ToString();
            tbPhone.Text = DataBase.connector.Select($"SELECT phone FROM Students WHERE stud_id = {stud_id}").Rows[0][0].ToString();
            int index = Convert.ToInt32(DataBase.connector.Select($"SELECT Count(group) FROM Groups WHERE stud_id = {stud_id}").Rows[0][0].ToString());
            cbGroup.SelectedIndex = 13;
            //string group = DataBase.connector.Select($"SELECT [group] FROM Students WHERE stud_id = {stud_id}").Rows[0][0].ToString();
            //MessageBox.Show($"Группа: {group}", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        protected override void buttonOK_Click(object sender, EventArgs e)
        {
            DataBase.connector.Select($"INSERT INTO Students (last_name, first_name, middle_name, birth_date, email, phone, photo, [group]) " +
                $"VALUES ({tbLastName.Text},{tbFirstName.Text},{tbMiddleName.Text},{dtpBirthDate.Value.ToString("yyyy-MM-dd")},{tbEmail},{tbPhone});");
            Close();
        }
    }
}
