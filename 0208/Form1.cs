namespace _0208
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LB_Click(object sender, EventArgs e)
        {
            int var1, var2, var3, total;
            var1 = int.Parse(textBox1.Text);
            var2 = int.Parse(textBox2.Text);

            total = var1 + var2;

            LBresultado.Text = total.ToString();

        }


        private void BTNMenos_Click(object sender, EventArgs e)
        {
            int var1, var2, var3, total;
            var1 = int.Parse(textBox1.Text);
            var2 = int.Parse(textBox2.Text);

            total = var1 - var2;

            LBresultado.Text = total.ToString();

        }

        private void BTNVezes_Click(object sender, EventArgs e)
        {
            int var1, var2, var3, total;
            var1 = int.Parse(textBox1.Text);
            var2 = int.Parse(textBox2.Text);

            total = var1 * var2;

            LBresultado.Text = total.ToString();
        }
    }
}
