namespace ClickerGame
{
    partial class Game
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            protectionIcon = new PictureBox();
            autoclickerOpacityIcon = new PictureBox();
            bonusOpacityIcon = new PictureBox();
            rewindOpacityIcon = new PictureBox();
            magnetOpacityIcon = new PictureBox();
            extraLifeOpacityIcon = new PictureBox();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            pictureBox1 = new PictureBox();
            imgMultiplier = new PictureBox();
            imgDecay = new PictureBox();
            pictureBoxMultiplier = new PictureBox();
            pictureBoxDecay = new PictureBox();
            resetScoreBtn = new Button();
            hundredScoreAddBtn = new Button();
            resetMultiplierBtn = new Button();
            thousandScoreAddBtn = new Button();
            resetDecayBtn = new Button();
            timerLabel = new Label();
            scoreLabel = new Label();
            highscoreLabel = new Label();
            btnStart = new Button();
            btnLogout = new Button();
            playAgainButton = new Button();
            debugMode = new CheckBox();
            label2 = new Label();
            labelButton1 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            protectionDurationLabel = new Label();
            magnetFlagLabel = new Label();
            valueMagnetLabel = new Label();
            scoreMagnetDurationLabel = new Label();
            extraLifeDurationLabel = new Label();
            multiplierLabel = new Label();
            decayRateLabel = new Label();
            decayTimerLabel = new Label();
            countdownTimer = new System.Windows.Forms.Timer(components);
            pictureBox2 = new PictureBox();
            autoclickerIcon = new PictureBox();
            bonusIcon = new PictureBox();
            rewindIcon = new PictureBox();
            magnetIcon = new PictureBox();
            extraLifeIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)protectionIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)autoclickerOpacityIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bonusOpacityIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rewindOpacityIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)magnetOpacityIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)extraLifeOpacityIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgMultiplier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgDecay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMultiplier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDecay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)autoclickerIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bonusIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rewindIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)magnetIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)extraLifeIcon).BeginInit();
            SuspendLayout();
            // 
            // protectionIcon
            // 
            protectionIcon.BackColor = Color.Transparent;
            protectionIcon.BackgroundImage = Properties.Resources.protectionDisabled;
            protectionIcon.BackgroundImageLayout = ImageLayout.Zoom;
            protectionIcon.Enabled = false;
            protectionIcon.ErrorImage = null;
            protectionIcon.ImageLocation = "0,0";
            protectionIcon.InitialImage = null;
            protectionIcon.Location = new Point(36, 13);
            protectionIcon.Name = "protectionIcon";
            protectionIcon.Size = new Size(30, 30);
            protectionIcon.TabIndex = 43;
            protectionIcon.TabStop = false;
            // 
            // autoclickerOpacityIcon
            // 
            autoclickerOpacityIcon.BackColor = Color.Transparent;
            autoclickerOpacityIcon.BackgroundImage = Properties.Resources.automationDisabled;
            autoclickerOpacityIcon.BackgroundImageLayout = ImageLayout.Zoom;
            autoclickerOpacityIcon.Location = new Point(72, 13);
            autoclickerOpacityIcon.Name = "autoclickerOpacityIcon";
            autoclickerOpacityIcon.Size = new Size(30, 30);
            autoclickerOpacityIcon.TabIndex = 1;
            autoclickerOpacityIcon.TabStop = false;
            // 
            // bonusOpacityIcon
            // 
            bonusOpacityIcon.BackColor = Color.Transparent;
            bonusOpacityIcon.BackgroundImage = Properties.Resources.bonusDisabled;
            bonusOpacityIcon.BackgroundImageLayout = ImageLayout.Zoom;
            bonusOpacityIcon.Location = new Point(108, 13);
            bonusOpacityIcon.Name = "bonusOpacityIcon";
            bonusOpacityIcon.Size = new Size(30, 30);
            bonusOpacityIcon.TabIndex = 2;
            bonusOpacityIcon.TabStop = false;
            // 
            // rewindOpacityIcon
            // 
            rewindOpacityIcon.BackColor = Color.Transparent;
            rewindOpacityIcon.BackgroundImage = Properties.Resources.reverseDisabled;
            rewindOpacityIcon.BackgroundImageLayout = ImageLayout.Zoom;
            rewindOpacityIcon.Location = new Point(142, 13);
            rewindOpacityIcon.Name = "rewindOpacityIcon";
            rewindOpacityIcon.Size = new Size(30, 30);
            rewindOpacityIcon.TabIndex = 3;
            rewindOpacityIcon.TabStop = false;
            // 
            // magnetOpacityIcon
            // 
            magnetOpacityIcon.BackColor = Color.Transparent;
            magnetOpacityIcon.BackgroundImage = Properties.Resources.MagnetDisabled;
            magnetOpacityIcon.BackgroundImageLayout = ImageLayout.Zoom;
            magnetOpacityIcon.Location = new Point(178, 13);
            magnetOpacityIcon.Name = "magnetOpacityIcon";
            magnetOpacityIcon.Size = new Size(30, 30);
            magnetOpacityIcon.TabIndex = 4;
            magnetOpacityIcon.TabStop = false;
            // 
            // extraLifeOpacityIcon
            // 
            extraLifeOpacityIcon.BackColor = Color.Transparent;
            extraLifeOpacityIcon.BackgroundImage = Properties.Resources.extraLifeDisabled;
            extraLifeOpacityIcon.BackgroundImageLayout = ImageLayout.Zoom;
            extraLifeOpacityIcon.Location = new Point(214, 13);
            extraLifeOpacityIcon.Name = "extraLifeOpacityIcon";
            extraLifeOpacityIcon.Size = new Size(30, 30);
            extraLifeOpacityIcon.TabIndex = 5;
            extraLifeOpacityIcon.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.environment_protection;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(36, 140);
            button1.Name = "button1";
            button1.Size = new Size(100, 100);
            button1.TabIndex = 6;
            button1.Text = "00";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = Properties.Resources.plus;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(36, 246);
            button3.Name = "button3";
            button3.Size = new Size(100, 100);
            button3.TabIndex = 7;
            button3.Text = "00";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.multiplier;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(142, 140);
            button2.Name = "button2";
            button2.Size = new Size(100, 100);
            button2.TabIndex = 8;
            button2.Text = "00";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = Properties.Resources.automation;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(142, 246);
            button4.Name = "button4";
            button4.Size = new Size(100, 100);
            button4.TabIndex = 9;
            button4.Text = "00";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.BackgroundImage = Properties.Resources.bonus;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(537, 140);
            button5.Name = "button5";
            button5.Size = new Size(100, 100);
            button5.TabIndex = 10;
            button5.Text = "00";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.BackgroundImage = Properties.Resources.reverse;
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(643, 140);
            button6.Name = "button6";
            button6.Size = new Size(100, 100);
            button6.TabIndex = 11;
            button6.Text = "00";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.BackgroundImage = Properties.Resources.Magnet;
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(537, 246);
            button7.Name = "button7";
            button7.Size = new Size(100, 100);
            button7.TabIndex = 12;
            button7.Text = "00";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Transparent;
            button8.BackgroundImage = Properties.Resources.extraLife;
            button8.BackgroundImageLayout = ImageLayout.Zoom;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.Black;
            button8.Location = new Point(643, 246);
            button8.Name = "button8";
            button8.Size = new Size(100, 100);
            button8.TabIndex = 13;
            button8.Text = "00";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(289, 146);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // imgMultiplier
            // 
            imgMultiplier.BackColor = Color.Transparent;
            imgMultiplier.BackgroundImage = Properties.Resources.multiplier1;
            imgMultiplier.BackgroundImageLayout = ImageLayout.Zoom;
            imgMultiplier.Location = new Point(289, 382);
            imgMultiplier.Name = "imgMultiplier";
            imgMultiplier.Size = new Size(50, 50);
            imgMultiplier.TabIndex = 15;
            imgMultiplier.TabStop = false;
            // 
            // imgDecay
            // 
            imgDecay.BackColor = Color.Transparent;
            imgDecay.BackgroundImage = Properties.Resources.decay1;
            imgDecay.BackgroundImageLayout = ImageLayout.Zoom;
            imgDecay.Location = new Point(439, 382);
            imgDecay.Name = "imgDecay";
            imgDecay.Size = new Size(50, 50);
            imgDecay.TabIndex = 16;
            imgDecay.TabStop = false;
            // 
            // pictureBoxMultiplier
            // 
            pictureBoxMultiplier.BackColor = Color.Transparent;
            pictureBoxMultiplier.BackgroundImage = Properties.Resources.multiplier1;
            pictureBoxMultiplier.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxMultiplier.Location = new Point(250, 59);
            pictureBoxMultiplier.Name = "pictureBoxMultiplier";
            pictureBoxMultiplier.Size = new Size(50, 50);
            pictureBoxMultiplier.TabIndex = 17;
            pictureBoxMultiplier.TabStop = false;
            // 
            // pictureBoxDecay
            // 
            pictureBoxDecay.BackColor = Color.Transparent;
            pictureBoxDecay.BackgroundImage = Properties.Resources.decay1;
            pictureBoxDecay.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxDecay.Location = new Point(473, 59);
            pictureBoxDecay.Name = "pictureBoxDecay";
            pictureBoxDecay.Size = new Size(50, 50);
            pictureBoxDecay.TabIndex = 18;
            pictureBoxDecay.TabStop = false;
            // 
            // resetScoreBtn
            // 
            resetScoreBtn.BackColor = Color.Transparent;
            resetScoreBtn.BackgroundImageLayout = ImageLayout.Zoom;
            resetScoreBtn.FlatStyle = FlatStyle.Popup;
            resetScoreBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resetScoreBtn.ForeColor = SystemColors.ControlText;
            resetScoreBtn.Location = new Point(537, 12);
            resetScoreBtn.Name = "resetScoreBtn";
            resetScoreBtn.Size = new Size(57, 57);
            resetScoreBtn.TabIndex = 19;
            resetScoreBtn.Text = "Reset Score";
            resetScoreBtn.UseVisualStyleBackColor = false;
            resetScoreBtn.Click += resetScoreBtn_Click;
            // 
            // hundredScoreAddBtn
            // 
            hundredScoreAddBtn.BackColor = Color.Transparent;
            hundredScoreAddBtn.BackgroundImageLayout = ImageLayout.Zoom;
            hundredScoreAddBtn.FlatStyle = FlatStyle.Popup;
            hundredScoreAddBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hundredScoreAddBtn.ForeColor = SystemColors.ControlText;
            hundredScoreAddBtn.Location = new Point(537, 75);
            hundredScoreAddBtn.Name = "hundredScoreAddBtn";
            hundredScoreAddBtn.Size = new Size(57, 57);
            hundredScoreAddBtn.TabIndex = 20;
            hundredScoreAddBtn.Text = "+ 100";
            hundredScoreAddBtn.UseVisualStyleBackColor = false;
            hundredScoreAddBtn.Click += hundredScoreAddBtn_Click;
            // 
            // resetMultiplierBtn
            // 
            resetMultiplierBtn.BackColor = Color.Transparent;
            resetMultiplierBtn.BackgroundImageLayout = ImageLayout.Zoom;
            resetMultiplierBtn.FlatStyle = FlatStyle.Popup;
            resetMultiplierBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resetMultiplierBtn.ForeColor = SystemColors.ControlText;
            resetMultiplierBtn.Location = new Point(610, 12);
            resetMultiplierBtn.Name = "resetMultiplierBtn";
            resetMultiplierBtn.Size = new Size(57, 57);
            resetMultiplierBtn.TabIndex = 21;
            resetMultiplierBtn.Text = "Reset Multiplier";
            resetMultiplierBtn.UseVisualStyleBackColor = false;
            resetMultiplierBtn.Click += resetMultiplierBtn_Click;
            // 
            // thousandScoreAddBtn
            // 
            thousandScoreAddBtn.BackColor = Color.Transparent;
            thousandScoreAddBtn.BackgroundImageLayout = ImageLayout.Zoom;
            thousandScoreAddBtn.FlatStyle = FlatStyle.Popup;
            thousandScoreAddBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            thousandScoreAddBtn.ForeColor = SystemColors.ControlText;
            thousandScoreAddBtn.Location = new Point(610, 75);
            thousandScoreAddBtn.Name = "thousandScoreAddBtn";
            thousandScoreAddBtn.Size = new Size(57, 57);
            thousandScoreAddBtn.TabIndex = 22;
            thousandScoreAddBtn.Text = "+ 1000";
            thousandScoreAddBtn.UseVisualStyleBackColor = false;
            thousandScoreAddBtn.Click += thousandScoreAddBtn_Click;
            // 
            // resetDecayBtn
            // 
            resetDecayBtn.BackColor = Color.Transparent;
            resetDecayBtn.BackgroundImageLayout = ImageLayout.Zoom;
            resetDecayBtn.FlatStyle = FlatStyle.Popup;
            resetDecayBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resetDecayBtn.ForeColor = SystemColors.ControlText;
            resetDecayBtn.Location = new Point(686, 75);
            resetDecayBtn.Name = "resetDecayBtn";
            resetDecayBtn.Size = new Size(57, 57);
            resetDecayBtn.TabIndex = 23;
            resetDecayBtn.Text = "Reset Decay";
            resetDecayBtn.UseVisualStyleBackColor = false;
            resetDecayBtn.Click += resetDecayBtn_Click;
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.BackColor = Color.Transparent;
            timerLabel.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timerLabel.ForeColor = Color.FromArgb(192, 0, 0);
            timerLabel.Location = new Point(345, 12);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(87, 31);
            timerLabel.TabIndex = 61;
            timerLabel.Text = "00:00";
            timerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // scoreLabel
            // 
            scoreLabel.Anchor = AnchorStyles.None;
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreLabel.Location = new Point(307, 61);
            scoreLabel.Margin = new Padding(4, 0, 4, 0);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(161, 42);
            scoreLabel.TabIndex = 62;
            scoreLabel.Text = "<score>";
            scoreLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // highscoreLabel
            // 
            highscoreLabel.AutoSize = true;
            highscoreLabel.Location = new Point(355, 49);
            highscoreLabel.Margin = new Padding(4, 0, 4, 0);
            highscoreLabel.Name = "highscoreLabel";
            highscoreLabel.Size = new Size(64, 15);
            highscoreLabel.TabIndex = 64;
            highscoreLabel.Text = "Highscore:";
            highscoreLabel.TextAlign = ContentAlignment.MiddleCenter;
            highscoreLabel.Visible = false;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.OliveDrab;
            btnStart.FlatStyle = FlatStyle.Popup;
            btnStart.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(339, 105);
            btnStart.Margin = new Padding(4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(88, 26);
            btnStart.TabIndex = 65;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(255, 128, 128);
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(707, 7);
            btnLogout.Margin = new Padding(4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(80, 35);
            btnLogout.TabIndex = 66;
            btnLogout.Text = "LOG OUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // playAgainButton
            // 
            playAgainButton.BackColor = Color.FromArgb(192, 255, 192);
            playAgainButton.FlatStyle = FlatStyle.Popup;
            playAgainButton.Location = new Point(707, 50);
            playAgainButton.Margin = new Padding(4);
            playAgainButton.Name = "playAgainButton";
            playAgainButton.Size = new Size(80, 36);
            playAgainButton.TabIndex = 67;
            playAgainButton.Text = "Play Again";
            playAgainButton.UseVisualStyleBackColor = false;
            playAgainButton.Visible = false;
            playAgainButton.Click += playAgainButton_Click;
            // 
            // debugMode
            // 
            debugMode.AutoSize = true;
            debugMode.BackColor = Color.Transparent;
            debugMode.CheckAlign = ContentAlignment.MiddleRight;
            debugMode.Location = new Point(677, 371);
            debugMode.Margin = new Padding(4);
            debugMode.Name = "debugMode";
            debugMode.Size = new Size(95, 19);
            debugMode.TabIndex = 68;
            debugMode.Text = "Debug Mode";
            debugMode.UseVisualStyleBackColor = false;
            debugMode.Visible = false;
            debugMode.CheckedChanged += debugMode_CheckedChanged;
            debugMode.CheckStateChanged += debugMode_CheckStateChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(311, 349);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 25);
            label2.TabIndex = 69;
            label2.Text = "Click the leaf!";
            // 
            // labelButton1
            // 
            labelButton1.AutoSize = true;
            labelButton1.BackColor = Color.OldLace;
            labelButton1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelButton1.Location = new Point(89, 222);
            labelButton1.Margin = new Padding(4, 0, 4, 0);
            labelButton1.Name = "labelButton1";
            labelButton1.Size = new Size(46, 18);
            labelButton1.TabIndex = 70;
            labelButton1.Text = "label1";
            labelButton1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.OldLace;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(196, 222);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 18);
            label1.TabIndex = 71;
            label1.Text = "label2";
            label1.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.OldLace;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(92, 328);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 18);
            label3.TabIndex = 72;
            label3.Text = "label3";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.OldLace;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(196, 328);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 18);
            label4.TabIndex = 73;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.OldLace;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(590, 222);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(46, 18);
            label5.TabIndex = 74;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.OldLace;
            label6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(697, 222);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(46, 18);
            label6.TabIndex = 75;
            label6.Text = "label6";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.OldLace;
            label7.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(591, 328);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(46, 18);
            label7.TabIndex = 76;
            label7.Text = "label7";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.OldLace;
            label8.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(697, 328);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(46, 18);
            label8.TabIndex = 77;
            label8.Text = "label8";
            label8.Visible = false;
            // 
            // protectionDurationLabel
            // 
            protectionDurationLabel.AutoSize = true;
            protectionDurationLabel.Location = new Point(10, 225);
            protectionDurationLabel.Margin = new Padding(4, 0, 4, 0);
            protectionDurationLabel.Name = "protectionDurationLabel";
            protectionDurationLabel.Size = new Size(19, 15);
            protectionDurationLabel.TabIndex = 78;
            protectionDurationLabel.Text = "00";
            protectionDurationLabel.Visible = false;
            // 
            // magnetFlagLabel
            // 
            magnetFlagLabel.AutoSize = true;
            magnetFlagLabel.Location = new Point(504, 262);
            magnetFlagLabel.Margin = new Padding(4, 0, 4, 0);
            magnetFlagLabel.Name = "magnetFlagLabel";
            magnetFlagLabel.Size = new Size(17, 15);
            magnetFlagLabel.TabIndex = 79;
            magnetFlagLabel.Text = "--";
            magnetFlagLabel.Visible = false;
            // 
            // valueMagnetLabel
            // 
            valueMagnetLabel.AutoSize = true;
            valueMagnetLabel.Location = new Point(504, 295);
            valueMagnetLabel.Margin = new Padding(4, 0, 4, 0);
            valueMagnetLabel.Name = "valueMagnetLabel";
            valueMagnetLabel.Size = new Size(19, 15);
            valueMagnetLabel.TabIndex = 80;
            valueMagnetLabel.Text = "00";
            valueMagnetLabel.Visible = false;
            // 
            // scoreMagnetDurationLabel
            // 
            scoreMagnetDurationLabel.AutoSize = true;
            scoreMagnetDurationLabel.Location = new Point(504, 331);
            scoreMagnetDurationLabel.Margin = new Padding(4, 0, 4, 0);
            scoreMagnetDurationLabel.Name = "scoreMagnetDurationLabel";
            scoreMagnetDurationLabel.Size = new Size(19, 15);
            scoreMagnetDurationLabel.TabIndex = 81;
            scoreMagnetDurationLabel.Text = "00";
            scoreMagnetDurationLabel.Visible = false;
            // 
            // extraLifeDurationLabel
            // 
            extraLifeDurationLabel.AutoSize = true;
            extraLifeDurationLabel.Location = new Point(753, 328);
            extraLifeDurationLabel.Margin = new Padding(4, 0, 4, 0);
            extraLifeDurationLabel.Name = "extraLifeDurationLabel";
            extraLifeDurationLabel.Size = new Size(19, 15);
            extraLifeDurationLabel.TabIndex = 82;
            extraLifeDurationLabel.Text = "00";
            extraLifeDurationLabel.Visible = false;
            // 
            // multiplierLabel
            // 
            multiplierLabel.AutoSize = true;
            multiplierLabel.Location = new Point(346, 402);
            multiplierLabel.Margin = new Padding(4, 0, 4, 0);
            multiplierLabel.Name = "multiplierLabel";
            multiplierLabel.Size = new Size(18, 15);
            multiplierLabel.TabIndex = 83;
            multiplierLabel.Text = "x1";
            // 
            // decayRateLabel
            // 
            decayRateLabel.AutoSize = true;
            decayRateLabel.Location = new Point(391, 402);
            decayRateLabel.Margin = new Padding(4, 0, 4, 0);
            decayRateLabel.Name = "decayRateLabel";
            decayRateLabel.Size = new Size(41, 15);
            decayRateLabel.TabIndex = 84;
            decayRateLabel.Text = "1/5sec";
            // 
            // decayTimerLabel
            // 
            decayTimerLabel.AutoSize = true;
            decayTimerLabel.Location = new Point(504, 402);
            decayTimerLabel.Margin = new Padding(4, 0, 4, 0);
            decayTimerLabel.Name = "decayTimerLabel";
            decayTimerLabel.Size = new Size(13, 15);
            decayTimerLabel.TabIndex = 85;
            decayTimerLabel.Text = "0";
            decayTimerLabel.Visible = false;
            // 
            // countdownTimer
            // 
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += countdownTimer_Tick;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.environment_protection;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Enabled = false;
            pictureBox2.Location = new Point(36, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 86;
            pictureBox2.TabStop = false;
            // 
            // autoclickerIcon
            // 
            autoclickerIcon.BackColor = Color.Transparent;
            autoclickerIcon.BackgroundImage = Properties.Resources.automation;
            autoclickerIcon.BackgroundImageLayout = ImageLayout.Zoom;
            autoclickerIcon.Enabled = false;
            autoclickerIcon.Location = new Point(72, 13);
            autoclickerIcon.Name = "autoclickerIcon";
            autoclickerIcon.Size = new Size(30, 30);
            autoclickerIcon.TabIndex = 87;
            autoclickerIcon.TabStop = false;
            // 
            // bonusIcon
            // 
            bonusIcon.BackColor = Color.Transparent;
            bonusIcon.BackgroundImage = Properties.Resources.bonus;
            bonusIcon.BackgroundImageLayout = ImageLayout.Zoom;
            bonusIcon.Enabled = false;
            bonusIcon.Location = new Point(108, 13);
            bonusIcon.Name = "bonusIcon";
            bonusIcon.Size = new Size(30, 30);
            bonusIcon.TabIndex = 88;
            bonusIcon.TabStop = false;
            // 
            // rewindIcon
            // 
            rewindIcon.BackColor = Color.Transparent;
            rewindIcon.BackgroundImage = Properties.Resources.reverse;
            rewindIcon.BackgroundImageLayout = ImageLayout.Zoom;
            rewindIcon.Enabled = false;
            rewindIcon.Location = new Point(142, 13);
            rewindIcon.Name = "rewindIcon";
            rewindIcon.Size = new Size(30, 30);
            rewindIcon.TabIndex = 89;
            rewindIcon.TabStop = false;
            // 
            // magnetIcon
            // 
            magnetIcon.BackColor = Color.Transparent;
            magnetIcon.BackgroundImage = Properties.Resources.Magnet;
            magnetIcon.BackgroundImageLayout = ImageLayout.Zoom;
            magnetIcon.Enabled = false;
            magnetIcon.Location = new Point(178, 13);
            magnetIcon.Name = "magnetIcon";
            magnetIcon.Size = new Size(30, 30);
            magnetIcon.TabIndex = 90;
            magnetIcon.TabStop = false;
            // 
            // extraLifeIcon
            // 
            extraLifeIcon.BackColor = Color.Transparent;
            extraLifeIcon.BackgroundImage = Properties.Resources.extraLife;
            extraLifeIcon.BackgroundImageLayout = ImageLayout.Zoom;
            extraLifeIcon.Enabled = false;
            extraLifeIcon.Location = new Point(214, 13);
            extraLifeIcon.Name = "extraLifeIcon";
            extraLifeIcon.Size = new Size(30, 30);
            extraLifeIcon.TabIndex = 91;
            extraLifeIcon.TabStop = false;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 455);
            Controls.Add(decayTimerLabel);
            Controls.Add(decayRateLabel);
            Controls.Add(multiplierLabel);
            Controls.Add(extraLifeDurationLabel);
            Controls.Add(scoreMagnetDurationLabel);
            Controls.Add(valueMagnetLabel);
            Controls.Add(magnetFlagLabel);
            Controls.Add(protectionDurationLabel);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(labelButton1);
            Controls.Add(label2);
            Controls.Add(debugMode);
            Controls.Add(playAgainButton);
            Controls.Add(btnLogout);
            Controls.Add(btnStart);
            Controls.Add(highscoreLabel);
            Controls.Add(scoreLabel);
            Controls.Add(timerLabel);
            Controls.Add(resetDecayBtn);
            Controls.Add(thousandScoreAddBtn);
            Controls.Add(resetMultiplierBtn);
            Controls.Add(hundredScoreAddBtn);
            Controls.Add(resetScoreBtn);
            Controls.Add(pictureBoxDecay);
            Controls.Add(pictureBoxMultiplier);
            Controls.Add(imgDecay);
            Controls.Add(imgMultiplier);
            Controls.Add(pictureBox1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(extraLifeOpacityIcon);
            Controls.Add(magnetOpacityIcon);
            Controls.Add(rewindOpacityIcon);
            Controls.Add(bonusOpacityIcon);
            Controls.Add(autoclickerOpacityIcon);
            Controls.Add(protectionIcon);
            Controls.Add(extraLifeIcon);
            Controls.Add(magnetIcon);
            Controls.Add(rewindIcon);
            Controls.Add(bonusIcon);
            Controls.Add(autoclickerIcon);
            Controls.Add(pictureBox2);
            Name = "Game";
            Text = "Clicker Game";
            Load += Game_Load;
            ((System.ComponentModel.ISupportInitialize)protectionIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)autoclickerOpacityIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)bonusOpacityIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)rewindOpacityIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)magnetOpacityIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)extraLifeOpacityIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgMultiplier).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgDecay).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMultiplier).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDecay).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)autoclickerIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)bonusIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)rewindIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)magnetIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)extraLifeIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox protectionIcon;
        private PictureBox autoclickerOpacityIcon;
        private PictureBox bonusOpacityIcon;
        private PictureBox rewindOpacityIcon;
        private PictureBox magnetOpacityIcon;
        private PictureBox extraLifeOpacityIcon;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private PictureBox pictureBox1;
        private PictureBox imgMultiplier;
        private PictureBox imgDecay;
        private PictureBox pictureBoxMultiplier;
        private PictureBox pictureBoxDecay;
        private Button resetScoreBtn;
        private Button hundredScoreAddBtn;
        private Button resetMultiplierBtn;
        private Button thousandScoreAddBtn;
        private Button resetDecayBtn;
        private Label timerLabel;
        private Label scoreLabel;
        private Label highscoreLabel;
        private Button btnStart;
        private Button btnLogout;
        private Button playAgainButton;
        private CheckBox debugMode;
        private Label label2;
        private Label labelButton1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label protectionDurationLabel;
        private Label magnetFlagLabel;
        private Label valueMagnetLabel;
        private Label scoreMagnetDurationLabel;
        private Label extraLifeDurationLabel;
        private Label multiplierLabel;
        private Label decayRateLabel;
        private Label decayTimerLabel;
        private System.Windows.Forms.Timer countdownTimer;
        private PictureBox pictureBox2;
        private PictureBox autoclickerIcon;
        private PictureBox bonusIcon;
        private PictureBox rewindIcon;
        private PictureBox magnetIcon;
        private PictureBox extraLifeIcon;
    }
}