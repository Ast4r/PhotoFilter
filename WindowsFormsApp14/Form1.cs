using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        private List<Shades> filters;
        private ChangeImage changeImage;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap image;
        private void button1_Click(object sender, EventArgs e)
        {
            setNewImage();
            updateFilters();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            changeImage = new ChangeImage(pictureBox1);
            MessageBox.Show("Выберете картинку");
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            openFileDialog.Filter = "Изображения |*.png;*.jpg";
            saveFileDialog.Filter = "Изображения |*.png;*.jpg";
            setNewImage();
            addFilters();
            trackBar1.Maximum = filters.Count - 1;
            Activate();
        } 
        private void addFilters()
        {
            filters = new List<Shades>();
            filters.Add(new ShadesNegative(image));
            filters.Add(new ShadesBlackAndWhite(image));
            filters.Add(new ShadesOfGray(image));
            filters.Add(new ShadesOnlyGreen(image));
            filters.Add(new ShadesMirror(image));
            filters.Add(new ShadesWhiteNoise(image));
            
        }
        private void setNewImage()
        {
            openFileDialog.ShowDialog();
            image = new Bitmap(openFileDialog.FileName);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = image;
        }
        private void updateFilters()
        {
            foreach(var x in filters)
            {
                x.changeImage(image);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            changeImage.applyFilter(filters[trackBar1.Value]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            { 
                pictureBox1.Image.Save(saveFileDialog.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = filters[0].Cancel();
        }
    }
}
