using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    class ShadesBlackAndWhite: IFilter
    {
        private Bitmap oldImage;
        private Bitmap newImage;

        public ShadesBlackAndWhite(Bitmap image)
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
                    if(pixel.R+pixel.G+pixel.B>= 255*3 / 2)
                    {
                        pixel = Color.Black;
                    }
                    else
                    {
                        pixel = Color.White;
                    }
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
