using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace _6_9_RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Random rand = new Random();
        private void btnRock_Click_1(object sender, EventArgs e)
        {
            Play("Rock");
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            Play("Paper");
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            Play("Scissors");
        }

        private void Play(string playerChoice)
        {
            string[] options = { "Rock", "Paper", "Scissors" };
            string computerChoice = options[rand.Next(options.Length)];

            lblComputer.Text = "Computer chose: " + computerChoice;

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
