using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    abstract class Shades : IChanger, IFilter
    {
        protected Bitmap oldImage;
        protected Bitmap newImage;
        protected Func<Color,int,int,Bitmap> changer;
        protected Shades(Bitmap image)
        {
            oldImage = image;
            changer = Use;
        }
        public Bitmap Apply()
        {
            Color pixel = new Color();
            int height = oldImage.Height;
            int width = oldImage.Width;
            newImage = new Bitmap(width, height);
            newImage = changer.Invoke(pixel,height,width);
            return newImage;
        }
        private protected virtual Bitmap Use(Color pixel,int height,int width)
        {
            return Cancel();
        }
        public Bitmap Cancel()
        {
            return oldImage;
        }

        public void changeImage(Bitmap image)
        {
            oldImage = image;
        }
    }
}
