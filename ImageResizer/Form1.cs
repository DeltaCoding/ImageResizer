using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageResizer
{
    public partial class Form1 : Form
    {

        private Bitmap originalImage;
        private string filePath;

        public Form1()
        {
            InitializeComponent();
            this.openFileDialog1.Title = "Open Image";
            this.openFileDialog1.Filter = "JPG Files (*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png";
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.filePath = this.openFileDialog1.FileName;
                this.originalImage = new Bitmap(this.filePath);
                this.fileLocationTB.Text = this.filePath;
            }
        }

        private void resizeBtn_Click(object sender, EventArgs e)
        {
            string[] resolution = this.newResolutionTB.Text.Split('x');
            int width = Int32.Parse(resolution[0]);
            int height = Int32.Parse(resolution[1]);
            string newFilePath = "";

            Bitmap newImage = new Bitmap(width, height);
            newImage.SetResolution(this.originalImage.HorizontalResolution, this.originalImage.VerticalResolution);

            using(Graphics gr = Graphics.FromImage(newImage))
            {
                gr.SmoothingMode = SmoothingMode.HighQuality;
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                gr.DrawImage(this.originalImage, new Rectangle(0, 0, width, height));
            }

            if (!this.overwriteCB.Checked)
            {
                string[] tmp = this.filePath.Split('.');
                newFilePath = tmp[0] + " - " + this.newResolutionTB.Text + "." + tmp[tmp.Length - 1];
            }
            
            newImage.Save(newFilePath);

            MessageBox.Show("Your new image can be found here:\n" + (this.overwriteCB.Checked ? this.filePath : newFilePath));
        }
    }
}
