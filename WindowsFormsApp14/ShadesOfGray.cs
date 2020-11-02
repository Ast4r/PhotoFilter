using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    class ShadesOfGray:IFilter
    {
        private Bitmap oldImage;
        private Bitmap newImage;

        public ShadesOfGray(Bitmap image)
        {
            oldImage = image;
        }
        public Bitmap Apply()
        {
            Color pixel;
            int height = oldImage.Height;
            int width = oldImage.Width;
            newImage = new Bitmap(width, height);
            for (int h = 0; h < height; h++)
            {
                for (int w = 0; w < width; w++)
                {
                    pixel = oldImage.GetPixel(w, h);
                    pixel = Color.FromArgb(pixel.R, pixel.R, pixel.R);
                    newImage.SetPixel(w, h, pixel);
                }
            }
            return newImage;
        }

        public Bitmap Cancel(Bitmap image)
        {
            return oldImage;
        }

        public void changeImage(Bitmap image)
        {
            oldImage = image;
        }
    }
}
