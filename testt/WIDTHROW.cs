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
    public partial class WIDTHROW : Form
    {
        private string _cardNumber;

        public WIDTHROW(string cardNumber)
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

        private void DisplayBalance()
        {
            decimal balance = DatabaseHelper.GetBalance(_cardNumber);
            Balancelbl.Text = $" {balance:c} ";
        }

        private void WIDTHROW_Load(object sender, EventArgs e)
        {
           DisplayBalance();
        }

        private void Balancelbl_Click(object sender, EventArgs e)
        {

        }
        //Withdrow Fun

        private void WithdrawAmount(decimal amount)
        {


            try
            {
                // تحقق من الرصيد الحالي
                decimal currentBalance = DatabaseHelper.GetBalance(_cardNumber);

                // التحقق إذا كان الرصيد كافٍ
                if (currentBalance >= amount && amount <= 8000)
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

        //Button click
        private void button1_Click(object sender, EventArgs e)
        {
           // decimal amountToWithdraw = Convert.ToDecimal(WithdrawAmountTextBox.Text); // قراءة المبلغ المدخل


            // التحقق من أن الحقل ليس فارغًا
            if (string.IsNullOrWhiteSpace(WithdrawAmountTextBox.Text))
            {
                MessageBox.Show("Please enter an amount to withdraw..!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                WithdrawAmountTextBox.Clear();
                return;
            }

            // محاولة تحويل القيمة إلى رقم
            if (!decimal.TryParse(WithdrawAmountTextBox.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount to withdraw!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                WithdrawAmountTextBox.Clear();
                return;
            }

            // متابعة العملية إذا كانت القيمة صحيحة
            ConfirmWithdraw(amount);
            WithdrawAmountTextBox.Clear();
        }

        // Anthoer way to make WITHDRAW....===========....................................//



            //decimal currentBalance = DatabaseHelper.GetBalance(_cardNumber); // استرجاع الرصيد الحالي

            //if (amountToWithdraw > 0 && amountToWithdraw <= currentBalance && amountToWithdraw <= 8000)
            //{
            //    bool success = DatabaseHelper.UpdateBalance(_cardNumber, amountToWithdraw);
            //    if (success)
            //    {
            //        MessageBox.Show($" {amountToWithdraw} pounds were successfully withdrawn.");
            //        Balancelbl.Text = $" {currentBalance - amountToWithdraw:c}"; // تحديث العرض
            //    }
            //    else
            //    {
            //        MessageBox.Show("Error during withdrawal. Please try again.");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Invalid withdrawal amount.");
            //}


        //}

        // confirm WithdrawAmount

        //private void ConfirmWithdraw(decimal amount)
        //{
        //    // إظهار رسالة تأكيد للمستخدم
        //    DialogResult result = MessageBox.Show(
        //        $"Do you want to withdraw {amount} pounds?",
        //        "تأكيد السحب",
        //        MessageBoxButtons.YesNo,
        //        MessageBoxIcon.Question
        //    );


        //    if (result == DialogResult.Yes)
        //    {
        //        amountToWithdraw(amount);
        //    }
        //    else
        //    {

        //        MessageBox.Show("The withdrawal has been cancelled..", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }

        //}

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void WithdrawAmountTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
