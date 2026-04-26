using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
        protected void Extract() 
        {
            if (human != null) 
            {
                if (human.id != 0) lbID.Content = $"ID: {human.id}";
                lbLastName.Content = human.last_name;
                lbFirstName.Content = human.first_name;
                lbMiddleName.Content = human.middle_name;
                dpBirthDate.DataContext = Convert.ToDateTime(human.birth_date);
                lbEMail.Content = human.email;
                lbPhone.Content = human.phone;
            }
        }
        private void btBrowse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Files (*.*)|*.*| JPG Files (*.jpg)|*.jpg| JPEG Files (*.jpeg)|*.jpeg| PNG Files (*.png)|*.png";
            if (dialog.ShowDialog() == true) 
            {
                Uri uri = new Uri(dialog.FileName);
                imPhoto.Source = new BitmapImage(uri);
            }
        }

        protected virtual void btOK_Click(object sender, RoutedEventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            BitmapEncoder encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(imPhoto.Source as BitmapSource));
            encoder.Save(ms);
            human = new Models.Human
                (lbID.Content.ToString() == "" ? 0 : Convert.ToInt32(lbID.Content.ToString().Split(':').Last()), lbLastName.Content.ToString(), lbFirstName.Content.ToString(), lbMiddleName.Content.ToString(),
                dpBirthDate.ToString(), lbEMail.Content.ToString(), lbPhone.Content.ToString(), System.Drawing.Image.FromStream(ms));
        }
        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
