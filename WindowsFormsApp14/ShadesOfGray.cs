﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    class ShadesOfGray:Shades
    {

        public ShadesOfGray(Bitmap image) : base(image)
        {

        }
        private protected override Bitmap Use(Color pixel, int height, int width)
        {
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
    }
}
