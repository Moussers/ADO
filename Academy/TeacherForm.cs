using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
    public partial class TeacherForm : HumanForm
    {
        internal Models.Teacher teacher;
        public TeacherForm()
        {
            InitializeComponent();
        }
        TeacherForm(int id) : this() 
        {
            DataTable dataTable = DataBase.connector.Select("*", "Teacher", $"teahcer_id = {id}");

        }
        protected override void buttonOK_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            base.buttonOK_Click(sender, e);
            //teacher = new Models.Teacher(tbSalary.Text);
        }
    }
}
