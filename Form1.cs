namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal txt1 = Convert.ToDecimal(textBox1.Text);

            decimal txt2 = Convert.ToDecimal(textBox2.Text);

            decimal sum = txt1 + txt2;

            textBox3.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal txt1 = Convert.ToDecimal(textBox1.Text);

            decimal txt2 = Convert.ToDecimal(textBox2.Text);

            decimal diff = txt1 - txt2;

            textBox3.Text = diff.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal txt1 = Convert.ToDecimal(textBox1.Text);

            decimal txt2 = Convert.ToDecimal(textBox2.Text);

            decimal product = txt1 * txt2;

            textBox3.Text = product.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal txt1 = Convert.ToDecimal(textBox1.Text);

            decimal txt2 = Convert.ToDecimal(textBox2.Text);

            decimal division = txt1 / txt2;

            textBox3.Text = division.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            decimal txt1 = Convert.ToDecimal(textBox1.Text);

            decimal txt2 = Convert.ToDecimal(textBox2.Text);

            decimal percent = (txt1 / txt2) * 100;

            textBox3.Text = percent.ToString();
        }
    }
}