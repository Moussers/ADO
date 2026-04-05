using DBtools;
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
            string groupId = DataBase.connector.Select($"SELECT [group] FROM Students WHERE stud_id = {stud_id}").Rows[0][0].ToString();
            string groupName = DataBase.connector.Select($"SELECT group_name FROM Groups WHERE group_id = {groupId}").Rows[0][0].ToString();
            DataTable groups = DataBase.connector.Select("SELECT group_id,group_name FROM Groups");
            int index = GetIndexFromTable(groups, groupName);
            cbGroup.SelectedIndex = index;
         }
        protected override void buttonOK_Click(object sender, EventArgs e)
        {
            DataBase.connector.Select($"Update Students SET " +
                $"last_name = N'{tbLastName.Text}', " +
                $"first_name = N'{tbFirstName.Text}', " +
                $"middle_name = N'{tbMiddleName.Text}', " +
                $"birth_date = N'{dtpBirthDate.Value.ToString("yyyy-MM-dd")}', " +
                $"email = N'{tbEmail.Text}', " +
                $"phone = N'{tbPhone.Text}', " +
                $"[group] = N'{cbGroup.SelectedValue}' " +
                $"WHERE stud_id = {stud_id}");
            Close();
        }
        private int GetIndexFromTable(DataTable groups, string groupName) 
        {
            int i = -1;
            int k = 0;
            foreach (DataRow row in groups.Rows)
            {
                if (groupName.Equals(row[1].ToString())) { i = k; }
                k++;
            }
            return i;
            //DataTable - в ней записана таблица,
            //DataRow - отельная строка из таблицы.
            //Equal - сравнивает два значения одного типа данных.
        }
    }
}
