namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        float bill;
        float tipper;
        int totalper;
        float totaltip;
        float totalbill;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void richTextBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        public void richTextBox2_TextChanged(object sender, EventArgs e)
        {
         
        }

        public void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tipper = (float)numericUpDown1.Value;
        }

        public void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
           totalper = (int)numericUpDown2.Value;
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bill = float.Parse(textBox1.Text);
            richTextBox1.ResetText();
            richTextBox2.ResetText();
            try
            {
                if (totalper <= 0)
                    throw new Exception();

                totaltip = bill * tipper / 100 / totalper;
                totalbill = bill / totalper + totaltip;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Number of People cannot be zero");
                numericUpDown2.ResetText();
                richTextBox1.ResetText();
                richTextBox2.ResetText();
                
            }
            richTextBox1.AppendText(totaltip.ToString());
            richTextBox2.AppendText(totalbill.ToString());
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.ResetText();
            richTextBox2.ResetText();
            numericUpDown1.ResetText();
            numericUpDown2.ResetText();
            textBox1.ResetText();
        }
    }
}