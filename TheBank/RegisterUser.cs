using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TheBank
{
    public partial class RegisterUser : UserControl
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists($@"C:\\Users\\mhmds\\source\\repos\\TheBank\\TheBank\bin\\Debug\\net6.0-windows\\Data\\{useridTxb.Text}.txt"))
            {
                StreamWriter streamWriter = new StreamWriter(Application.StartupPath + $"\\Data\\{useridTxb.Text}.txt");
                streamWriter.WriteLine(userfullNameTxb.Text + "-" + useridTxb.Text + "-" + userBirthdayPicker.Text + "-" + usernumberTxb.Text + "-" + useradressTxb.Text + "-" + userPostalTxb.Text + "-" + "0");
                streamWriter.Close();
                MessageBox.Show("!‌اطلاعات شما ویرایش شد");
                //MessageBox.Show("!مشتری وجود دارد");
            }
            else
            {
                StreamWriter streamWriter = new StreamWriter(Application.StartupPath + $"\\Data\\{useridTxb.Text}.txt");
                streamWriter.WriteLine(userfullNameTxb.Text + "-" + useridTxb.Text + "-" + userBirthdayPicker.Text + "-" + usernumberTxb.Text + "-" + useradressTxb.Text + "-" + userPostalTxb.Text + "-" + "0" );
                streamWriter.Close();
                MessageBox.Show("!‌اطلاعات شما ذخیره شد");
            }
            userfullNameTxb.Text = "";
            useridTxb.Text = "";
            usernumberTxb.Text = "";
            useradressTxb.Text = "";
        }

        private void useridTxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void usernumberTxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
