namespace PowerBallWinner
{
    public partial class PowerBall : Form
    {
        public PowerBall()
        {
            InitializeComponent();
        }

        List<int> winningNumbers = new List<int>();
        List<int> enteredNumbers = new List<int>();

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();

            for (int i = 1; i <= 6; i++)
            {
                Label numberLabel = new Label();
                int value = random.Next(1, 100);
                winningNumbers.Add(value);
                numberLabel.Text = value.ToString();
                numberLabel.Font = new Font("Arial", 10);
                numberLabel.ForeColor = Color.Blue;
                numberLabel.TextAlign = ContentAlignment.MiddleCenter;

                // Set the position of the label within the panel
                int labelX = 20 + (i - 1) * 70; // Adjust the X position to spread them horizontally
                numberLabel.Location = new Point(labelX, 100);

                // Add the label to the panel
                NumberDisplay.Controls.Add(numberLabel);
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           int.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkWinnerBut_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 6; i++)
            {
                string textBoxName = "textBox" + i;
                TextBox textBox = this.Controls[textBoxName] as TextBox;

                if (textBox != null)
                {
                    if (int.TryParse(textBox.Text, out int value))
                    {
                        enteredNumbers.Add(value);
                    }
                    else
                    {
                        MessageBox.Show($"Invalid value in {textBoxName}");
                    }
                }
            }

            bool flag = true;

            for (int i = 0; i <= 5; i++)
            {
                if (enteredNumbers[i] != winningNumbers[i])
                {
                    flag = false;
                    break;
                }
            }

            if (flag)
            {
                MessageBox.Show("You win!");
            }
            else
            {
                MessageBox.Show("You didn't win.");
            }

            enteredNumbers.Clear();
            winningNumbers.Clear();


        }

        

        
    }
}