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
        private List<IFilter> filters;
        private ChangeImage changeImage;
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap image;
        private void button1_Click(object sender, EventArgs e)
        {
            image = new Bitmap("D:\\Image\\shakal.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = image;
            filters = new List<IFilter>();
            filters.Add(new ShadesNegative(image));
            filters.Add(new ShadesBlackAndWhite(image));
            filters.Add(new ShadesOfGray(image));
            trackBar1.Maximum = filters.Count-1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            changeImage = new ChangeImage(pictureBox1);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            changeImage.applyFilter(filters[trackBar1.Value]);
        }
    }
}
