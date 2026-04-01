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
        public AddNewTeachers()
        {
            InitializeComponent();
            connector = new Connector(ConfigurationManager.ConnectionStrings["PV_521_Import"].ConnectionString);
        }
        private void btOK_Click(object sender, EventArgs e)
        {
            string lastName = inputLsName.Text;
            string firstName = inputFrName.Text;
            string middleName = inputMidName.Text;
            string birthDate = inputbdTeacher.Text;
            if (string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(firstName)) 
            {
                MessageBox.Show("Поле имя или фамилии не заполнено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(birthDate))
            {
                birthDate = null;
                //отправка null строки не вызовет ошибки со стороны T-SQL сервера,
                //если это поле не имееет состояние NOT NULL
            }
                string phone = inputPhnTeacher.Text;
            if (string.IsNullOrEmpty(phone))
            {
                phone = null;
            }
            else 
            {
                phone += ",";
            }
                string mail = inputMailTeacher.Text;
            if (string.IsNullOrEmpty(mail))
            {
                mail = null;
            }
                DataTable dt = connector.Select("SELECT COUNT(*) FROM Teachers");
            int new_id = Convert.ToInt32(dt.Rows[0][0])+1;
                connector.Select($"IF NOT EXISTS (SELECT last_name,first_name FROM Teachers WHERE N'{lastName}' = last_name " +
                $"AND N'{firstName}' = first_name) " +
                $"BEGIN " +
                $"INSERT INTO Teachers (teacher_id, last_name, first_name, middle_name, birth_date, phone, email ) VALUES ({new_id}, N'{lastName}', N'{firstName}', N'{middleName}', N'{birthDate}', {phone} N'{mail}')" +
                $" END;");
            Close();
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
