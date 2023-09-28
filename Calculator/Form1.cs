namespace Calculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void bplus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void bminus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void bumnozh_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void bdelenie_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void bCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void bq_Click(object sender, EventArgs e)
        {
            textBox1.Text += "(";
        }

        private void bw_Click(object sender, EventArgs e)
        {
            textBox1.Text += ")";
        }

        private void be_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '(' && e.KeyChar != ')' && e.KeyChar != ',' && e.KeyChar != '/' && e.KeyChar != '*' && e.KeyChar != '-' && e.KeyChar != '+' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void bresult_Click(object sender, EventArgs e)
        {

            try
            {
                string expression = textBox1.Text;
                var result = new System.Data.DataTable().Compute(expression, null);
                textBox1.Text = result.ToString();
            }
            catch (Exception)
            {
                textBox1.Text = "ERROR!";
            }
        }

    }
}