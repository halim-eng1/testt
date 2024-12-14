using Microsoft.Data.SqlClient;
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
    public partial class BALANCE : Form
    {
        private string _cardNumber;

        public BALANCE(string cardNumber)
        {
            InitializeComponent();
            _cardNumber = cardNumber;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        public static class DatabaseHelper
        {
            public static string ConnectionString = @"Data Source=HALIM\SQLEXPRESS;Initial Catalog=ATMDatabase;Integrated Security=True;TrustServerCertificate=True;";

            public static decimal GetBalance(string cardNumber)
            {
                decimal balance = 0;
                string query = "SELECT Balance FROM Users WHERE CardNumber = @CardNumber";

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CardNumber", cardNumber);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar(); // استرجاع الرصيد
                        if (result != null)
                        {
                            balance = Convert.ToDecimal(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }

                return balance;
            }
            // update Balance
            public static bool UpdateBalance(string cardNumber, decimal amount)
            {
                string query = "UPDATE Users SET Balance = Balance - @Amount WHERE CardNumber = @CardNumber";
                int rowsAffected = 0;

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Amount", amount);
                    command.Parameters.AddWithValue("@CardNumber", cardNumber);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }

                return rowsAffected > 0; // True إذا تم تحديث البيانات بنجاح
            }

            internal static decimal GetBalance(object cardNumber)
            {
                throw new NotImplementedException();
            }

            // Change Password

            public static bool ChangePassword(string cardNumber, string newPassword)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();
                        string query = "UPDATE Users SET Password = @Password WHERE CardNumber = @CardNumber";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Password", newPassword);
                            command.Parameters.AddWithValue("@CardNumber", cardNumber);

                            int rowsAffected = command.ExecuteNonQuery();
                            return rowsAffected > 0; // يرجع true إذا تم تحديث الصف
                        }
                    }
                }
                catch (Exception ex)
                {
                    // التعامل مع أي خطأ
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }


            //fast cash



            //public partial class FastCash : Form
            //{
            //    private string _cardNumber;

            //    public FastCash(string cardNumber)
            //    {

            //        _cardNumber = cardNumber;

            //        // عرض الرصيد عند تحميل الصفحة
            //        DisplayBalance();
            //    }

            //    private void DisplayBalance()
            //    {
            //        decimal balance = DatabaseHelper.GetBalance(_cardNumber);
            //        Balancelbl.Text = $" {balance:C}";
            //    }
            //}
        }

        private void BALANCE_Load(object sender, EventArgs e)
        {
            CardNumlbl.Text = _cardNumber;
            decimal balance = DatabaseHelper.GetBalance(_cardNumber);
            Balancelbl.Text = $" {balance:C}";
        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home home = new Home(_cardNumber);
            home.Show();
            this.Hide();

        }

        private void CardNumlbl_Click(object sender, EventArgs e)
        {

        }
    }
}
