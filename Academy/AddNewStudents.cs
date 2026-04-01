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
            string firstName = inputFrName.Text;
            string lastName = inputLsName.Text;
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName)) 
            {
                MessageBox.Show("Поле имя или фамилия не заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string middleName = inputMidName.Text;
            if (string.IsNullOrEmpty(middleName))
            {
                middleName = null;
            }
            //Connector.
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
