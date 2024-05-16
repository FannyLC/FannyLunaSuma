namespace FannyLunaSuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v1, v2, v3;

            v1 = double.Parse(txtNum1.Text);
            v2 = double.Parse(txtNum2.Text);

            v3 = v1 + v2;

            txtResult.Text = v3.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = " ";
            txtNum2.Text = " ";
            txtResult.Text = " ";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
