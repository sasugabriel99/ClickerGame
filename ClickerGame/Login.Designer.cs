namespace ClickerGame
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userName = new Label();
            password = new Label();
            userTextBox = new TextBox();
            passTextBox = new TextBox();
            buttonLogin = new Button();
            buttonCreate = new Button();
            SuspendLayout();
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Location = new Point(26, 33);
            userName.Name = "userName";
            userName.Size = new Size(60, 15);
            userName.TabIndex = 0;
            userName.Text = "Username";
            userName.Click += label1_Click;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(29, 75);
            password.Name = "password";
            password.Size = new Size(57, 15);
            password.TabIndex = 1;
            password.Text = "Password";
            password.Click += label1_Click_1;
            // 
            // userTextBox
            // 
            userTextBox.Location = new Point(122, 30);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(213, 23);
            userTextBox.TabIndex = 2;
            // 
            // passTextBox
            // 
            passTextBox.Location = new Point(122, 72);
            passTextBox.Name = "passTextBox";
            passTextBox.Size = new Size(213, 23);
            passTextBox.TabIndex = 3;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(122, 147);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(96, 39);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(239, 147);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(96, 39);
            buttonCreate.TabIndex = 5;
            buttonCreate.Text = "Create an Account";
            buttonCreate.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 245);
            Controls.Add(buttonCreate);
            Controls.Add(buttonLogin);
            Controls.Add(passTextBox);
            Controls.Add(userTextBox);
            Controls.Add(password);
            Controls.Add(userName);
            Name = "LoginForm";
            Text = "Clicker Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userName;
        private Label password;
        private TextBox userTextBox;
        private TextBox passTextBox;
        private Button buttonLogin;
        private Button buttonCreate;
    }
}
