using Academy.Models;
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
        public TeacherForm(int id) : this() 
        {
            DataTable data = DataBase.connector.Select($"SELECT * FROM Teachers WHERE teacher_id = {id}");
            teacher = new Models.Teacher(data.Rows[0].ItemArray);
            human = teacher;
            Extract();
            this.dtpWorkSince.Value = Convert.ToDateTime(teacher.work_since);
            this.tbRate.Text = teacher.rate.ToString();
            pbPhoto.Image = DataBase.connector.DownloadPhoto("Teachers","photo",id);
        }
        protected override void buttonOK_Click(object sender, EventArgs e)
        {
            base.buttonOK_Click(sender, e);
            teacher = new Models.Teacher
                (
                human, 
                dtpWorkSince.Value.ToString("yyyy-MM-dd"), 
                Convert.ToDecimal(tbRate.Text)
                );
            if (teacher.id == 0)
            {
                teacher.id = Convert.ToInt32
                (
                DataBase.connector.Scalar($"INSERT Teachers({teacher.GetNames()}) VALUES ({teacher.GetValues()});SELECT SCOPE_IDENTITY()")
                );
            }
            else
            {
                DataBase.connector.Update($"UPDATE Teachers SET {teacher.GetUpdateString()} WHERE teacher_id={teacher.id}");
            }
            if (teacher.photo != null) 
            {
                DataBase.connector.UploadPhoto(teacher.SerializePhoto(), teacher.id, "photo", "Teachers");
            }
        }
    }
}
