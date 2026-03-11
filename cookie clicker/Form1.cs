namespace cookie_clicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int counter = 0;
        int multiplier = 1;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            counter = counter + multiplier;
            if (counter == 1)
            {
                label1.Text = counter.ToString() + " cookie";
            }
            else
            {
                label1.Text = counter.ToString() + " cookies";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if ((counter >= 10) && (multiplier == 1))
            {
                multiplier = 2;
            }
            else if ((counter >= 50) && (multiplier == 2))
            {
                multiplier = 3;
            }

            label2.Text = "Multiplier lvl " + multiplier.ToString();

        }
    }
}
