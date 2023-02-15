namespace _24
{
    public partial class Form1 : Form
    {
        int number;
        int guessNumber = 0;
        public Form1()
        {
            InitializeComponent();
            
            var rndgenerator= new Random();
            number=rndgenerator.Next(0, 101);
            
            labelNumber.Text=number.ToString();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            guessNumber++;
            int guess = Convert.ToInt32(textBoxInput.Text);
            textBoxInput.Text = "";


            bool correctAnswer = false;
            if(guess>number)
            {
                labelMessage.Text = "Guess was too big!";
            } else if(guess<number)
            {
                labelMessage.Text = "Guess was too small";
            } else
            {
                labelMessage.Text = "You guessed it with "+guessNumber.ToString()+" guesses!";
                correctAnswer = true;
            }

            if(guessNumber==7 || correctAnswer)
            {
                buttonOk.Enabled = false;
            }

            if(correctAnswer)
            {
                Text = "You won!";
            }
            else if(correctAnswer && guessNumber==7)
            {
                Text = "You lose!";
            }  

        }
    }
}