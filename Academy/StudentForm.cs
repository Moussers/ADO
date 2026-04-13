using DBtools;
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
    public partial class StudentForm : HumanForm
    {
        internal Models.Student student;
        public StudentForm()
        {
            InitializeComponent();

            //tbLastName.Text = "Жук";
            //tbFirstName.Text = "Василий";
            //tbMiddleName.Text = "Петрович";
            //dtpBirthDate.Text = "1977.10.24";
            //tbEmail.Text = "bazilik_spb@mail.ru";
            //tbPhone.Text = "+7(911)024-56-78";

            DataTable groups = DataBase.connector.Select("SELECT * FROM Groups");
            cbGroup.DataSource = groups;
            cbGroup.DisplayMember = "group_name";
            cbGroup.ValueMember = "group_id";
        }
        public StudentForm(int id) : this()
        {
            DataTable data = DataBase.connector.Select("*", "Students", $"stud_id={id}");
            object[] arr = data.Rows[0].ItemArray;
            student = new Models.Student(data.Rows[0].ItemArray);
            human = student;
            Extract();
            DataTable grp = DataBase.connector.Select("group_id", "Groups", "");
            int i = -1;
            for(int j = 0; j < grp.Rows.Count; ++j)
            {
                if (grp.Rows[j][0].ToString() == student.group.ToString())
                    i = j;
            }
            cbGroup.SelectedIndex = i;
            pbPhoto.Image = DataBase.connector.DownloadPhoto("Students", "photo", student.id);
        }
        protected override void buttonOK_Click(object sender, EventArgs e)
        {
            base.buttonOK_Click(sender, e);
            student = new Models.Student(human,Convert.ToInt32(cbGroup.SelectedIndex));
            if (student.id == 0)
            {
                student.id = Convert.ToInt32(DataBase.connector.Scalar
                    (
                    $"INSERT Students ({student.GetNames()}) VALUES ({student.GetValues()});SELECT SCOPE_IDENTITY()")
                    );
            }
            else DataBase.connector.Update($"UPDATE Students SET {student.GetUpdateString()} WHERE stud_id={student.id}");
            if (student.photo != null)
                DataBase.connector.UploadPhoto(student.SerializePhoto(),student.id,"photo","Students");
        }
    }
}
