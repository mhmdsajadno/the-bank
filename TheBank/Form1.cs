namespace TheBank
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Top = button4.Top;
            SidePanel.Width = button4.Width;
            contactUs1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Top = button1.Top;
            SidePanel.Width = button1.Width;
            homepg1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Top = button2.Top;
            SidePanel.Width = button2.Width;
            loan1.BringToFront();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            SidePanel.Top = button1.Top;
            SidePanel.Width = button1.Width;
            homepg1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Top = button3.Top;
            SidePanel.Width = button3.Width;
            installments1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void installments1_Load(object sender, EventArgs e)
        {

        }
    }
}