using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    class ShadesWhiteNoise:Shades
    {

        public ShadesWhiteNoise(Bitmap image) : base(image)
        {
            
        }
        private protected override Bitmap Use(Color pixel, int height, int width)
        {
            Random rand = new Random();
            for (int h = 0; h < height; h++)
            {
                for (int w = 0; w < width; w++)
                {
                    pixel = oldImage.GetPixel(w, h);
                    newImage.SetPixel(w, h, pixel);
                }
            }
            for (int i = 0; i < (int)(height * 0.8); i++)
            {
                for (int j = 0; j < (int)(width * 0.8); j++)
                {
                    newImage.SetPixel(rand.Next(0, width), rand.Next(0, height), Color.White);
                    newImage.SetPixel(rand.Next(0, width), rand.Next(0, height), Color.Black);
                }
            }
            return newImage;
        }
    }
}
