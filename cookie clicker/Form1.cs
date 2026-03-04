namespace cookie_clicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double counter = 0;
        double multiplier = 1;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         counter ++ 1;
        }

        

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = counter.ToString();
        }
    }
}
