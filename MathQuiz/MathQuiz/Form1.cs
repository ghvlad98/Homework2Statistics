namespace MathQuiz
{
    public partial class Form1 : Form
    {   

        Random ran = new Random();
        int addend1;
        int addend2;
        int minuend;
        int subtrahend;
        int timeLeft;

        public void startQuiz()
        {
            addend1 = ran.Next(51);
            addend2 = ran.Next(51);
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            sum.Value = 0;

            minuend = ran.Next(1, 101);
            subtrahend = ran.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            timeLeft = 10;
            timeLabel.Text = "10 seconds";
            timer1.Start();
        }

        private bool check()
        {
            if ((addend1 + addend2 == sum.Value) && (minuend - subtrahend == difference.Value))
                return true;
            else
                return false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (check())
            {
                timer1.Stop();
                MessageBox.Show("All answers are right!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time finished!";
                MessageBox.Show("You didn't finish in time!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                startButton.Enabled = true;
            }
        }

        private void plusLabel_Click(object sender, EventArgs e)
        {

        }
    }
}