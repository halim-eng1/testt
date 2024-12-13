namespace testt
{
    partial class Ministatment
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
            label1 = new Label();
            label6 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            button7 = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(730, 97);
            panel1.TabIndex = 3;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calisto MT", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(203, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(325, 50);
            label1.TabIndex = 3;
            label1.Text = "ATM SYSTEM";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calisto MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(270, 101);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(256, 34);
            label2.TabIndex = 30;
            label2.Text = "MINI STATMINT";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 538);
            panel2.Name = "panel2";
            panel2.Size = new Size(730, 14);
            panel2.TabIndex = 32;
            // 
            // button7
            // 
            button7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button7.BackColor = SystemColors.InactiveBorder;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.DarkSlateGray;
            button7.Location = new Point(306, 485);
            button7.Name = "button7";
            button7.Size = new Size(123, 47);
            button7.TabIndex = 31;
            button7.Text = "Log Out";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 138);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(731, 341);
            dataGridView1.TabIndex = 33;
            // 
            // Ministatment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 552);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(button7);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ministatment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ministatment";
            Load += Ministatment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label6;
        private Label label2;
        private Panel panel2;
        private Button button7;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
    }
}