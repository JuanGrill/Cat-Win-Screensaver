using Microsoft.Win32;

namespace CatWin
{
    public static class Global
    {
        public static bool Exit { get; set; } = false;

        public static int MouseX { get; set; }

        public static int MouseY { get; set; }
    }

    public static class GlobalConf
    {
        public static int XMovement { get; set; }

        public static int YMovement { get; set; }

        public static int Speed { get; set; }

        public static void LoadSettings()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\CatWin");

            if (key == null)
            {
                XMovement = 10;
                YMovement = 10;
                Speed = 300;

                key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\CatWin");
                key.SetValue("X movement", XMovement);
                key.SetValue("Y movement", YMovement);
                key.SetValue("Speed", Speed);
            }
            else
            {
                try
                {
                    XMovement = (int)key.GetValue("X movement");
                    YMovement = (int)key.GetValue("Y movement");
                    Speed = (int)key.GetValue("Speed");
                }
                catch
                {
                    SaveSettings(10, 10, 300);
                }
            }
        }

        public static void SaveSettings(int xMovement, int yMovement, int speed)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\CatWin");
            key.SetValue("X movement", xMovement);
            key.SetValue("Y movement", yMovement);
            key.SetValue("Speed", speed);
        }
    }
}
