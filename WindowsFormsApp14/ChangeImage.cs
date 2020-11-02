using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    class ChangeImage
    {
        PictureBox PictureBox { get; set; }
        Bitmap Image { get; set; }

        public ChangeImage(PictureBox pictureBox)
        {
            this.PictureBox = pictureBox;
        }
        public void applyFilter(IFilter filter)
        {
            PictureBox.Image = filter.Apply();
        }
    }
}
