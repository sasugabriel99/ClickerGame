using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ClickerGame
{
    public partial class LoginForm : Form
    {
        public static int HighScore { get; set; }
        public static int isAdmin { get; set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        public static void UpdateHighScore(int newHighScore)
        {

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
            MessageBox.Show("Login Successful!");
            this.Hide();
            Game frm2 = new Game();
            frm2.ShowDialog();
        }
    }
}
