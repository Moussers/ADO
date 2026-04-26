using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using DBtools;

namespace AcademyWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Connector connector;
        DataGrid[] tables;
        HumanForm human;
        public MainWindow()
        {
            InitializeComponent();
            connector = new Connector(ConfigurationManager.ConnectionStrings["PV_521_Import"].ConnectionString);
            tables = new DataGrid[] { dgvStudents, dgvGroups, dgvDirections, dgvDisciplines, dgvTeachers };
            tabControl.SelectedIndex = 0;
        }

        private void tabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = (sender as TabControl).SelectedIndex;
            tables[i].ItemsSource = connector.
                Select($"SELECT * FROM {((sender as TabControl).Items[i] as TabItem).Header.ToString()}").DefaultView;
            statusBarCount.Text = $"Количество записей: {tables[i].Items.Count-1}";
            filterByGroup.Items.Clear();
            filterByDirection.Items.Clear();
            if (tabControl.SelectedIndex == 0)
            {
                System.Data.DataTable grp = connector.
                    Select($"SELECT group_name FROM Groups") ;
                filterByGroup.Items.Add("Все группы");
                for (int j = 0; j < grp.Rows.Count; j++)
                    filterByGroup.Items.Add(grp.Rows[j][0]);
                filterByGroup.SelectedIndex = 0;
                System.Data.DataTable dir = connector.Select("SELECT direction_name FROM directions");
                filterByDirection.Items.Add("Все направления");
                for (int j = 0; j < dir.Rows.Count; ++j)
                {
                    filterByDirection.Items.Add(dir.Rows[j][0]);
                }
                filterByDirection.SelectedIndex = 0;
            }
        }

        private void change_selected(object sender, SelectionChangedEventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                if ((filterByDirection.SelectedIndex <= 0) && (filterByGroup.SelectedIndex <= 0))
                {
                    tables[0].ItemsSource = connector.
                        Select($"SELECT * FROM {(tabControl.Items[0] as TabItem).Header.ToString()}").DefaultView;
                }
                else if ((filterByDirection.SelectedIndex <= 0) && filterByGroup.SelectedIndex > 0)
                {
                    System.Data.DataTable grp_id = connector.
                        Select($"SELECT group_id FROM groups WHERE group_name = '{filterByGroup.SelectedItem}'");
                    tables[0].ItemsSource = connector.
                        Select($"SELECT * FROM {(tabControl.Items[0] as TabItem).Header.ToString()}" +
                        $" WHERE [group] = {grp_id.Rows[0][0]}").DefaultView;
                }
                else if ((filterByDirection.SelectedIndex > 0) && filterByGroup.SelectedIndex <= 0)
                {
                    System.Data.DataTable dir_id = connector.
                        Select($"SELECT direction_id FROM directions WHERE direction_name = '{filterByDirection.SelectedItem}'");
                    tables[0].ItemsSource = connector.
                        Select($"SELECT * FROM {(tabControl.Items[0] as TabItem).Header.ToString()}" +
                        $" INNER JOIN Groups on Groups.group_id = [group] WHERE direction = {dir_id.Rows[0][0]}").DefaultView;
                }
                else if ((filterByDirection.SelectedIndex > 0) && filterByGroup.SelectedIndex > 0)
                {
                    System.Data.DataTable dir_id = connector.
                        Select($"SELECT direction_id FROM directions WHERE direction_name = '{filterByDirection.SelectedItem}'");
                    System.Data.DataTable grp_id = connector.
                        Select($"SELECT group_id FROM groups WHERE group_name = '{filterByGroup.SelectedItem}' AND direction = '{dir_id.Rows[0][0]}'");
                    if (grp_id.Rows.Count != 0)
                    {
                        tables[0].ItemsSource = connector.
                            Select($"SELECT * FROM {(tabControl.Items[0] as TabItem).Header.ToString()}" +
                            $" WHERE [group] = {grp_id.Rows[0][0]}").DefaultView;
                    }
                    else
                    {
                        tables[0].ItemsSource = null;
                    }
                }
                statusBarCount.Text = $"Количество записей: {tables[0].Items.Count - 1}";
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            human = new HumanForm();
            human.Show();
        }
    }
}
