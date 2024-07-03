using System.Runtime.InteropServices;

namespace CatWin
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GlobalConf.LoadSettings();

            if (Environment.GetCommandLineArgs().Length > 1)
            {
                //Configuration menu
                if (Environment.GetCommandLineArgs()[1].Contains("/c"))
                {
                    Application.Run(new ScreenSaverConfig());
                    return;
                }

                //Preview window
                else if (Environment.GetCommandLineArgs()[1].Contains("/p"))
                {
                    Application.Run(new ScreenSaver(0, new IntPtr(long.Parse(Environment.GetCommandLineArgs()[2]))));
                    return;
                }
            }

            //Show screensaver in more than one screen if there's any
            for (int i = 1; i < Screen.AllScreens.Length; i++)
            {
                //Derefer integer value
                int screenNumber = new int();
                screenNumber = i;
                Thread thread = new Thread(() => ThreadStart(screenNumber));
                thread.Start();
            }

            //Run screensaver in primary screen
            ScreenSaver screenSaver = new ScreenSaver(0);

            if (Environment.GetCommandLineArgs().Length > 1 && Environment.GetCommandLineArgs()[1] == "/l")
            {
                screenSaver.FormClosing += LockScreenEvent;
            }

            screenSaver.KeyDown += KeyPressEvent;
            Application.Run(screenSaver);
        }

        private static void ThreadStart(int screenNumber)
        {
            ScreenSaver screenSaver = new ScreenSaver(screenNumber);
            screenSaver.KeyDown += KeyPressEvent;
            Application.Run(screenSaver);
        }

        private static void LockScreenEvent(object sender, FormClosingEventArgs e)
        {
            LockWorkStation();
        }

        private static void KeyPressEvent(object sender, KeyEventArgs e)
        {
            Global.Exit = true;
        }

        [DllImport("user32.dll")]
        public static extern bool LockWorkStation();
    }
}