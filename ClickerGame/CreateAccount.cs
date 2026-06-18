using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerGame
{
    public partial class CreateAccountForm : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (!this.textEmail.Text.Contains('@') || !this.textEmail.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textPass.Text != textPassCon.Text)
            {
                MessageBox.Show("Password doesn't match!", "Error");
                return;
            }

            if (string.IsNullOrEmpty(textEmail.Text) || string.IsNullOrEmpty(textUsername.Text) || string.IsNullOrEmpty(textPass.Text) || string.IsNullOrEmpty(textPassCon.Text))
            {
                MessageBox.Show("Please fill out all information!", "Error");
                return;
            }

            else
            {
                connection.Open();

                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM clickergame.userinfo WHERE username = @UserName", connection),
                cmd2 = new MySqlCommand("SELECT * FROM clickergame.userinfo WHERE email = @UserEmail", connection);


                cmd1.Parameters.AddWithValue("@UserName", textUsername.Text);
                cmd2.Parameters.AddWithValue("@UserEmail", textEmail.Text);

                bool userExists = false, mailExists = false;

                using (var dr1 = cmd1.ExecuteReader())
                    if (userExists = dr1.HasRows) MessageBox.Show("Username not available!");

                using (var dr2 = cmd2.ExecuteReader())
                    if (mailExists = dr2.HasRows) MessageBox.Show("Email not available!");


                if (!(userExists || mailExists))
                {

                    string iquery = "INSERT INTO clickergame.userinfo(`id`,`birthday`,`email`,`username`, `password`) VALUES (NULL, '" + dateTimePicker1.Value.Date + "', '" + textEmail.Text + "', '" + textUsername.Text + "', '" + textPass.Text + "')";
                    MySqlCommand commandDatabase = new MySqlCommand(iquery, connection);
                    commandDatabase.CommandTimeout = 60;

                    try
                    {
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    }
                    catch (Exception ex)
                    {
                        // Show any error message.
                        MessageBox.Show(ex.Message);
                    }

                    MessageBox.Show("Account Successfully Created!");

                }

                connection.Close();
            }
        }

        private void buttonReturnLogin_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm frm4 = new LoginForm();
            frm4.ShowDialog();
        }
    }
}
