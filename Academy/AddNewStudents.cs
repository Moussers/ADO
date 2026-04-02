using DBtools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
    public partial class AddNewStudents : Form
    {
        Connector connector;
        public AddNewStudents()
        {
            InitializeComponent();
            connector = new Connector(ConfigurationManager.ConnectionStrings["PV_521_Import"].ConnectionString);
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            string lastName = tbLastName.Text;
            string firstName = tbFirstName.Text;
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName)) 
            {
                MessageBox.Show("Поле 'Имя' или 'Фамилия' не заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string middleName = tbMiddleName.Text;
            if (string.IsNullOrEmpty(middleName))
            {
                middleName = null;
            }
            string birthDate = tbBirthDate.Text;
            if (string.IsNullOrEmpty(birthDate))
            {
                MessageBox.Show("Поле 'Дата рождения' не заполнено!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string eMail = tbEMail.Text;
            if (string.IsNullOrEmpty(eMail))
            {
                MessageBox.Show("Поле 'E-MAil' не заполнено!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string numberPhone = tbPhone.Text;
            if (string.IsNullOrEmpty(numberPhone))
            {
                MessageBox.Show("Поле 'Телефон' не заполнено!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else 
            {
                numberPhone += ",";
            }
            connector.Select($"INSERT INTO Students (last_name, first_name, middle_name, birth_date, phone, email) " +
                $"VALUES (N'{lastName}', N'{firstName}', N'{middleName}', N'{birthDate}', {numberPhone} N'{eMail}' )");
            Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
