using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    class ShadesNegative :Shades
    {
        public ShadesNegative(Bitmap image) : base(image)
        {
            
        }
       
        private protected override Bitmap Use(Color pixel,int height,int width)
        {
            newImage = new Bitmap(width, height);
            for (int h = 0; h < height; h++)
            {
                for (int w = 0; w < width; w++)
                {
                    pixel = oldImage.GetPixel(w, h);
                    pixel = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    newImage.SetPixel(w, h, pixel);
                }
            }
            return newImage;
        }
    }
}
