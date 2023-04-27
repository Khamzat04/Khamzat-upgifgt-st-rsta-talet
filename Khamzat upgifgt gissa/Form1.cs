namespace Khamzat_upgifgt_gissa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Text = "";


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t1 = textBox1.Text;
            double tal1 = double.Parse(t1);
            string t2 = textBox2.Text;
            double tal2 = double.Parse(t2);
            double max = tal1 > tal2 ? tal1 : tal2;

            button1.Text = "Det största talet " + max;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}