using DBtools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
    public partial class MainForm : Form
    {
        Query[] queries = 
        {
            new Query
                (
                "last_name, first_name, middle_name, group_name, direction_name",
                "Students, Groups, Directions",
                "[group]=group_id AND direction = direction_id"
                ),
            new Query
                (
                "*",
                "Groups, Directions",
                "direction = direction_id"
                ),
            new Query("*", "Directions"),
            new Query("*", "Disciplines"),
            new Query("*", "Teachers"),
        };
        string[] status_messages = 
        { 
            "Количество студентов",
            "Количество групп",
            "Количество направлений",
            "Количество дисциплин",
            "Количество преподователей"
        };
        DataGridView[] tables;
        Connector connector;
        public MainForm()
        {
            InitializeComponent();
            tables = new DataGridView[] { dgvStudents, dgvGroups, dgvDirections, dgvDisciplines, dgvTeachers };
            connector = new DBtools.Connector(ConfigurationManager.ConnectionStrings["PV_521_Import"].ConnectionString);
            //dgvDirections.DataSource = connector.Select("*", "Directions");
            //toolStripStatusLabel.Text = $"Колличество направлений обучения: {dgvDirections.Rows.Count - 1}";
            //toolStripStatusLabel.Text = $"Колличество направлений обучения: {connector.Scalar("SELECT COUNT(*) FROM Directions")}";
            tabControl_SelectedIndexChanged(tabControl, null);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = tabControl.SelectedIndex;
            tables[i].DataSource = connector.Select($"SELECT * FROM {tabControl.SelectedTab.Text}");
            toolStripStatusLabel.Text = $"{status_messages[i]}: {tables[i].RowCount - 1}";
            if (i == 1)
            {
                DataTable dataTable = connector.Select($"SELECT direction_name FROM directions");
                FillterGroups.Items.Clear();
                FillterGroups.Items.Add("Все направления");
                for (int j = 0; j < dataTable.Rows.Count; j++)
                {
                    FillterGroups.Items.Add(dataTable.Rows[j][0].ToString());
                }
                FillterGroups.SelectedIndex = 0;
            }
            if (i == 3) 
            {
                DataTable dataTable = connector.Select($"Select direction_name FROM directions");
                FillterDisciplines.Items.Clear();
                FillterDisciplines.Items.Add("Все направления");
                for (int j = 0; j < dataTable.Rows.Count; j++) 
                {
                    FillterDisciplines.Items.Add(dataTable.Rows[j][0].ToString());
                }
                FillterDisciplines.SelectedIndex = 0;
            }
            if (i == 4) 
            {
                DataTable dataTable = connector.Select("SELECT discipline_name FROM Disciplines");
                FillterTeachers.Items.Clear();
                FillterTeachers.Items.Add("Все дисциплины");
                for (int j = 0; j < dataTable.Rows.Count; j++)
                {
                    FillterTeachers.Items.Add(dataTable.Rows[j][0].ToString());
                }
                FillterTeachers.SelectedIndex = 0;
            }
        }

        private void FillterGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 1;
            if (FillterGroups.SelectedIndex > 0)
                tables[i].DataSource = connector.Select($"SELECT * FROM {tabControl.SelectedTab.Text} WHERE direction = {FillterGroups.SelectedIndex}");
            else
                tables[i].DataSource = connector.Select($"SELECT * FROM {tabControl.SelectedTab.Text}");
        }

        private void FillterDisciplines_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 3;
            if (FillterDisciplines.SelectedIndex > 0)
            {
                int selectedItem = FillterDisciplines.SelectedIndex;
                tables[i].DataSource = connector.Select($"SELECT * FROM {tabControl.SelectedTab.Text} AS Dis INNER JOIN DisciplinesDirectionsRelation as DDR ON DDR.direction = {selectedItem} AND Dis.discipline_id = DDR.discipline;");
            }
            else 
            {
                tables[i].DataSource = connector.Select($"SELECT * FROM {tabControl.SelectedTab.Text}");
            }
        }

        private void FillterTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 4;
            if (FillterTeachers.SelectedIndex > 0) 
            {
                int selecteditem = FillterTeachers.SelectedIndex;
                tables[i].DataSource = connector.Select($"SELECT * FROM {tabControl.SelectedTab.Text} AS Teach INNER JOIN TeachersDisciplinesRelation as TDR ON TDR.discipline = {selecteditem} AND Teach.teacher_id = TDR.teacher;");

            }
        }
    }
}
