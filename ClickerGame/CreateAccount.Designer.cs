namespace ClickerGame
{
    partial class CreateAccountForm
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
            textUsername = new TextBox();
            textEmail = new TextBox();
            textPass = new TextBox();
            textPassCon = new TextBox();
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
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(12, 81);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(73, 15);
            labelDate.TabIndex = 1;
            labelDate.Text = "Date of birth";
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
            // textUsername
            // 
            textUsername.Location = new Point(195, 47);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(187, 23);
            textUsername.TabIndex = 5;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(195, 109);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(187, 23);
            textEmail.TabIndex = 6;
            // 
            // textPass
            // 
            textPass.Location = new Point(195, 140);
            textPass.Name = "textPass";
            textPass.Size = new Size(187, 23);
            textPass.TabIndex = 7;
            // 
            // textPassCon
            // 
            textPassCon.Location = new Point(195, 171);
            textPassCon.Name = "textPassCon";
            textPassCon.Size = new Size(187, 23);
            textPassCon.TabIndex = 8;
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
            buttonCreate.Click += buttonCreate_Click;
            // 
            // CreateAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCreate);
            Controls.Add(buttonReturnLogin);
            Controls.Add(dateTimePicker1);
            Controls.Add(textPassCon);
            Controls.Add(textPass);
            Controls.Add(textEmail);
            Controls.Add(textUsername);
            Controls.Add(labelConPassword);
            Controls.Add(labelPassword);
            Controls.Add(labelMail);
            Controls.Add(labelDate);
            Controls.Add(labelUsername);
            Name = "CreateAccountForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsername;
        private Label labelDate;
        private Label labelMail;
        private Label labelPassword;
        private Label labelConPassword;
        private TextBox textUsername;
        private TextBox textEmail;
        private TextBox textPass;
        private TextBox textPassCon;
        private DateTimePicker dateTimePicker1;
        private Button buttonReturnLogin;
        private Button buttonCreate;
    }
}