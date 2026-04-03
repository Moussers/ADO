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

namespace Academy
{
    public abstract partial class HumanForm : Form
    {
        OpenFileDialog openFile;
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
                pathToPicture = openFile.FileName;
                pbPhoto.Load(pathToPicture);
                var pictureWidth = pbPhoto.ClientSize.Width;
                var pictureHeight = pbPhoto.ClientSize.Height;
            }
        }
    }
}
