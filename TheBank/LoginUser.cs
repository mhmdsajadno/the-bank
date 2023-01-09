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
    
    public partial class LoginUser : UserControl
    {
        public LoginUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test.id = loginUsTxt.Text;

            if (loginUsTxt.Text == "admin" && loginPsTxt.Text == "admin")
            {
                this.Hide();
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.Show();
                
            }

            else if (File.Exists($@"C:\\Users\\mhmds\\source\\repos\\TheBank\\TheBank\bin\\Debug\\net6.0-windows\\Data\\{loginUsTxt.Text}.txt"))
            {
                TextReader read = File.OpenText($@"C:\\Users\\mhmds\\source\\repos\\TheBank\\TheBank\bin\\Debug\\net6.0-windows\\Data\\{loginUsTxt.Text}.txt");
                string? textLine = read.ReadLine();
                string[] bits = textLine.Split('-');
                if (bits[3] == loginPsTxt.Text)
                {
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
            }

            else
            {
                MessageBox.Show("!نام کاربری یا گذرواژه صحیح نمی‌باشد","خطا",MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("گذرواژه تلفن همراه شماست");
        }
    }
}
