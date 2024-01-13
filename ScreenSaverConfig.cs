namespace CatWin
{
    public partial class ScreenSaverConfig : Form
    {
        public ScreenSaverConfig()
        {
            InitializeComponent();
            numXMovement.Value = GlobalConf.XMovement;
            numYMovement.Value = GlobalConf.YMovement;
            numSpeed.Value = GlobalConf.Speed;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GlobalConf.SaveSettings((int)numXMovement.Value, (int)numYMovement.Value, (int)numSpeed.Value);
            Close();
        }
    }
}
