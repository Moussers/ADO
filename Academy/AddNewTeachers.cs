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
    public partial class AddNewTeachers : Form
    {
        Connector connector;
        OpenFileDialog fileDialog;
        public AddNewTeachers()
        {
            InitializeComponent();
            connector = new Connector(ConfigurationManager.ConnectionStrings["PV_521_Import"].ConnectionString);
            fileDialog = new OpenFileDialog();
            //fileDialog.Filter();
        }
        private void btOK_Click(object sender, EventArgs e)
        {
            string lastName = tbLastName.Text;
            string firstName = tbFirstName.Text;
            string middleName = tbMiddleName.Text;
            string birthDate = tbBirthDate.Text;
            if (string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(firstName)) 
            {
                MessageBox.Show("Поле имя или фамилия не заполнено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(birthDate))
            {
                birthDate = null;
                //отправка null строки не вызовет ошибки со стороны T-SQL сервера,
                //если это поле не имееет состояние NOT NULL
            }
                string phone = tbPhone.Text;
            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Поле 'Телефон' не заполнено!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else 
            {
                phone += ",";
            }
                string eMail = inputMailTeacher.Text;
            if (string.IsNullOrEmpty(eMail))
            {
                MessageBox.Show("Поле 'E-Mail' не заполнено!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataTable tableId = connector.Select("SELECT COUNT(*) FROM Teachers");
            int teacherId = Convert.ToInt32(tableId.Rows[0][0])+1;
                connector.Select($"IF NOT EXISTS (SELECT last_name,first_name FROM Teachers WHERE N'{lastName}' = last_name " +
                $"AND N'{firstName}' = first_name) " +
                $"BEGIN " +
                $"INSERT INTO Teachers (teacher_id, last_name, first_name, middle_name, birth_date, phone, email ) " +
                $"VALUES ({teacherId}, N'{lastName}', N'{firstName}', N'{middleName}', N'{birthDate}', {phone} N'{eMail}') " +
                $"END;");
            Close();
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();
        }
    }
}
