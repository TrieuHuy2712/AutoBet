using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBet.Application.Module
{
    public class InputSelectingAreaForm
    {
        public static Form selectForm;

        const int _ = 10; // you can rename this variable if you like
        public static Rectangle Top { get { return new Rectangle(0, 0, selectForm.ClientSize.Width, _); } }
        public static Rectangle Left { get { return new Rectangle(0, 0, _, selectForm.ClientSize.Height); } }
        public static Rectangle Bottom { get { return new Rectangle(0, selectForm.ClientSize.Height - _, selectForm.ClientSize.Width, _); } }
        public static Rectangle Right { get { return new Rectangle(selectForm.ClientSize.Width - _, 0, _, selectForm.ClientSize.Height); } }
        public static Rectangle TopLeft { get { return new Rectangle(0, 0, _, _); } }
        public static Rectangle TopRight { get { return new Rectangle(selectForm.ClientSize.Width - _, 0, _, _); } }
        public static Rectangle BottomLeft { get { return new Rectangle(0, selectForm.ClientSize.Height - _, _, _); } }
        public static Rectangle BottomRight { get { return new Rectangle(selectForm.ClientSize.Width - _, selectForm.ClientSize.Height - _, _, _); } }

    }
}
