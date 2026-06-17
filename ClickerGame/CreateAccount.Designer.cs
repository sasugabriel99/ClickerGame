namespace ClickerGame
{
    partial class CreateAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelUsername = new Label();
            labelDate = new Label();
            labelMail = new Label();
            labelPassword = new Label();
            labelConPassword = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            buttonReturnLogin = new Button();
            buttonCreate = new Button();
            SuspendLayout();
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(12, 50);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(60, 15);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Username";
            labelUsername.Click += this.label1_Click;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(12, 81);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(73, 15);
            labelDate.TabIndex = 1;
            labelDate.Text = "Date of birth";
            labelDate.Click += this.label2_Click;
            // 
            // labelMail
            // 
            labelMail.AutoSize = true;
            labelMail.Location = new Point(12, 112);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(41, 15);
            labelMail.TabIndex = 2;
            labelMail.Text = "E-mail";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(12, 143);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 15);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password";
            // 
            // labelConPassword
            // 
            labelConPassword.AutoSize = true;
            labelConPassword.Location = new Point(12, 174);
            labelConPassword.Name = "labelConPassword";
            labelConPassword.Size = new Size(104, 15);
            labelConPassword.TabIndex = 4;
            labelConPassword.Text = "Confirm Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(195, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(195, 109);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(195, 140);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(187, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(195, 171);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(187, 23);
            textBox4.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Location = new Point(195, 80);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(187, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // buttonReturnLogin
            // 
            buttonReturnLogin.Location = new Point(12, 12);
            buttonReturnLogin.Name = "buttonReturnLogin";
            buttonReturnLogin.Size = new Size(104, 23);
            buttonReturnLogin.TabIndex = 9;
            buttonReturnLogin.Text = "Return to Login";
            buttonReturnLogin.UseVisualStyleBackColor = true;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(287, 215);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(95, 23);
            buttonCreate.TabIndex = 10;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += this.button1_Click;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCreate);
            Controls.Add(buttonReturnLogin);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelConPassword);
            Controls.Add(labelPassword);
            Controls.Add(labelMail);
            Controls.Add(labelDate);
            Controls.Add(labelUsername);
            Name = "CreateAccount";
            Text = "Form1";
            Load += this.CreateAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsername;
        private Label labelDate;
        private Label labelMail;
        private Label labelPassword;
        private Label labelConPassword;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private Button buttonReturnLogin;
        private Button buttonCreate;
    }
}