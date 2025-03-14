namespace Kalkulacka_oknova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            float vysledok = a + b;
            label1.Text = "Vysledok je: " + vysledok.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            float vysledok = a - b;
            label1.Text = "Vysledok je: " + vysledok.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            float vysledok = a * b;
            label1.Text = "Vysledok je: " + vysledok.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            float vysledok = a / b;
            label1.Text = "Vysledok je: " + vysledok.ToString();
        }
    }
}
