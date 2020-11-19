using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    class ShadesMirror:Shades
    {
        
        public ShadesMirror(Bitmap image) : base(image)
        {
            
        }
        private protected override Bitmap Use(Color pixel, int height, int width)
        {
            for (int h = 0; h < height; h++)
            {
                for (int w = 0; w < width / 2; w++)
                {
                    pixel = oldImage.GetPixel(w, h);
                    newImage.SetPixel(width - w - 1, h, pixel);
                    newImage.SetPixel(w, h, pixel);
                }
            }
            return newImage;
        }
    }
}
