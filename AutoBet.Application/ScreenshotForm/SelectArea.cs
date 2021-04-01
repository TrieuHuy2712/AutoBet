using AutoBet.Application.Module;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoBet.Application.ScreenshotForm
{
    public partial class SelectArea : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public SelectArea()
        {
            InitializeComponent();
            Initialize_ConfigurationInputs();
        }

        void Initialize_ConfigurationInputs()
        {
            InputSelectingAreaForm.selectForm = this;
            StartPosition = FormStartPosition.Manual;
            Location = new Point(Cursor.Position.X, Cursor.Position.Y);
            FormBorderStyle = FormBorderStyle.None; // no borders
            Opacity = .9D; // make trasparent
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts
        }
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);
            if (message.Msg == 0x84) // WM_NCHITTEST
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (InputSelectingAreaForm.TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (InputSelectingAreaForm.TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (InputSelectingAreaForm.BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (InputSelectingAreaForm.BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;
                else if (InputSelectingAreaForm.Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (InputSelectingAreaForm.Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (InputSelectingAreaForm.Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (InputSelectingAreaForm.Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }
        }
        public const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

        private void SelectArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
                this.Close();
                InputConfigurationHandler.BindingImage(this.Location.X, this.Location.Y, this.Width, this.Height, this.Size);
            }
            
        }

        private void pnSelectArea_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}
