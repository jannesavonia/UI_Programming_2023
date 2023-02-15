namespace test_windwos_forms
{
    public partial class Form1 : Form
    {

        Random randomNumber = new Random();

        int number = 0;
        int guesses = 0;

        public Form1()
        {
            InitializeComponent();

            loadQuestions();
        }

        private void CheckNumber(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txtEnterNumber.Text);

            guesses += 1;
            lblGuessed.Text = "You guessed " + guesses + " times";

            if (i == number)
            {
                MessageBox.Show("Nice, you guessed it. Try another");
                loadQuestions();
                txtEnterNumber.Text = "";
                guesses = 0;
                lblGuessed.Text = "You guessed " + guesses + " times";
            }
            else if (i < number)
            {
                MessageBox.Show("Go Higher");
            }
            else
            {
                MessageBox.Show("Go Lower");
            }


        }

        private void loadQuestions()
        {
            number = randomNumber.Next(0, 10);

            lblQuestion.Text = "I am thinking of a number between: 0 and 10 ";
        }
    }
}