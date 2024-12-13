using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testt
{
    public partial class Home : Form
    {
        public Home(string? fetchedCardNumber)
        {
            InitializeComponent();
            CardNumber = fetchedCardNumber ?? string.Empty;
        }



        public Home() : this(null) { }

        public string CardNumber { get; set; } = string.Empty;

        private void button5_Click(object sender, EventArgs e)
        {
            FastCash fast = new FastCash(CardNumber);
            fast.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BALANCE bal = new BALANCE(CardNumber);
            bal.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WIDTHROW wed = new WIDTHROW(CardNumber);
            wed.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ministatment mini = new Ministatment(CardNumber);
            mini.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DEBOSIT depo = new DEBOSIT(CardNumber);
            depo.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChangePin pin = new ChangePin(CardNumber);
            pin.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            CardNumlbl.Text = "CardNumber:"+ CardNumber;
            // Initialize UI or fetch data using CardNumber if needed
        }
    }

}
