namespace Rock_Paper_Scissors_Game
{
    // Main class for the game's form and user interface (UI) interactions
    public partial class Form1 : Form
    {
        // Declare constants for Rock, Paper, and Scissors choices
        int Rock = 1;
        int Paper = 2;
        int Scissors = 3;

        // Variable to store the computer's randomly generated choice
        int comp;


        // Variables to track user and computer win counts
        int userWin = 0;
        int compWin = 0;

        // Method called when the computer wins the round
        public void computerWon()
        {
            // Change the background color of the group box to indicate a loss
            groupBox1.BackColor = Color.DarkRed;
            this.ForeColor = Color.Black; // Set text color
        }

        // Method called when the round results in a tie
        public void tieMatch()
        {
            // Change the background color of the group box to indicate a tie
            groupBox1.BackColor = Color.Yellow;
        }


        // Method called when the user wins the round
        public void userWon()
        {
            // Change the background color of the group box to indicate a win
            groupBox1.BackColor = Color.Green;
        }

        // Handles the result if the user chooses Rock
        public void RockOutput()
        {
            // Check if the computer also chose Rock (resulting in a tie)
            if (comp == 1)
            {
                tieMatch(); // Tie case
                label2.Text = "Its a TIE, since both chose the same";
                label3.Text = "User's Choice: Rock";
                label4.Text = "Computer's Choice: Rock";
            }
            // Check if the computer chose Paper (user loses)
            else if (comp == 2)
            {
                computerWon(); // Computer wins
                label2.Text = "You LOST, Computer WON the Game";
                label3.Text = "User's Choice: Rock";
                label4.Text = "Computer's Choice: Paper";
                compWin++; // Increment computer's win count
                label8.Text = compWin.ToString(); // Update win count on the UI
            }
            // Check if the computer chose Scissors (user wins)
            else if (comp == 3)
            {
                userWon(); // User wins
                label2.Text = "You WON, Computer LOST the Game";
                label3.Text = "User's Choice: Rock";
                label4.Text = "Computer's Choice: Scissors";
                userWin++; // Increment user's win count
                label7.Text = userWin.ToString(); // Update win count on the UI
            }
        }

        // Handles the result if the user chooses Paper
        public void PaperOutput()
        {
            // Check if the computer also chose Paper (resulting in a tie)
            if (comp == 2)
            {
                tieMatch(); // Tie case
                label2.Text = "Its a TIE, since both chose the same";
                label3.Text = "User's Choice: Paper";
                label4.Text = "Computer's Choice: Paper";
            }
            // Check if the computer chose Scissors (user loses)
            else if (comp == 3)
            {
                computerWon(); // Computer wins
                label2.Text = "You LOST, Computer WON the Game";
                label3.Text = "User's Choice: Paper";
                label4.Text = "Computer's Choice: Scissors";
                compWin++; // Increment computer's win count
                label8.Text = compWin.ToString(); // Update win count on the UI
            }
            // Check if the computer chose Rock (user wins)
            else if (comp == 1)
            {
                userWon(); // User wins
                label2.Text = "You WON, Computer LOST the Game";
                label3.Text = "User's Choice: Paper";
                label4.Text = "Computer's Choice: Rock";
                userWin++; // Increment user's win count
                label7.Text = userWin.ToString(); // Update win count on the UI
            }
        }

        // Handles the result if the user chooses Scissors
        public void ScissorsOutput()
        {
            // Check if the computer also chose Scissors (resulting in a tie)
            if (comp == 3)
            {
                tieMatch(); // Tie case
                label2.Text = "Its a TIE, since both chose the same";
                label3.Text = "User's Choice: Scissors";
                label4.Text = "Computer's Choice: Scissors";
            }
            // Check if the computer chose Rock (user loses)
            else if (comp == 1)
            {
                computerWon(); // Computer wins
                label2.Text = "You LOST, Computer WON the Game";
                label3.Text = "User's Choice: Scissors";
                label4.Text = "Computer's Choice: Rock";
                compWin++; // Increment computer's win count
                label8.Text = compWin.ToString(); // Update win count on the UI
            }
            // Check if the computer chose Paper (user wins)
            else if (comp == 2)
            {
                userWon(); // User wins
                label2.Text = "You WON, Computer LOST the Game";
                label3.Text = "User's Choice: Scissors";
                label4.Text = "Computer's Choice: Paper";
                userWin++; // Increment user's win count
                label7.Text = userWin.ToString(); // Update win count on the UI
            }
        }

        // Constructor for the Form1 class (called when the form is initialized)
        public Form1()
        {
            InitializeComponent(); // Initialize UI components
        }

        // Event handler for when the form loads
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Event handler for when the "Rock" button is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            RandomNumberGenerator compChoice = new RandomNumberGenerator(); // Create an instance of RandomNumberGenerator
            comp = compChoice.generateComputerChoice(); // Generate the computer's random choice
            RockOutput(); // Call the RockOutput method to process the result
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        // Event handler for when the "Paper" button is clicked
        private void button2_Click(object sender, EventArgs e)
        {
            RandomNumberGenerator compChoice = new RandomNumberGenerator(); // Create an instance of RandomNumberGenerator
            comp = compChoice.generateComputerChoice(); // Generate the computer's random choice
            PaperOutput(); // Call the PaperOutput method to process the result
        }

        // Event handler for when the "Scissors" button is clicked
        private void button3_Click(object sender, EventArgs e)
        {
            RandomNumberGenerator compChoice = new RandomNumberGenerator(); // Create an instance of RandomNumberGenerator
            comp = compChoice.generateComputerChoice(); // Generate the computer's random choice
            ScissorsOutput(); // Call the ScissorsOutput method to process the result
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
