namespace _7_6_name_search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<string> popularNames = new List<string>
        {
            "Olivia","Emma","Ava","Sophia","Isabella","Mia","Amelia","Harper","Evelyn","Abigail",
            "Emily","Ella","Elizabeth","Camila","Luna","Sofia","Avery","Mila","Aria","Scarlett",
            "Penelope","Layla","Chloe","Victoria","Madison","Eleanor","Grace","Nora","Riley","Zoey",
            "Hannah","Hazel","Lily","Ellie","Violet","Lillian","Zoe","Stella","Aurora","Natalie",
            "Emilia","Everly","Leah","Aubrey","Willow","Addison","Lucy","Audrey","Bella","Nova",
            "Brooklyn","Paisley","Savannah","Claire","Skylar","Isla","Genesis","Naomi","Elena","Caroline",
            "Eliana","Anna","Maya","Valentina","Ruby","Kennedy","Ivy","Ariana","Aaliyah","Cora",
            "Madelyn","Alice","Kinsley","Hailey","Gabriella","Allison","Gianna","Serenity","Samantha","Autumn",
            "Quinn","Eva","Piper","Sophie","Sadie","Delilah","Josephine","Nevaeh","Adeline","Arya",
            "Emery","Lydia","Clara","Vivian","Madeline","Peyton","Julia","Rylee","Brielle","Reagan"
        };
        private void btnCheckName_Click(object sender, EventArgs e)
        {
            string userInput = txtNameInput.Text.Trim();

            if (string.IsNullOrEmpty(userInput))
            {
                lblResult.Text = "Please enter a name.";
                return;
            }

            // Case-insensitive check
            if (popularNames.Contains(userInput, StringComparer.OrdinalIgnoreCase))
            {
                lblResult.Text = $"{userInput} is among the most popular names!";
            }
            else
            {
                lblResult.Text = $"{userInput} is NOT among the most popular names.";
            }
        }
    }
}
