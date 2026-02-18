namespace Lesson1_Askisi_1
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

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int sum;
            sum = Convert.ToInt32(txtNum1.Text) + Convert.ToInt32(txtNum2.Text);

            txtNum3.Text=sum.ToString();
        }
    }
}
