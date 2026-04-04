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
using System.IO;

namespace Academy
{
    public abstract partial class HumanForm : Form
    {
        protected OpenFileDialog openFile;
        string pathToPicture;
        public HumanForm()
        {
            InitializeComponent();
            openFile = new OpenFileDialog();
            openFile.Filter = 
                "All Image File (*.BMP;*.JPG;*.JPEG;*.PNG;*.TIFF)" +
                "|*.BMP;*JPG;*JPEG;*.PNG;*.TIFF|BMP Files (*.BMP)" +
                "|*.BMP|JPG Files (*.JPG)|*.JPG|JPEG Files (*.JPEG)" +
                "|*.JPEG|PNG Files(*.PNG)|*.PNG|TIFF Files (*.TIFF)|.TIFF ";
        }

        protected abstract void buttonOK_Click(object sender, EventArgs e);

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK) 
            {
                try
                {
                    pbPhoto.Image = new Bitmap(openFile.FileName);
                    //StrightImage - растягивает картинку до краев.
                    //Zoom - увеличивает пропорции картинки так чтобы её сохранить, но не растягивает. 


                }
                catch (Exception ex) 
                {
                    MessageBox.Show($"Ошибка при открытии выбранного файла {Path.GetFileName(openFile.FileName)}!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
