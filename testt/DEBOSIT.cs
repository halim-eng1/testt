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
            DisplayBalance();
        }
        private void DisplayBalance()
        {
            decimal balance = DatabaseHelper.GetBalance(_cardNumber);
            Balancelbl.Text = $" {balance:c}";
        }

        private void DebositAmount(decimal amount)
        {


            try
            {
                // تحقق من الرصيد الحالي
                decimal currentBalance = DatabaseHelper.GetBalance(_cardNumber);

                // التحقق إذا كان الرصيد كافٍ
                if (amount > 0 && amount <= 30000)
                {
                    // تحديث الرصيد في قاعدة البيانات
                    DatabaseHelper.UpdateBalance(_cardNumber, -amount);

                    // تحديث واجهة المستخدم
                    DisplayBalance();
                    MessageBox.Show($" {amount} pounds were successfully deposited.");
                }
                else
                {
                    MessageBox.Show("Invalid Deeposited amount.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during depositing. Please try again. {ex.Message}");
            }
        }

        private void ConfirmDebosit(decimal amount)
        {
            // إظهار رسالة تأكيد الايداع للمستخدم
            DialogResult result = MessageBox.Show(
                $"Do you want to DEBOSIT {amount} pounds?",
                "CONFIRM",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );


            if (result == DialogResult.Yes)
            {
                DebositAmount(amount);
            }
            else
            {

                MessageBox.Show("The withdrawal has been cancelled..", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // التحقق من أن الحقل ليس فارغًا
            if (string.IsNullOrWhiteSpace(AmountToDepositTextBox.Text))
            {
                MessageBox.Show("Please enter an amount to DEBOSIT..!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AmountToDepositTextBox.Clear();
                return;
            }

            // محاولة تحويل القيمة إلى رقم
            if (!decimal.TryParse(AmountToDepositTextBox.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount to DEBOSIT!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AmountToDepositTextBox.Clear();
                return;
            }

            // متابعة العملية إذا كانت القيمة صحيحة
            ConfirmDebosit(amount);
            AmountToDepositTextBox.Clear();
        }

        // Anthoer way to make DEBOSIT....===========....................................//


            //decimal AmountToDeposit = Convert.ToDecimal(AmountToDepositTextBox.Text); // قراءة المبلغ المدخل
            //decimal currentBalance = DatabaseHelper.GetBalance(_cardNumber); // استرجاع الرصيد الحالي

            //if (AmountToDeposit > 0 && AmountToDeposit <= 30000)
            //{
            //    bool success = DatabaseHelper.UpdateBalance(_cardNumber, -AmountToDeposit);
            //    if (success)
            //    {
            //        MessageBox.Show($" {AmountToDeposit} pounds were successfully deposited.");
            //        Balancelbl.Text = $" {currentBalance + AmountToDeposit:c}"; // تحديث العرض
            //    }
            //    else
            //    {
            //        MessageBox.Show("Error during depositing. Please try again.");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Invalid Deeposited Amount.");
            //}
        //}

        private void Balancelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
