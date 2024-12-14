using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace testt
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            // Conect to Database..
            string cardNumber = cardNumberTextBox.Text; // TextBox الخاص بـ Card Num
            string password = PasswordTextBox.Text;  // TextBox الخاص بـ Password

            // Connection String
            string connectionString = @"Data Source=HALIM\SQLEXPRESS;Initial Catalog=ATMDatabase;Integrated Security=True;TrustServerCertificate=True;";

            // SQL Query
            string query = "SELECT COUNT(*) FROM Users WHERE CardNumber = @CardNumber AND Password = @Password";

            // التحقق
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CardNumber", cardNumber);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    int userCount = (int)command.ExecuteScalar(); // يتحقق إذا كان المستخدم موجودًا

                    if (userCount > 0)
                    {
                        MessageBox.Show("Login successful!");

                        string CardNumber = userCount.ToString();
                        Home home = new Home(cardNumber);
                        home.Show();
                        this.Hide();

                        // افتح الصفحة الرئيسية أو أي إجراء آخر
                    }
                    else
                    {
                        MessageBox.Show("Invalid Card Number or Password.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }



        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
