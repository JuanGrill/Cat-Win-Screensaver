namespace CatWin
{
    partial class ScreenSaverConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenSaverConfig));
            label1 = new Label();
            numYMovement = new NumericUpDown();
            label2 = new Label();
            numXMovement = new NumericUpDown();
            groupBox1 = new GroupBox();
            numSpeed = new NumericUpDown();
            label3 = new Label();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numYMovement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numXMovement).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSpeed).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 53);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Y movement";
            // 
            // numYMovement
            // 
            numYMovement.Location = new Point(105, 51);
            numYMovement.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numYMovement.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numYMovement.Name = "numYMovement";
            numYMovement.Size = new Size(70, 23);
            numYMovement.TabIndex = 1;
            numYMovement.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 24);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 2;
            label2.Text = "X movement";
            // 
            // numXMovement
            // 
            numXMovement.Location = new Point(105, 22);
            numXMovement.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numXMovement.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numXMovement.Name = "numXMovement";
            numXMovement.Size = new Size(70, 23);
            numXMovement.TabIndex = 3;
            numXMovement.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numSpeed);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(numYMovement);
            groupBox1.Controls.Add(numXMovement);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(181, 113);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configure";
            // 
            // numSpeed
            // 
            numSpeed.Location = new Point(105, 80);
            numSpeed.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSpeed.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSpeed.Name = "numSpeed";
            numSpeed.Size = new Size(70, 23);
            numSpeed.TabIndex = 5;
            numSpeed.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 82);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Speed";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(100, 131);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(93, 23);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ScreenSaverConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(205, 164);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.NoControl;
            Name = "ScreenSaverConfig";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cat-Win";
            ((System.ComponentModel.ISupportInitialize)numYMovement).EndInit();
            ((System.ComponentModel.ISupportInitialize)numXMovement).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSpeed).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private NumericUpDown numYMovement;
        private Label label2;
        private NumericUpDown numXMovement;
        private GroupBox groupBox1;
        private NumericUpDown numSpeed;
        private Label label3;
        private Button btnSave;
    }
}