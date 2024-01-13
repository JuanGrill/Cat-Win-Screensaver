using System.Resources;
using System.Runtime.InteropServices;

namespace CatWin
{
    public partial class ScreenSaver : Form
    {
        private Image CatWin;
        private Image CatWinSprite1;
        private Image CatWinSprite2;

        private ResourceManager resourceManager;

        private int xPos;
        private int yPos;

        private int xSpeed;
        private int ySpeed;
        private int timerInterval;

        private bool spriteChanger = false;
        private bool xPosChanger;
        private bool yPosChanger;

        private int imageWidth;
        private int imageHeight;

        private int mouseMoveDelay = 10;
        private int mouseMoveDelayCounter = 0;

        public ScreenSaver(int noScreen, IntPtr PreviewWindowdHandle = default)
        {
            InitializeComponent();
            LoadSettings();

            SetParent(this.Handle, PreviewWindowdHandle);

            this.WindowState = FormWindowState.Maximized;
            this.Bounds = Screen.AllScreens[noScreen].Bounds;

            this.TopMost = true;
            Cursor.Hide();

            resourceManager = new ResourceManager("CatWin.Properties.Resources", typeof(Program).Assembly);

            catTimer.Interval = timerInterval;
            catTimer.Start();

            Random rnd = new Random();
            xPosChanger = rnd.Next(2) == 0;
            yPosChanger = rnd.Next(2) == 0;

            Global.MouseX = Cursor.Position.X;
            Global.MouseY = Cursor.Position.Y;

            if (PreviewWindowdHandle == default)
            {
                CatWinSprite1 = (Image)resourceManager.GetObject("CatWin1");
                CatWinSprite2 = (Image)resourceManager.GetObject("CatWin2");
            }
            else
            {
                CatWinSprite1 = (Image)resourceManager.GetObject("CatWinPreview1");
                CatWinSprite2 = (Image)resourceManager.GetObject("CatWinPreview2");

                SetWindowLong(this.Handle, -16, new IntPtr(GetWindowLong(this.Handle, -16) | 0x40000000));
            }

            CatWin = CatWinSprite1;

            imageWidth = CatWin.Width;
            imageHeight = CatWin.Height;

            xPos = rnd.Next(1, Screen.AllScreens[noScreen].Bounds.Width - imageWidth - 1);
            yPos = rnd.Next(1, Screen.AllScreens[noScreen].Bounds.Height - imageHeight - 1);

            if (PreviewWindowdHandle != default)
            {
                xPos = 1;
                yPos = 1;
            }
        }

        private void LoadSettings()
        {
            xSpeed = GlobalConf.XMovement;
            ySpeed = GlobalConf.YMovement;
            timerInterval = GlobalConf.Speed;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.X > Global.MouseX || e.X < Global.MouseX ||
                e.Y > Global.MouseY || e.Y < Global.MouseY)
            {
                if (mouseMoveDelayCounter >= mouseMoveDelay)
                {
                    Global.Exit = true;
                }
            }
            Global.MouseX = e.X;
            Global.MouseY = e.Y;
        }

        private void CatTimer(object sender, EventArgs e)
        {
            CatWin = spriteChanger ? CatWinSprite1 : CatWinSprite2;
            spriteChanger = !spriteChanger;

            if (yPos < 0)
            {
                yPosChanger = false;
            }

            if (yPos > Height - imageHeight)
            {
                yPosChanger = true;
            }

            if (xPos < 0)
            {
                xPosChanger = false;
            }

            if (xPos > Width - imageWidth)
            {
                xPosChanger = true;
            }

            if (yPosChanger)
            {
                yPos -= ySpeed;
            }
            else
            {
                yPos += ySpeed;
            }

            if (xPosChanger)
            {
                xPos -= xSpeed;
            }
            else
            {
                xPos += xSpeed;
            }

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawImage(CatWin, xPos, yPos);
        }

        private void ExitTimer(object sender, EventArgs e)
        {
            if (mouseMoveDelayCounter < mouseMoveDelay)
            {
                mouseMoveDelayCounter += 1;
            }

            if (Global.Exit)
            {
                Application.Exit();
            }

            //testLabel.Text = "Screen: " + Screen.FromControl(this) + "\r\nX: " + Global.MouseX + " Y:" + Global.MouseY + "\r\nExit?: " + Global.Exit;
        }

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);
    }
}