using System;
using System.Windows.Forms;

namespace GuessAWord
{
    public partial class Form1 : Form
    {
        private string[] words = { "mathematics", "physics", "computer", "science", "software", "development", "engineering", "automobile" };
        private Random randomClass = new Random();
        private Word gameWord = new Word("");
        public Form1()
        {
            InitializeComponent();
        }

        private void StartNewGame()
        {
            int randomNumber = randomClass.Next(0, words.Length);
            gameWord = new Word(words[randomNumber]);

            lblHiddenWordDisplay.Text = gameWord.CheckHiddenWordState();
            lblResultMessage.Text = "Welcome! Enter a letter and click the Guess button.";
            txtGuess.Clear();
            txtGuess.Enabled = true;
            btnGuess.Enabled = true;
            txtGuess.Focus();
        }

        // Validates input before using Word class methods to check the guess and update the hidden word state
        private void ProcessGuess()
        {
            if (string.IsNullOrWhiteSpace(txtGuess.Text) || txtGuess.Text.Length != 1)
            {
                lblResultMessage.Text = "Please enter a single letter before guessing.";
                txtGuess.Focus();
                return;
            }

            char guessChar = txtGuess.Text.ToLower()[0];

            if (!char.IsLetter(guessChar))
            {
                lblResultMessage.Text = "Please enter an actual letter.";
                txtGuess.Clear();
                txtGuess.Focus();
                return;
            }

            bool correct = gameWord.CheckLetter(guessChar);
            lblHiddenWordDisplay.Text = gameWord.CheckHiddenWordState();

            if (gameWord.IsSolved())
            {
                lblResultMessage.Text = "Congratulations! You've guessed the word!";
                txtGuess.Enabled = false;
                btnGuess.Enabled = false;
            }
            else if (correct)
            {
                lblResultMessage.Text = $"Yes! The letter '{guessChar}' is in the word.";
            }
            else
            {
                lblResultMessage.Text = $"Sorry. The letter '{guessChar}' is not in the word.";
            }

            txtGuess.Clear();
            txtGuess.Focus();
        }

        // Event handlers
        private void Form1_Load(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            ProcessGuess();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
