namespace Textbook_Problem_7_10
{
    public partial class form_slotMachine : Form
    {
        public form_slotMachine()
        {
            InitializeComponent();
        }
        //Initializing variables
        Random random = new Random();

        decimal totalAmountEarned;
        decimal totalAmountSpent;
        string message;

        //Array of images 
        Image[] fruitImgs = new Image[]
        {
            Properties.Resources.Lemon,
            Properties.Resources.Apple,
            Properties.Resources.Lime,
            Properties.Resources.Strawberry,
            Properties.Resources.Pear,
            Properties.Resources.Grapes,
            Properties.Resources.Banana,
            Properties.Resources.Orange,
            Properties.Resources.Watermelon,
            Properties.Resources.Cherries
        };



        private void spinBtn_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amountSpent = decimal.Parse(amountTextBox.Text);
                totalAmountSpent += amountSpent;

                //randomizming pictures 
                fruitPic1.Image = getRandomFruit();
                fruitPic2.Image = getRandomFruit();
                fruitPic3.Image = getRandomFruit();

                decimal amountWon = calculateAmountWon(fruitPic1.Image, fruitPic2.Image, fruitPic3.Image, amountSpent);
                totalAmountEarned += amountWon;

                MessageBox.Show(message);


            }
            catch (Exception)
            {
                MessageBox.Show("Invalid value inputted.");
            }
        }

        private Image getRandomFruit()
        {
            int randomIndex = random.Next(fruitImgs.Length);
            return fruitImgs[randomIndex];
        }

        private decimal calculateAmountWon(Image image1, Image image2, Image image3, decimal betAmount)
        {
            decimal winnings = 0;
            if (image1 == image2 && image2 == image3) //if there are 3 matches
            {
                winnings = betAmount * 3;
                message = $"Jackpot! You have won ${winnings}";
                return winnings;
            }
            else if (image1 == image2 || image2 == image3 || image1 == image3) // two matches
            {
                winnings = betAmount * 2;
                message = $"Nice. You have won ${winnings}";
                return winnings;
            }
            else // no matches
            {
                message = $"Sorry! Better luck next time.";
                return winnings;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"You have spent $ {totalAmountSpent}. You have earned $ {totalAmountEarned}.");

            Application.Exit();
        }
    }
}
