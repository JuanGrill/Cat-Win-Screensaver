namespace CatWin
{
    partial class ScreenSaver
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenSaver));
            catTimer = new System.Windows.Forms.Timer(components);
            exitTimer = new System.Windows.Forms.Timer(components);
            testLabel = new Label();
            SuspendLayout();
            // 
            // catTimer
            // 
            catTimer.Tick += CatTimer;
            // 
            // exitTimer
            // 
            exitTimer.Enabled = true;
            exitTimer.Interval = 10;
            exitTimer.Tick += ExitTimer;
            // 
            // testLabel
            // 
            testLabel.AutoSize = true;
            testLabel.BackColor = Color.Transparent;
            testLabel.ForeColor = Color.White;
            testLabel.Location = new Point(12, 9);
            testLabel.Name = "testLabel";
            testLabel.Size = new Size(0, 15);
            testLabel.TabIndex = 0;
            // 
            // ScreenSaver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 600);
            Controls.Add(testLabel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ScreenSaver";
            Text = "Cat-Win";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timerAnim;
        private System.Windows.Forms.Timer catTimer;
        private System.Windows.Forms.Timer exitTimer;
        private Label testLabel;
    }
}