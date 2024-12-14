namespace testt
{
    partial class DEBOSIT
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label1 = new Label();
            button1 = new Button();
            AmountToDepositTextBox = new TextBox();
            label5 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            Balancelbl = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.ARRWO;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
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
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.DarkSlateGray;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(315, 311);
            button1.Name = "button1";
            button1.Size = new Size(103, 47);
            button1.TabIndex = 24;
            button1.Text = "DEPOSIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AmountToDepositTextBox
            // 
            AmountToDepositTextBox.Location = new Point(225, 236);
            AmountToDepositTextBox.Name = "AmountToDepositTextBox";
            AmountToDepositTextBox.Size = new Size(295, 27);
            AmountToDepositTextBox.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calisto MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(50, 236);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(116, 32);
            label5.TabIndex = 22;
            label5.Text = "Amount";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(324, 365);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(85, 22);
            label7.TabIndex = 25;
            label7.Text = "Log Out";
            label7.Click += label7_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 391);
            panel2.Name = "panel2";
            panel2.Size = new Size(666, 10);
            panel2.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calisto MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(292, 113);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(151, 34);
            label2.TabIndex = 27;
            label2.Text = "DEPOSIT";
            label2.Click += label2_Click;
            // 
            // Balancelbl
            // 
            Balancelbl.AutoSize = true;
            Balancelbl.Font = new Font("Calisto MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Balancelbl.ForeColor = Color.DarkSlateGray;
            Balancelbl.Location = new Point(366, 168);
            Balancelbl.Margin = new Padding(4, 0, 4, 0);
            Balancelbl.Name = "Balancelbl";
            Balancelbl.Size = new Size(184, 32);
            Balancelbl.TabIndex = 37;
            Balancelbl.Text = "BalancInCard";
            Balancelbl.Click += Balancelbl_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calisto MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(116, 168);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(260, 34);
            label3.TabIndex = 36;
            label3.Text = "Available Balance:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(231, 266);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(281, 18);
            label4.TabIndex = 38;
            label4.Text = "The maximum deposit is 30,000 at a time.";
            // 
            // DEBOSIT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 401);
            Controls.Add(label4);
            Controls.Add(Balancelbl);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(AmountToDepositTextBox);
            Controls.Add(label5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DEBOSIT";
            StartPosition = FormStartPosition.CenterScreen;
            Load += DEBOSIT_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label1;
        private Button button1;
        private TextBox AmountToDepositTextBox;
        private Label label5;
        private Label label7;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private Label Balancelbl;
        private Label label3;
        private Label label4;
    }
}