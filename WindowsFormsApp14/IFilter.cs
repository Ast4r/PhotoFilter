using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    interface IFilter
    {
        public Bitmap Apply();
        public Bitmap Cancel();
    }
}
