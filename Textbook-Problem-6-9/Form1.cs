namespace _6_9_RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // private field used for all random operations
        private Random rand = new Random();

        // event handler for the rock button
        private void btnRock_Click_1(object sender, EventArgs e)
        {
            Play("Rock");
        }

        // event handler for the paper button
        private void btnPaper_Click(object sender, EventArgs e)
        {
            Play("Paper");
        }

        // event handler for the scissors button
        private void btnScissors_Click(object sender, EventArgs e)
        {
            Play("Scissors");
        }

        private void Play(string playerChoice)
        {
            // pick a random index to get the computer's choice, then display it
            string[] options = { "Rock", "Paper", "Scissors" };
            string computerChoice = options[rand.Next(options.Length)];

            lblComputer.Text = "Computer chose: " + computerChoice;

            // check if the player's choice wins against the computer and display message
            if (playerChoice == computerChoice)
                lblResult.Text = "It's a tie!";
            else if ((playerChoice == "Rock" && computerChoice == "Scissors") ||
                     (playerChoice == "Scissors" && computerChoice == "Paper") ||
                     (playerChoice == "Paper" && computerChoice == "Rock"))
                lblResult.Text = "You win!";
            else
                lblResult.Text = "Computer wins!";
        }

    }
}
