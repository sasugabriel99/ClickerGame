using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
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
using MySql.Data.MySqlClient;

namespace ClickerGame
{
    public partial class LoginForm : Form
    {
        public static int HighScore { get; set; }
        public static int isAdmin { get; set; }

        public static string Username { get; set; }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;

        public LoginForm()
        {
            InitializeComponent();
        }

        public static void UpdateHighScore(int newHighScore)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;");
            try
            {
                connection.Open();
                string updateQuery = "UPDATE clickergame.userinfo SET highScore = @HighScore WHERE username = @Username;";
                MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);

                // Use the provided newHighScore and the static Username property
                updateCommand.Parameters.AddWithValue("@HighScore", newHighScore);
                updateCommand.Parameters.AddWithValue("@Username", Username);

                updateCommand.ExecuteNonQuery();

                // Update the static HighScore property
                HighScore = newHighScore;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating high score: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }



        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userTextBox.Text) || string.IsNullOrEmpty(passTextBox.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }

            else
            {
                connection.Open();
                string selectQuery = "SELECT * FROM clickergame.userinfo WHERE username = '" + userTextBox.Text + "' AND password = '" + passTextBox.Text + "';";
                command = new MySqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    Username = mdr["username"].ToString();

                    HighScore = mdr.GetInt32("highScore"); // Assuming column name is "HighScore"
                    isAdmin = mdr.GetInt32("is_admin");

                    //Debug.WriteLine($"Username: {Username}\nHighschore: {HighScore}\n isAdmin: {isAdmin}");

                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=";
                    //string Query = "update loginform._userinfo set LastLogin='" + dateTimePicker1.Value + "' where Username='" + this.txtUsername.Text + "';";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                    //MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    //MySqlDataReader MyReader2;
                    MyConn2.Open();
                    //MyReader2 = MyCommand2.ExecuteReader();
                    //while (MyReader2.Read())
                    //{
                    //}
                    MyConn2.Close();

                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    Game frm2 = new Game();
                    frm2.ShowDialog();

                }
                else
                {

                    MessageBox.Show("Incorrect Login Information! Try again.");
                }

                connection.Close();
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAccountForm frm3 = new CreateAccountForm();
            frm3.ShowDialog();
        }
    }
}
