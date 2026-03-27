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
        Connector connector;

        public MainForm()
        {
            InitializeComponent();
            connector = new DBtools.Connector(ConfigurationManager.ConnectionStrings["PV_521_Import"].ConnectionString);
            dgvDirections.DataSource = connector.Select("*", "Directions");
            toolStripStatusLabel.Text = $"Колличество направлений обучения: {dgvDirections.Rows.Count - 1}";
            //toolStripStatusLabel.Text = $"Колличество направлений обучения: {connector.Scalar("SELECT COUNT(*) FROM Directions")}";
        }
    }
}
