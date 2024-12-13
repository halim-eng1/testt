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
    public partial class FastCash : Form
    {


        private string _cardNumber;

        public FastCash(string cardNumber)
        {
            InitializeComponent();
            _cardNumber = cardNumber;
        }


        public void DisplayBalance()
        {
            decimal balance = DatabaseHelper.GetBalance(_cardNumber);
            Balancelbl.Text = $" Available Balance: {balance:c} ";
        }



        private void WithdrawAmount(decimal amount)
        {


            try
            {
                // تحقق من الرصيد الحالي
                decimal currentBalance = DatabaseHelper.GetBalance(_cardNumber);

                // التحقق إذا كان الرصيد كافٍ
                if (currentBalance >= amount)
                {
                    // تحديث الرصيد في قاعدة البيانات
                    DatabaseHelper.UpdateBalance(_cardNumber, amount);

                    // تحديث واجهة المستخدم
                    DisplayBalance();
                    MessageBox.Show($" {amount} pounds were successfully withdrawn.");
                }
                else
                {
                    MessageBox.Show("Invalid withdrawal amount.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during withdrawal. Please try again. {ex.Message}");
            }
        }

        // confirm WithdrawAmount

        private void ConfirmWithdraw(decimal amount)
        {
            // إظهار رسالة تأكيد للمستخدم
            DialogResult result = MessageBox.Show(
                $"Do you want to withdraw {amount} pounds?",
                "تأكيد السحب",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );


            if (result == DialogResult.Yes)
            {
                WithdrawAmount(amount); 
            }
            else
            {

                MessageBox.Show("The withdrawal has been cancelled..", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }



        private void button5_Click(object sender, EventArgs e)
        {
            ConfirmWithdraw(200);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home home = new Home(_cardNumber);
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfirmWithdraw(100);

        }

        private void Balancelbl_Click(object sender, EventArgs e)
        {

        }

        private void FastCash_Load(object sender, EventArgs e)
        {
            DisplayBalance();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConfirmWithdraw(1000);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ConfirmWithdraw(5000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConfirmWithdraw(500);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConfirmWithdraw(2000);
        }
    }
}
