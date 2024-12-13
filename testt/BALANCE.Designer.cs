
namespace testt
{
    partial class BALANCE
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
            label5 = new Label();
            label2 = new Label();
            Balancelbl = new Label();
            CardNumlbl = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label1 = new Label();
            label7 = new Label();
            progressBar1 = new ProgressBar();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calisto MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(136, 167);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(194, 32);
            label5.TabIndex = 11;
            label5.Text = "Card Numper:";
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calisto MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(136, 233);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(191, 32);
            label2.TabIndex = 12;
            label2.Text = "Your Balance:";
            label2.Click += label2_Click;
            // 
            // Balancelbl
            // 
            Balancelbl.AutoSize = true;
            Balancelbl.Font = new Font("Calisto MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Balancelbl.ForeColor = Color.DarkSlateGray;
            Balancelbl.Location = new Point(347, 233);
            Balancelbl.Margin = new Padding(4, 0, 4, 0);
            Balancelbl.Name = "Balancelbl";
            Balancelbl.Size = new Size(184, 32);
            Balancelbl.TabIndex = 14;
            Balancelbl.Text = "BalancInCard";
            Balancelbl.Click += label3_Click;
            // 
            // CardNumlbl
            // 
            CardNumlbl.AutoSize = true;
            CardNumlbl.Font = new Font("Calisto MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CardNumlbl.ForeColor = Color.DarkSlateGray;
            CardNumlbl.Location = new Point(347, 167);
            CardNumlbl.Margin = new Padding(4, 0, 4, 0);
            CardNumlbl.Name = "CardNumlbl";
            CardNumlbl.Size = new Size(137, 32);
            CardNumlbl.TabIndex = 13;
            CardNumlbl.Text = "CardNum";
            CardNumlbl.Click += CardNumlbl_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(666, 93);
            panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.ARRWO;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calisto MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(631, 0);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(35, 39);
            label6.TabIndex = 2;
            label6.Text = "x";
            label6.Click += label6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calisto MT", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(154, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(325, 50);
            label1.TabIndex = 1;
            label1.Text = "ATM SYSTEM";
            label1.Click += label1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.GradientInactiveCaption;
            label7.Font = new Font("Calisto MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(286, 333);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(118, 32);
            label7.TabIndex = 16;
            label7.Text = "Log Out";
            label7.Click += label7_Click;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.DarkViolet;
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.ForeColor = Color.DarkSlateGray;
            progressBar1.Location = new Point(0, 391);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(666, 10);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 17;
            // 
            // BALANCE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 401);
            Controls.Add(progressBar1);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(Balancelbl);
            Controls.Add(CardNumlbl);
            Controls.Add(label2);
            Controls.Add(label5);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "BALANCE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BALANCE";
            Load += BALANCE_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Label label5;
        private Label label2;
        private Label Balancelbl;
        private Label CardNumlbl;
        private Panel panel1;
        private Label label6;
        private Label label1;
        private Label label7;
        private ProgressBar progressBar1;
        private PictureBox pictureBox1;
    }
}