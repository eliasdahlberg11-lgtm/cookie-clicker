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
         label1.Text = counter.ToString();
        }

        

        
    }
}
