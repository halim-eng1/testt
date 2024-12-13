using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testt
{

    public partial class Ministatment : Form
    {
        private string _cardNumber;

        public Ministatment(string cardNumber)
        {
            InitializeComponent();
            _cardNumber = cardNumber;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home home = new Home(_cardNumber);
            home.Show();
            this.Hide();
        }

        private void Ministatment_Load(object sender, EventArgs e)
        {

        }
    }
}
