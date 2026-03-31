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
        int cost = 5;
        int lvl = 1;
        int cost2 = 100;
        int lvl2 = 1;
        int multiplier2 = 1;
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


            if (counter >= cost)
            {
                counter = counter - cost;
                multiplier = multiplier * 10;
                lvl = lvl + 1;
                label2.Text = "Multiplier lvl " + lvl.ToString();
                cost = cost * 8;
                label3.Text = "Cost" + cost;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (counter >= cost)
            {
                lvl2 = lvl2 + 1;
                label5.Text = "Granny" + lvl2;
                counter = counter - cost2;
                timer1.Enabled = true;
                multiplier2 = multiplier2 * 10;
                cost2 = cost2 * 5;
                label4.Text = "Cost " + cost2;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter = counter + multiplier2;
            if (counter == 1)
            {
                label1.Text = counter.ToString() + " cookie";
            }
            else
            {
                label1.Text = counter.ToString() + " cookies";
            }

        }
    }
}
