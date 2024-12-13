namespace testt
{
    partial class StartUp
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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ATM;
            pictureBox1.Location = new Point(188, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(441, 430);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calisto MT", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(327, 395);
            label2.Name = "label2";
            label2.Size = new Size(178, 41);
            label2.TabIndex = 3;
            label2.Text = "loading %";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 440);
            panel2.Name = "panel2";
            panel2.Size = new Size(795, 10);
            panel2.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calisto MT", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(242, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(325, 50);
            label1.TabIndex = 13;
            label1.Text = "ATM SYSTEM";
            // 
            // StartUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(795, 450);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Enabled = false;
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "StartUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ATM";
            Load += StartUp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel2;
        private Label label1;
    }
}
