using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    class ShadesBlackAndWhite:Shades
    {
        
        public ShadesBlackAndWhite(Bitmap image) : base(image)
        {

        }
        private protected override Bitmap Use(Color pixel, int height, int width)
        {
            for (int h = 0; h < height; h++)
            {
                for (int w = 0; w < width; w++)
                {
                    pixel = oldImage.GetPixel(w, h);
                    if (pixel.R + pixel.G + pixel.B >= 255 * 3 / 2)
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
    }
}
