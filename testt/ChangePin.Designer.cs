
namespace testt
{
    partial class ChangePin
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
            label2 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label7 = new Label();
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
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.ARRWO;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calisto MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(63, 218);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(166, 32);
            label2.TabIndex = 18;
            label2.Text = "Confirm Pin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calisto MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(63, 152);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(121, 32);
            label5.TabIndex = 17;
            label5.Text = "New Pin";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(259, 217);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(274, 27);
            textBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(259, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 27);
            textBox1.TabIndex = 19;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.DarkSlateGray;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(346, 264);
            button1.Name = "button1";
            button1.Size = new Size(103, 47);
            button1.TabIndex = 21;
            button1.Text = "CHANGE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(355, 326);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(85, 22);
            label7.TabIndex = 22;
            label7.Text = "Log Out";
            label7.Click += label7_Click;
            // 
            // ChangePin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 401);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(panel1);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePin";
            Load += ChangePin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void ChangePin_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label1;
        private Label label2;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Label label7;
        private PictureBox pictureBox1;
    }
}