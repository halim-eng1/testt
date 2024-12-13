
namespace testt
{
    partial class Home
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
            label6 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            button4 = new Button();
            button6 = new Button();
            button7 = new Button();
            panel2 = new Panel();
            CardNumlbl = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(730, 97);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calisto MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(696, 0);
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
            label1.Font = new Font("Calisto MT", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(116, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(517, 41);
            label1.TabIndex = 1;
            label1.Text = "Select Your Transaction Please";
            label1.Click += label1_Click_1;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.DarkSlateGray;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Sitka Small", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(43, 158);
            button1.Name = "button1";
            button1.Size = new Size(174, 51);
            button1.TabIndex = 10;
            button1.Text = "BALANCE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.BackColor = Color.DarkSlateGray;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Sitka Small", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(43, 243);
            button2.Name = "button2";
            button2.Size = new Size(174, 51);
            button2.TabIndex = 11;
            button2.Text = "WITHDRAW";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button3.BackColor = Color.DarkSlateGray;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Sitka Small", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(43, 331);
            button3.Name = "button3";
            button3.Size = new Size(174, 51);
            button3.TabIndex = 12;
            button3.Text = "DEBOSIT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button5.BackColor = Color.DarkSlateGray;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Sitka Small", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Transparent;
            button5.Location = new Point(508, 158);
            button5.Name = "button5";
            button5.Size = new Size(174, 51);
            button5.TabIndex = 14;
            button5.Text = "FAST CASH";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button4.BackColor = Color.DarkSlateGray;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Sitka Small", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Transparent;
            button4.Location = new Point(508, 243);
            button4.Name = "button4";
            button4.Size = new Size(174, 51);
            button4.TabIndex = 15;
            button4.Text = "MINI STATE";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button6.BackColor = Color.DarkSlateGray;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Sitka Small", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Transparent;
            button6.Location = new Point(508, 331);
            button6.Name = "button6";
            button6.Size = new Size(174, 51);
            button6.TabIndex = 16;
            button6.Text = "CHANG PIN";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button7.BackColor = SystemColors.InactiveBorder;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.DarkSlateGray;
            button7.Location = new Point(304, 439);
            button7.Name = "button7";
            button7.Size = new Size(123, 47);
            button7.TabIndex = 17;
            button7.Text = "Log Out";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 538);
            panel2.Name = "panel2";
            panel2.Size = new Size(730, 14);
            panel2.TabIndex = 18;
            // 
            // CardNumlbl
            // 
            CardNumlbl.AutoSize = true;
            CardNumlbl.Font = new Font("Calisto MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CardNumlbl.ForeColor = Color.DarkSlateGray;
            CardNumlbl.Location = new Point(211, 101);
            CardNumlbl.Margin = new Padding(4, 0, 4, 0);
            CardNumlbl.Name = "CardNumlbl";
            CardNumlbl.Size = new Size(137, 32);
            CardNumlbl.TabIndex = 19;
            CardNumlbl.Text = "CardNum";
            CardNumlbl.TextAlign = ContentAlignment.MiddleCenter;
            CardNumlbl.Click += CardNumlbl_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 552);
            Controls.Add(CardNumlbl);
            Controls.Add(panel2);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void CardNumlbl_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button4;
        private Button button6;
        private Button button7;
        private Panel panel2;
        private Label CardNumlbl;
    }
}