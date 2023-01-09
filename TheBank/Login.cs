using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBank
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            SidePanel1.Height = button1.Height;
            loginUser1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel1.Height = button1.Height;
            SidePanel1.Top = button1.Top;
            loginUser1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel1.Height = button3.Height;
            SidePanel1.Top = button3.Top;
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel1.Height = button2.Height;
            SidePanel1.Top = button2.Top;
            registerUser1.BringToFront();
        }

        private void registerUser1_Load(object sender, EventArgs e)
        {

        }
    }
}
