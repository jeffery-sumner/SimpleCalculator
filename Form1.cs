using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Attribute to make the standard text box output null
        public class MaybeNull : Attribute
        {

        }
        public decimal Txt1 { get; set; }
        public decimal Txt2 { get; set; }
        public string Txt3 { get; set; }

        //Calculator history method
        [MaybeNull]
        public decimal CalculationHistory(decimal txt1, decimal txt2, string op, decimal v)
        {
            Txt1 = txt1;
            Txt2 = txt2;
            textBox3.Text = op;
            return v;
        }

        //Add button
        private void button1_Click(object sender, EventArgs e)
        {
            decimal txt1 = Convert.ToDecimal(textBox1.Text);

            decimal txt2 = Convert.ToDecimal(textBox2.Text);

            decimal sum = txt1 + txt2;

            textBox3.Text = sum.ToString();
        }

        //Subtract button
        private void button2_Click(object sender, EventArgs e)
        {
            decimal txt1 = Convert.ToDecimal(textBox1.Text);

            decimal txt2 = Convert.ToDecimal(textBox2.Text);

            decimal diff = txt1 - txt2;

            textBox3.Text = diff.ToString();
        }

        //Multiply button
        private void button3_Click(object sender, EventArgs e)
        {
            decimal txt1 = Convert.ToDecimal(textBox1.Text);

            decimal txt2 = Convert.ToDecimal(textBox2.Text);

            decimal product = txt1 * txt2;

            textBox3.Text = product.ToString();
        }

        //Divide button
        private void button4_Click(object sender, EventArgs e)
        {
            decimal txt1 = Convert.ToDecimal(textBox1.Text);

            decimal txt2 = Convert.ToDecimal(textBox2.Text);

            decimal division = txt1 / txt2;

            textBox3.Text = division.ToString();
        }

        //Percentage button
        private void button5_Click(object sender, EventArgs e)
        {
            decimal txt1 = Convert.ToDecimal(textBox1.Text);

            decimal txt2 = Convert.ToDecimal(textBox2.Text);

            decimal percent = (txt1 / txt2) * 100;

            textBox3.Text = percent.ToString();
        }

        //Clear button
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        //Stay on top button
        private void button7_Click(object sender, EventArgs e)
        {
            TopMost = true;
        }

        //Event handler for the History Form
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //History button
        private void button8_Click(object sender, EventArgs e)
        {
            var History = new History();
            History.Show();
        }

    }
}