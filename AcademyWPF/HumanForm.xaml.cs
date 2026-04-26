using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AcademyWPF
{
    public partial class HumanForm : Window
    {
        
        Models.Human human;
        public HumanForm()
        {
            InitializeComponent();
        }

        private void btBrowse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Files (*.*)|*.*| JPG Files (*.jpg)|*.jpg| JPEG Files (*.jpeg)|*.jpeg| PNG Files (*.png)|*.png";
            dialog.ShowDialog();
        }

        private void btOK_Click(object sender, RoutedEventArgs e)
        {
            //human = new Models.Human
            //    (lbID.Content.ToString() == "" ? 0: lbID.Content.ToString(),lbLastName.Content.ToString(),lbFirstName.Content.ToString(),lbMiddleName.Content.ToString(),
            //    dpBirthDate.ToString(), lbEMail.Content.ToString(), lbPhone.Content.ToString(), imPhoto.Source);
            //labelID.Text == "" ? 0 : Convert.ToInt32(labelID.Text.Split(':').Last()),
        }
        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
