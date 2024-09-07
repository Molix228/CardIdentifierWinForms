namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1() { 
            InitializeComponent();
            InitializeTextBox();
        }

        public void InitializeTextBox()
        {
            TextBox textBox1 = new TextBox();
        }


        
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Queen of Hearts";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "King of Spades";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3 of Diamonds";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Red Jocker";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Ace of Diamonds";
        }

        
    }
}
