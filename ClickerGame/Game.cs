using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using WinTimer = System.Windows.Forms.Timer;

namespace ClickerGame
{
    public partial class Game : Form
    {

        int userHighscore, isAdmin = 0;
        int score = 0;
        int bonus = 0;
        int bonusClicks;
        int rewind = 0;
        int scoreMagnet = 0;
        int extraLife = 0;
        double baseDecay = 5, scalingFactor, baseMultiplier = 4;
        int seconds = 0;
        int timerStart = 0;

        WinTimer decayTimer;
        //WinTimer imageTimer; // WinTimer for controlling image visibility (Decay)
        WinTimer multiplierTimer; // WinTimer for controlling image visibility (Multiplier)
        double multiplier = 1f, time;
        double protectionTimerLength, scoreMagnetTimerLength, multiplierIndex;

        // Decay variables
        double decayAmount;  // Amount by which score will decrease
        int decayTimerInterval = 5000;  // WinTimer interval in milliseconds (5 seconds)
        WinTimer protectionTimer, gotTimer;
        int countdown = 0;
        WinTimer counterTimer;

        WinTimer magnetTimer;


        //private Dictionary<Button, int> buttonPrices = new Dictionary<Button, int>(); 

        int buttonPrice1 = 10, buttonPrice2 = 10, buttonPrice3 = 10, buttonPrice4 = 15, buttonPrice5 = 25, buttonPrice6 = 20, buttonPrice7 = 20, buttonPrice8 = 30;

        Dictionary<string, PictureBox> powerupIcons = new Dictionary<string, PictureBox>();

        public Game()
        {
            InitializeComponent();

            userHighscore = LoginForm.HighScore;
            isAdmin = LoginForm.isAdmin;
            Debug.WriteLine($"Highscore: {userHighscore}\n isAdmin: {isAdmin}");

            if (isAdmin == 1)
            {
                debugMode.Visible = true;
            }

            time = protectionTimerLength;
            scalingFactor = 10;
            decayAmount = baseDecay * (1 + multiplier / scalingFactor);

            multiplierIndex = multiplier * 1.5;//multiplier value doesnt get changed, multiplierIndex does
            protectionTimerLength = 10 * Math.Sqrt(multiplier);

            scoreMagnetTimerLength = multiplier * 2.5;

            scoreLabel.Text = score.ToString();
            UpdateButtons();
            UpdateButtonState(button1);
            UpdateButtonState(button3);
            UpdateButtonState(button2);
            UpdateButtonState(button4);
            UpdateButtonState(button5);
            UpdateButtonState(button6);
            UpdateButtonState(button7);
            UpdateButtonState(button8);

            // Initialize the counter timer
            counterTimer = new WinTimer();
            counterTimer.Interval = 1000; // Update every second (1000ms)
            counterTimer.Tick += CounterTimer_Tick; // Event handler for updating the countdown
            counterTimer.Start(); // Start the timer


            // Initialize the WinTimer for the Decay mechanic
            decayTimer = new WinTimer();
            decayTimer.Interval = decayTimerInterval; // Set the timer interval based on decayTimerInterval (5 seconds)
            decayTimer.Tick += DecayTimer_Tick; // Event handler for the Tick event
            decayTimer.Start(); // Start the timer

            // Initialize the multiplier image timer
            multiplierTimer = new WinTimer();
            multiplierTimer.Interval = 250; // Show multiplier for 250ms (a quarter of a second)
            multiplierTimer.Tick += MultiplierTimer_Tick; // Event handler to hide the multiplier image after the time passes

            // initialize the Magnet powerup timer
            //magnetTimer = new WinTimer();
            //magnetTimer.Interval = 5000; //1 second
            //magnetTimer.Tick += MagnetTimer_Tick;


            // Update the decay rate label
            UpdateDecayLabel();

            powerupIcons.Add("Protection", protectionIcon);
            powerupIcons.Add("AutoClicker", autoclickerIcon);
            powerupIcons.Add("Bonus", bonusIcon);
            powerupIcons.Add("Rewind", rewindIcon);
            powerupIcons.Add("Magnet", magnetIcon);
            powerupIcons.Add("ExtraLife", extraLifeIcon);

            powerupIcons.Add("ProtectionDisable", protectionIcon);
            powerupIcons.Add("AutoClickerDisable", autoclickerOpacityIcon);
            powerupIcons.Add("BonusDisable", bonusOpacityIcon);
            powerupIcons.Add("RewindDisable", rewindOpacityIcon);
            powerupIcons.Add("MagnetDisable", magnetOpacityIcon);
            powerupIcons.Add("ExtraLifeDisable", extraLifeOpacityIcon);
        }

        private void CounterTimer_Tick(object sender, EventArgs e)
        {
            countdown++; // Increment the countdown

            // Reset countdown if it reaches the decay interval
            if (countdown > decayTimerInterval / 1000)
            {
                countdown = 1; // Reset to 1 after Decay() happens
            }

            // Update the label with the current countdown value
            decayTimerLabel.Text = countdown.ToString();
        }

        private void DecayTimer_Tick(object sender, EventArgs e)
        {
            Decay(); // Call Decay() to subtract the score
        }


        //private void MagnetTimer_Tick(object sender, EventArgs e)
        //{

        //}



        // WinTimer event to hide the decay image after 1 second
        private void ImageTimer_Tick(object sender, EventArgs e)
        {
            pictureBoxDecay.Visible = false; // Hide the decay image
        }


        // WinTimer event to hide the multiplier image after 250ms
        private void MultiplierTimer_Tick(object sender, EventArgs e)
        {
            pictureBoxMultiplier.Visible = false;  // Hide the multiplier image
            multiplierTimer.Stop();  // Stop the timer
        }





        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm frm1 = new LoginForm();
            frm1.ShowDialog();
        }

        private void LoginSuccessForm_Load(object sender, EventArgs e)
        {
            // Any other logic for form load
        }



        private void button2_EnabledChanged(object sender, EventArgs e)
        {
            //Debug.WriteLine($"button2 EnabledChanged: Enabled = {button2.Enabled}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            score = score - GetButtonPrice(button1);
            UpdateScore(score);

            EnableProtection(true);

            UpdateButtons();  // Update button prices
        }

        private void button2_Click(object sender, EventArgs e)
        {
            score = score - GetButtonPrice(button3);
            IncreaseMultiplier(multiplierIndex);
            multiplierIndex *= 1.5;

            UpdateButtons();  // Update button prices
            UpdateScore(score);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            score = score - GetButtonPrice(button3);
            //IncreaseMultiplier(1.05);
            UpdateButtons();  // Update button prices
            UpdateScore(score);
            EnableGiveOrTake(true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            score = score - GetButtonPrice(button3);
            //IncreaseMultiplier(1.05);
            UpdateButtons();  // Update button prices
            UpdateScore(score);
            EnableAutoclicker(true);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            score = score - GetButtonPrice(button3);
            //IncreaseMultiplier(1.05);
            UpdateButtons();  // Update button prices
            UpdateScore(score);
            EnableBonus(true);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Debug.WriteLine("Rewind purchased");
            score = score - GetButtonPrice(button3);
            //IncreaseMultiplier(1.05);
            UpdateButtons();  // Update button prices
            UpdateScore(score);
            EnableRewind(true);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            scoreMagnet = 1;

            score = score - GetButtonPrice(button3);
            UpdateScore(score);

            //IncreaseMultiplier(1.05);

            Debug.WriteLine("Magnet Purchased");

            UpdateButtons();  // Update button prices

            DisplayPowerupIcon("MagnetDisable");

            EnableScoreMagnet(true);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            score = score - GetButtonPrice(button3);
            //IncreaseMultiplier(1.05);
            UpdateButtons();  // Update button prices
            UpdateScore(score);
            Debug.WriteLine("ExtraLife Purchased");
            EnableExtraLife(true);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Logic for label1 click if needed
        }

        private void scoreLabel_Click(object sender, EventArgs e)
        {
            // Logic for scoreLabel click if needed
        }

        private void btnHover_MouseHover(object sender, EventArgs e)
        {
            // Get the button that triggered the event
            Button button = (Button)sender;

            // Dynamically get the corresponding label based on the button's name
            string labelName = "label" + "Button" + button.Name.Substring(button.Name.Length - 1);
            //Debug.WriteLine(labelName);

            // Find the label by its name
            Label label = Controls.Find(labelName, true).FirstOrDefault() as Label;

            if (label != null)
            {
                // Get the last character of the label's name
                char lastChar = labelName.Length > 0 ? labelName[labelName.Length - 1] : ' ';

                // Use a switch case to check the last character of the label name
                switch (lastChar)
                {
                    case '1':
                        label.Text = $"Protection\n[For {protectionTimerLength} seconds, the Decay rate is reduced by {decayAmount:F2}%.]";
                        break;
                    case '2':
                        label.Text = $"Multiplier\n[Permanently increases your given \npoints per click by {multiplierIndex:F1}.]";
                        break;
                    case '3':
                        label.Text = $"Give or Take\n[The amount lost from Decay is reduced by {multiplier * 0.05}%, permanently.]";
                        break;
                    case '4':
                        label.Text = $"Autoclicker\n[Gain {multiplier * 2} automatic clicks.]";
                        break;
                    case '5':
                        label.Text = "Bonus\n[Your next 2 clicks will be a \nhigh, random amount of points.]";
                        break;
                    case '6':
                        label.Text = "Rewind\n[The next Decay does the \nopposite, adding up to \nthe score.]";
                        break;
                    case '7':
                        label.Text = $"Score Magnet\n[For {scoreMagnetTimerLength} seconds, gain a \nrandom amount of points, periodically.]";
                        break;
                    case '8':
                        label.Text = $"Extra Life\n[The score is protected \nfrom the next {extraLife} Decays.]";
                        break;
                    default:
                        label.Text = "Unknown Power-up\n[No description available.]";
                        break;
                }

                // Show the label when mouse hovers over the button
                label.Visible = true;
            }
        }


        // This event will trigger when the mouse leaves the button
        private void btnHover_MouseLeave(object sender, EventArgs e)
        {

            // Get the button that triggered the event
            Button button = (Button)sender;

            // Dynamically get the corresponding label based on the button's name
            string labelName = "label" + "Button" + button.Name.Substring(button.Name.Length - 1);
            //Debug.WriteLine(labelName);

            // Find the label by its name
            Label label = Controls.Find(labelName, true).FirstOrDefault() as Label;
            // Hide the label when the mouse leaves the button
            label.Visible = false;

        }

        // Update all button texts based on their prices
        // Call this function when you want to update all button prices
        private void UpdateButtons()
        {
            // Debug.WriteLine("UpdateButtons()");
            foreach (Button button in new[] { button1, button3, button2, button4, button5, button6, button7, button8 })
            {
                // Update price and button text
                int price = GetButtonPrice(button);
                button.Text = $"{price}";

                // Enable/disable button based on price and score
                button.Enabled = price <= score;
            }
        }


        // Get the price for the given button, adjusted by multiplier
        private int GetButtonPrice(Button button)
        {
            //Debug.WriteLine("GetButtonPrice()");
            switch (button.Name)
            {
                case "button1": return (int)(buttonPrice1 * multiplier);
                case "button2": return (int)(buttonPrice2 * multiplier);
                case "button3": return (int)(buttonPrice3 * multiplier);
                case "button4": return (int)(buttonPrice4 * multiplier);
                case "button5": return (int)(buttonPrice5 * multiplier);
                case "button6": return (int)(buttonPrice6 * multiplier);
                case "button7": return (int)(buttonPrice7 * multiplier);
                case "button8": return (int)(buttonPrice8 * multiplier);
                default: return 0;  // Default case (should not be reached)
            }
        }


        // Refactor UpdateButtonState to use the multiplier-adjusted price
        private void UpdateButtonState(Button button)
        {
            //Debug.WriteLine("UpdateButtonState()");
            int price = GetButtonPrice(button);

            // Compare the button price with the current score
            if (price <= score)
            {
                button.Enabled = true; // Enable button if price is <= score
            }
            else
            {
                button.Enabled = false; // Disable button if price is > score
            }
        }

        private void debugMode_CheckedChanged(object sender, EventArgs e)
        {

            if (debugMode.Checked) // If the checkbox is checked
            {
                decayTimerLabel.Visible = true; // Make the decayTimerLabel visible
                resetScoreBtn.Visible = true;
                resetMultiplierBtn.Visible = true;
                resetDecayBtn.Visible = true;
                hundredScoreAddBtn.Visible = true;
                thousandScoreAddBtn.Visible = true;
                protectionDurationLabel.Visible = true;
                scoreMagnetDurationLabel.Visible = true;
                extraLifeDurationLabel.Visible = true;
                magnetFlagLabel.Visible = true;
                valueMagnetLabel.Visible = true;
            }
            else // If the checkbox is unchecked
            {
                decayTimerLabel.Visible = false; // Make the decayTimerLabel invisible
                resetScoreBtn.Visible = false;
                resetMultiplierBtn.Visible = false;
                resetDecayBtn.Visible = false;
                hundredScoreAddBtn.Visible = false;
                thousandScoreAddBtn.Visible = false;
                protectionDurationLabel.Visible = false;
                scoreMagnetDurationLabel.Visible = false;
                extraLifeDurationLabel.Visible = false;
                magnetFlagLabel.Visible = false;
                valueMagnetLabel.Visible = false;
            }
        }


        private void debugMode_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void EnableProtection(bool flag)
        {
            DisplayPowerupIcon("ProtectionDisable");

            // Store original decay amount for restoration
            double originalDecayAmount = decayAmount;
            double protectionDecayAmount = (int)10 * Math.Sqrt(multiplier);

            decayAmount = protectionDecayAmount;

            // Calculate and set the protection duration
            //double protectionDuration = decayAmount * (multiplier * 1.2) /2;
            double protectionDuration = protectionTimerLength;
            int remainingTime = (int)Math.Floor(protectionDuration);

            Debug.WriteLine($"Protection Duration: {protectionDuration}, Remaining Time: {remainingTime}");

            // Update the protection duration label
            protectionDurationLabel.Text = $"{remainingTime}";

            // Stop and dispose of any existing timer
            //if (protectionTimer?.Enabled == true)
            //{
            //    protectionTimer.Stop();
            //    protectionTimer.Dispose();
            //}

            // Initialize a new protection timer
            protectionTimer = new WinTimer { Interval = 1000 };
            protectionTimer.Tick += (s, e) =>
            {
                remainingTime--;
                if (remainingTime > 0)
                {
                    protectionDurationLabel.Text = $"{remainingTime}";
                    //decayAmount = 
                }
                else
                {
                    protectionDurationLabel.Text = "00";

                    // Restore original decay amount
                    decayAmount = originalDecayAmount;
                    UpdateDecayLabel();

                    protectionTimer.Stop();
                    protectionTimer.Dispose();
                    HidePowerupIcon("ProtectionDisable");
                }
            };

            // Adjust decay temporarily
            double adjustedDecay = decayAmount - (multiplier * 1.12);
            decayAmount = (int)Math.Floor(adjustedDecay);
            UpdateDecayLabel();

            // Start the timer
            protectionTimer.Start();
        }




        private void EnableGiveOrTake(bool flag)
        {
            double adjustedDecayAmount = decayAmount / 1.5;
            decayAmount = (int)Math.Floor(adjustedDecayAmount);
            int gotRemainingTime = (int)time;
            UpdateDecayLabel();
        }

        private async Task EnableAutoclicker(bool flag)
        {
            DisplayPowerupIcon("AutoClickerDisable");
            int clicks = 2 + (int)(multiplier * 3);
            while (clicks != 0)
            {
                await Task.Delay(100);
                score++;
                UpdateScore(score);
                clicks--;
                if (clicks == 0)
                    HidePowerupIcon("AutoClickerDisable");
            }
        }

        private void EnableBonus(bool flag)
        {
            bonus = 1;
            bonusClicks = 10 + (int)(multiplier * 6);
            DisplayPowerupIcon("BonusDisable");
        }

        private void EnableRewind(bool flag)
        {
            rewind = 1;
            DisplayPowerupIcon("RewindDisable");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            seconds = 5;
            countdownTimer.Start();
            timerStart = 1;

        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            seconds--;
            int minutes = seconds / 60;

            TimeSpan timeSpan = TimeSpan.FromSeconds(seconds);
            timerLabel.Text = timeSpan.ToString(@"mm\:ss");

            if (seconds < 0)
            {
                countdownTimer.Stop();
                timerLabel.Text = $"00:00";
                scoreLabel.Text = "TIME'S UP!";
                playAgainButton.Visible = true;
                highscoreLabel.Visible = true;
                timerStart = 0;
                highscoreLabel.Text = $"Highscore: {userHighscore}";

                if (score > userHighscore)
                {
                    //Debug.WriteLine($"(IF)userHighscore: {userHighscore}");
                    scoreLabel.Text = "NEW HIGHSCORE!";
                    userHighscore = score;
                    highscoreLabel.Text = $"Highscore: {score}";
                    LoginForm.UpdateHighScore(score);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (timerStart == 1)
            {
                if (bonus == 1)
                {
                    if (bonusClicks > 0)
                    {
                        //Debug.WriteLine("Enterred the IF");
                        Random random = new Random();
                        int min = 1;  // Minimum value
                        int max = 101; // Maximum value (exclusive)

                        int randomValue = random.Next(min, max);  // Generates a random number between min and max-1

                        score += randomValue;
                        UpdateScore(score);
                        bonusClicks--;
                        // Debug.WriteLine($"bonusClicks:{bonusClicks}");
                        //Debug.WriteLine(bonusClicks);
                        if (bonusClicks == 0)
                            HidePowerupIcon("BonusDisable");
                    }
                    else
                    {
                        bonus = 0;

                    }

                }
                else
                {
                    score += (int)(1 * multiplier);  // Multiply the score by the multiplier (for now multiplier is 1)
                    UpdateScore(score);
                }

                // Update the multiplier label to show the current multiplier
                //multiplierLabel.Text = $"x{multiplier:F1}";

                // Show the multiplier image briefly every time the score goes up
                pictureBoxMultiplier.Visible = true;  // Show the multiplier image
                multiplierTimer.Start();  // Start the timer to hide it after a short time (250ms)

                UpdateButtonState(button1);
                UpdateButtonState(button3);
                UpdateButtonState(button2);
                UpdateButtonState(button4);
                UpdateButtonState(button5);
                UpdateButtonState(button6);
                UpdateButtonState(button7);
                UpdateButtonState(button8);
            }
        }

        private void timerLabel_Click(object sender, EventArgs e)
        {

        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            playAgainButton.Visible = false;
            highscoreLabel.Visible = false;
            seconds = 5;
            score = 0;
            UpdateScore(0);
            countdownTimer.Start();
            timerStart = 1;

            multiplier = 1;
            multiplierLabel.Text = $"x{multiplier:F1}";

            decayAmount = 2;
            UpdateDecayLabel();
        }

        private void EnableScoreMagnet(bool flag)
        {
            Debug.WriteLine("EnableScoreMagnet()");
            magnetTimer = new WinTimer();
            magnetTimer.Interval = 1000;  // Set the interval
            magnetTimer.Start();

            Random random = new Random();

            int magnetRemainingTime = (int)scoreMagnetTimerLength;

            magnetTimer.Tick += (object s, System.EventArgs e) =>
            {
                Debug.WriteLine($"In Magnet WinTimer {magnetRemainingTime}");
                magnetRemainingTime--;

                if (magnetRemainingTime > 0)
                {
                    Debug.WriteLine($"in IF() || scoreMagnet = {scoreMagnet}");

                    // Update the protection duration label
                    scoreMagnetDurationLabel.Text = $"{magnetRemainingTime}";


                    if (scoreMagnet == 1)
                    {
                        Debug.WriteLine("in IF(IF())");
                        int min = 0;  // Minimum value
                        int max = 2; // Maximum value (exclusive)
                        int randomValue = random.Next(min, max);
                        magnetFlagLabel.Text = randomValue.ToString();
                        //Debug.WriteLine($"randomValue={randomValue}");

                        if (randomValue == 1)
                        {
                            int _min = 1;  // Minimum value
                            int _max = 201; // Maximum value (exclusive)
                            int _randomValue = random.Next(_min, _max);
                            valueMagnetLabel.Text = _randomValue.ToString();
                            score += _randomValue;
                            UpdateScore(score);
                        }
                    }
                }
                else
                {
                    Debug.WriteLine("in ELSE()");

                    scoreMagnet = 0;

                    // WinTimer expired, disable protection
                    scoreMagnetDurationLabel.Text = "00";

                    // Stop and dispose of the timer
                    magnetTimer.Stop();
                    magnetTimer.Dispose();

                    magnetTimer.Tick -= null;  // Detach the handler

                    HidePowerupIcon("MagnetDisable");
                }
            };
        }

        private void EnableExtraLife(bool flag)
        {
            extraLife = Math.Max(5, (int)(multiplier / 3));
            DisplayPowerupIcon("ExtraLifeDisable");
        }

        private async void Decay()
        {
            if (timerStart == 1)
            {
                if (rewind == 1)
                {
                    //Debug.WriteLine("Decay() > rewind");

                    score += (int)decayAmount; // Decrease the score by decayAmount
                    UpdateScore(score); // Update the score label
                    pictureBoxMultiplier.Visible = true;  // Show the multiplier image
                    multiplierTimer.Start();  // Start the timer to hide it after a short time (250ms)
                    rewind = 0;
                    HidePowerupIcon("RewindDisable");
                }
                else
                if (extraLife > 0)
                {
                    extraLife--;
                    if (decayTimerInterval != 0)
                        pictureBoxDecay.Visible = true;

                    // Wait for 1 second before hiding the image
                    await Task.Delay(1000);

                    // Hide the decay image after 1 second
                    pictureBoxDecay.Visible = false;
                    if (extraLife == 0)
                        HidePowerupIcon("ExtraLifeDisable");
                }
                else
                {
                    if (score >= 10) // Only decay if the score is >= 10
                    {
                        score -= (int)decayAmount; // Decrease the score by decayAmount
                        UpdateScore(score); // Update the score label

                        // Show the decay image
                        if (decayTimerInterval != 0)
                            pictureBoxDecay.Visible = true;

                        // Wait for 1 second before hiding the image
                        await Task.Delay(1000);

                        // Hide the decay image after 1 second
                        pictureBoxDecay.Visible = false;
                    }
                }
            }
        }


        void UpdateScore(int newScore)
        {
            score = newScore;
            scoreLabel.Text = newScore.ToString();

            UpdateButtonState(button1);
            UpdateButtonState(button3);
            UpdateButtonState(button2);
            UpdateButtonState(button4);
            UpdateButtonState(button5);
            UpdateButtonState(button6);
            UpdateButtonState(button7);
            UpdateButtonState(button8);
        }


        private void resetScoreBtn_Click(object sender, EventArgs e)
        {
            score = 0;
            UpdateScore(score);
        }

        private void resetMultiplierBtn_Click(object sender, EventArgs e)
        {
            multiplier = 1f;
            multiplierLabel.Text = $"x{multiplier:F1}";
        }

        private void resetDecayBtn_Click(object sender, EventArgs e)
        {
            decayAmount = 1;
            UpdateDecayLabel();
        }

        private void hundredScoreAddBtn_Click(object sender, EventArgs e)
        {
            score += 100;
            UpdateScore(score);
        }

        private void thousandScoreAddBtn_Click(object sender, EventArgs e)
        {
            score += 1000;
            UpdateScore(score);
        }

        private void IncreaseMultiplier(double amount)
        {
            multiplier = baseMultiplier * (1 + Math.Log10(score + 1));
            multiplierLabel.Text = $"x{multiplier:F1}";  // Update the multiplier label
            scalingFactor++;
            UpdateDecayLabel();
        }

        private void DisplayPowerupIcon(string powerupName)
        {
            PictureBox pictureBox = powerupIcons[powerupName];
            pictureBox.Visible = false;
        }

        private void HidePowerupIcon(string powerupName)
        {
            PictureBox pictureBox = powerupIcons[powerupName];
            pictureBox.Visible = true;
        }

        private void UpdateDecayLabel()
        {
            decayRateLabel.Text = $"{(int)decayAmount}/{decayTimerInterval / 1000} sec";
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }
    }
}
