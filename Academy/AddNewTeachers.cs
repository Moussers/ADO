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
            if (string.IsNullOrEmpty(birthDate)) 
            {
                birthDate = " ";
            }
            string phone = inputPhnTeacher.Text;
            if (string.IsNullOrEmpty(phone)) 
            {
                phone = " ";
            }
            string mail = inputMailTeacher.Text;
            if (string.IsNullOrEmpty(mail)) 
            {
                mail = " ";
            }
                connector.Select($"IF NOT EXISTS (SELECT last_name FROM Teacher WHERE {lastName} = last_name) " +
                $"AND (SELECT first_name FROM Teachers WHERE N'{firstName}' = first_name) " +
                $"BEGIN " +
                $"INSERT INTO Teachers VALUE ({lastName}, {firstName}, {middleName}, {birthDate}, {phone}, {mail})" +
                $" END;");
            //INSERT INTO [dbo].[Teachers] ([teacher_id], [last_name], [first_name], [middle_name], [birth_date],
            //[email], [phone], [photo], [work_since], [rate]) VALUES (8, N'Твердохлеб', N'Александр', N'Павлович',
            //N'1981-01-01', NULL, NULL, <SQLVARIANT>, N'2007-10-10', CAST(32.0000 AS SmallMoney))
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
