using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using DBtools;

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
                DataTable dtb = connector.Select($"SELECT direction_name FROM directions");
                comboBox.Items.Clear();
                comboBox.Items.Add("Все направления");
                for (int j = 0; j < dtb.Rows.Count; j++)
                {
                    comboBox.Items.Add(dtb.Rows[j][0].ToString());
                }
                comboBox.SelectedIndex = 0;
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 1;
            if (comboBox.SelectedIndex > 0)
                tables[i].DataSource = connector.Select($"SELECT * FROM {tabControl.SelectedTab.Text} WHERE direction = {comboBox.SelectedIndex}");
            else
                tables[i].DataSource = connector.Select($"SELECT * FROM {tabControl.SelectedTab.Text}");
        }
    }
}
