using System;
using System.Windows.Forms;
using System.Windows.Forms;

namespace testt
{
    public partial class StartUp : Form
    {
        private System.Windows.Forms.Timer timer;

        public StartUp()
        {
            InitializeComponent();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000;
            timer.Tick += Timer_Tick;
            timer.Start();

        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            timer!.Stop();// End Timer After Complete The Time

            Login log = new Login();
            log.Show();
            this.Hide();
        }


        private void StartUp_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
