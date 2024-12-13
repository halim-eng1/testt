using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static testt.BALANCE;

namespace testt
{
    public partial class DEBOSIT : Form
    {
        private string _cardNumber;

        public DEBOSIT(string cardNumber)
        {
            InitializeComponent();
            _cardNumber = cardNumber;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home home = new Home(_cardNumber);
            home.Show();
            this.Hide();
        }

        private void DEBOSIT_Load(object sender, EventArgs e)
        {
            decimal balance = DatabaseHelper.GetBalance(_cardNumber);
            Balancelbl.Text = $" : {balance} ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal AmountToDeposit = Convert.ToDecimal(AmountToDepositTextBox.Text); // قراءة المبلغ المدخل
            decimal currentBalance = DatabaseHelper.GetBalance(_cardNumber); // استرجاع الرصيد الحالي

            if (AmountToDeposit > 0 && AmountToDeposit <= 30000)
            {
                bool success = DatabaseHelper.UpdateBalance(_cardNumber, -AmountToDeposit);
                if (success)
                {
                    MessageBox.Show($" {AmountToDeposit} pounds were successfully deposited.");
                    Balancelbl.Text = $" {currentBalance + AmountToDeposit:c}"; // تحديث العرض
                }
                else
                {
                    MessageBox.Show("Error during depositing. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Invalid Deeposited Amount.");
            }
        }
    }
}
