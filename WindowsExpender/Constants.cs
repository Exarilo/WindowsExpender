using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsExpender
{
    class Constants
    {
        public const int defaultHeight = 100;
        public const int defaultWidth = 100;
        public static readonly int maxHeigh = Screen.PrimaryScreen.Bounds.Height;
        public static readonly int maxWidth = Screen.PrimaryScreen.Bounds.Width;
        public static readonly uint maxPixels = (uint)(maxHeigh * maxWidth);
    }
}
