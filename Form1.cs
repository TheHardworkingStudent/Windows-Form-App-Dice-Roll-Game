using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
namespace Assignment2
{
    /// <summary>
    /// Class that contains the form
    /// </summary>
    public partial class Form1 : Form
    {
        private int[] arrFrequency = new int[6];
        private float[] arrPercentage = new float[6];
        private int[] arrGuesses = new int[6];
        private int timesGuessed = 0;
        private int timesGuessedRight = 0;
        private int timesGuessedWrong = 0;
        /// <summary>
        /// enum for the dice because ONE, TWO, THREE, FOUR, FIVE, SIX seems nicer than 0, 1 ,2 3, 4, 5
        /// </summary>
        private enum diceFace
        {
            ONE, TWO, THREE, FOUR, FIVE, SIX
        }
        /// <summary>
        /// Constructor for Form1 which initalize stuff and clear any junk data in the arrays.
        /// </summary>
        public Form1()
        {
            clear_memory(ref arrFrequency);
            clear_memory(ref arrPercentage);
            clear_memory(ref arrGuesses);
            InitializeComponent();
        }
        /// <summary>
        /// Pass in an array to clear the junk data of that array.
        /// </summary>
        /// <param name="arr"></param>
        private void clear_memory(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
        }
        /// <summary>
        /// Pass in an array to clear the junk data of that array.
        /// </summary>
        /// <param name="arr"></param>
        private void clear_memory(ref float[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
        }
        /// <summary>
        /// Calculates the percentage column for the gui and then updates it
        /// </summary>
        private void calculate_percentage()
        {
            // calculates all the percentages of dice rolls
            for (int i = 0; i < arrPercentage.Length; i++)
            {
                arrPercentage[i] = (float)arrFrequency[i] / timesGuessed;
            }
            //formats the strings and updates the gui
            label7.Text = $"{(arrPercentage[0] * 100):F2}%";
            label8.Text = $"{(arrPercentage[1] * 100):F2}%";
            label9.Text = $"{(arrPercentage[2] * 100):F2}%";
            label10.Text = $"{(arrPercentage[3] * 100):F2}%";
            label11.Text = $"{(arrPercentage[4] * 100):F2}%";
            label12.Text = $"{(arrPercentage[5] * 100):F2}%";
        }
        /// <summary>
        /// Simulates the dice picture and then sets the dice picture to the one it finally lands on.
        /// IRollResult is the result of the roll.
        /// Credit to a lot of this code goes to chapter 5 and 6 example.
        /// </summary>
        /// <param name="iRollResult"></param>
        /// <returns></returns>
        private async Task simulate_dice_picture(int iRollResult)
        {
            // Stretches the image
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            // Gets mostly the full file path.
            string Full_Path = Path.Combine(System.IO.Directory.GetCurrentDirectory(),"Images","die");
            // create random
            Random oRandom = new Random();
            int iDiceRoll = 0;
            //interates through here and select a random images until it selects the roll result.
            for(int i = 1; i < 7; i++)
            {
                iDiceRoll = oRandom.Next(1,7);
                pictureBox1.Image = Image.FromFile(Full_Path+ iDiceRoll.ToString() + ".gif");
                pictureBox1.Refresh();
                await Task.Delay(100);
            }
            pictureBox1.Image = Image.FromFile(Full_Path + iRollResult.ToString() + ".gif");
        }
        /// <summary>
        /// The function that handles the event of clicking on the roll button.
        /// A monolithic function that handles all the dice calculations and updating statistics and updating gui.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnRoll_Click(object sender, EventArgs e)
        {
            // create the variable to hold the guess and try to parse the number
            // if parse not successful creates an error message for the user.
            int iGuess;
            bool bSuccess = int.TryParse(txtbxGuess.Text, out iGuess);
            if (bSuccess && iGuess >= 1 && iGuess <= 6)
            {
                // increment number of times guessed and create a new random object for use. Then store the random result in iRollResult.
                timesGuessed++;
                Random oRandom = new Random();
                diceFace iRollResult = (diceFace)oRandom.Next(0, 6);

                arrFrequency[(int)iRollResult]++;
                iGuess = iGuess - 1;
                arrGuesses[iGuess]++;
                // switch statement for updating the frequency.
                switch (iRollResult)
                {
                    case diceFace.ONE:
                        label1.Text = arrFrequency[(int)iRollResult].ToString();
                        break;
                    case diceFace.TWO:
                        label2.Text = arrFrequency[(int)iRollResult].ToString();
                        break;
                    case diceFace.THREE:
                        label3.Text = arrFrequency[(int)iRollResult].ToString();
                        break;
                    case diceFace.FOUR:
                        label4.Text = arrFrequency[(int)iRollResult].ToString();
                        break;
                    case diceFace.FIVE:
                        label5.Text = arrFrequency[(int)iRollResult].ToString();
                        break;
                    case diceFace.SIX:
                        label6.Text = arrFrequency[(int)iRollResult].ToString();
                        break;
                }
                // switch statement for updating the guesses
                switch ((diceFace)iGuess)
                {
                    case diceFace.ONE:
                        label13.Text = arrGuesses[iGuess].ToString();
                        break;
                    case diceFace.TWO:
                        label14.Text = arrGuesses[iGuess].ToString();
                        break;
                    case diceFace.THREE:
                        label15.Text = arrGuesses[iGuess].ToString();
                        break;
                    case diceFace.FOUR:
                        label16.Text = arrGuesses[iGuess].ToString();
                        break;
                    case diceFace.FIVE:
                        label17.Text = arrGuesses[iGuess].ToString();
                        break;
                    case diceFace.SIX:
                        label18.Text = arrGuesses[iGuess].ToString();
                        break;
                }
                // increments the guess rights and guess wrongs
                if (iGuess == (int)iRollResult)
                {
                    timesGuessedRight++;
                }
                else
                {
                    timesGuessedWrong++;
                }
                // calculate and update the percentage column
                calculate_percentage();
                // update the statboard at the top
                lblTimesPlayedStat.Text = timesGuessed.ToString();
                lblTimesGuessedRightStat.Text = timesGuessedRight.ToString();
                lblTimesGuessedWrongStat.Text = timesGuessedWrong.ToString();
                // update dice picture
                await simulate_dice_picture((int)(iRollResult + 1));
            }
            else
            {
                // Error message for those who do not enter the right input.
                MessageBox.Show("Error! You must enter a number between 1 and 6");
            }

        }
        /// <summary>
        /// Function that handles the even of the reset button.
        /// Reset button will clear all the values and set the gui back to the defaults.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            clear_memory(ref arrFrequency);
            clear_memory(ref arrPercentage);
            clear_memory(ref arrGuesses);
            timesGuessed = 0;
            timesGuessedRight = 0;
            timesGuessedWrong = 0;
            lblTimesPlayedStat.Text = "0";
            lblTimesGuessedRightStat.Text = "0";
            lblTimesGuessedWrongStat.Text = "0";
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "0";
            label9.Text = "0";
            label10.Text = "0";
            label11.Text = "0";
            label12.Text = "0";
            label13.Text = "0";
            label14.Text = "0";
            label15.Text = "0";
            label16.Text = "0";
            label17.Text = "0";
            label18.Text = "0";
        }
    }
}
