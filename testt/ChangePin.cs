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
    public partial class ChangePin : Form
    {
        private string _cardNumber;

        public ChangePin(string cardNumber)
        {
            InitializeComponent();
            _cardNumber = cardNumber;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string newPassword = NewPasswordTextBox.Text.Trim();
            string confirmPassword = ConfirmPasswordTextBox.Text.Trim();

            // التحقق من المدخلات
            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please enter and confirm your new password..", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match.!", "Mismatch Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // استدعاء الدالة لتحديث الباسورد
            bool isPasswordChanged = DatabaseHelper.ChangePassword(_cardNumber, newPassword);

            if (isPasswordChanged)
            {
                MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewPasswordTextBox.Clear();
                ConfirmPasswordTextBox.Clear();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed to change password. Try again..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home home = new Home(_cardNumber);
            home.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NewPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
