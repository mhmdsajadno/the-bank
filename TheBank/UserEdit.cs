using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBank
{
    public partial class UserEdit : Form
    {
        public UserEdit()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserEdit_Load(object sender, EventArgs e)
        {

            try
            {
                string? id = FileID.id;
                string path = $@"C:\\Users\\mhmds\\source\\repos\\TheBank\\TheBank\bin\\Debug\\net6.0-windows\\Data\\{id}";
                TextReader reader = File.OpenText(path);
                string? textLine = reader.ReadLine();
                string[] bits = textLine.Split('-');
                userfullNameTxb.Text = bits[0];
                useridTxb.Text = bits[1];
                userBirthdayPicker.Text = bits[2];
                usernumberTxb.Text = bits[3];
                useradressTxb.Text = bits[4];
                userPostalTxb.Text = bits[5];
                reader.Close();
            }
            catch
            {
                MessageBox.Show("ابتدا یک مورد از لیست انتخاب کنید", "خطا");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            StreamWriter streamWriter = new StreamWriter(Application.StartupPath + $"\\Data\\{useridTxb.Text}.txt");
            streamWriter.WriteLine(userfullNameTxb.Text + "-" + useridTxb.Text + "-" + userBirthdayPicker.Text + "-" + usernumberTxb.Text + "-" + useradressTxb.Text + "-" + userPostalTxb.Text + "-" + "0");
            streamWriter.Close();
        }
    }
}
