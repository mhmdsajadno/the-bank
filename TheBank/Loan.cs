using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBank
{
    public partial class Loan : UserControl
    {
        public Loan()
        {
            InitializeComponent();
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Loan_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                //comboBox1.Items.Add("6");
                comboBox1.Items.Add("12");

                comboBox2.Items.Add("30");
                comboBox2.Items.Add("20");

                //comboBox3.Items.Add("6");
                comboBox3.Items.Add("12");
            }

        }

        //محاسبه وام
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                long m = long.Parse(textBox1.Text);
                long c1 = long.Parse(comboBox1.Text);
                long c2 = long.Parse(comboBox2.Text);
                long c3 = long.Parse(comboBox3.Text);
                long res = (m * c2 * (c1 + c3) / 2400L) + m;

                label7.Text = res.ToString();

                button1.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;

            }
            catch
            {
                MessageBox.Show("!تمام موارد را انتخاب نمایید", "خطا");
            }

        }

        //ثبت وام
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string? id = Test.id;
                string path = $@"C:\\Users\\mhmds\\source\\repos\\TheBank\\TheBank\bin\\Debug\\net6.0-windows\\Data2\\{id}L.txt";
                //using (StreamWriter sw = File.CreateText(path)) ;
                string createText = label7.Text + Environment.NewLine;
                File.WriteAllText(path, createText);
                MessageBox.Show("وام شما ثبت شد", "تاییدیه");
            }
            catch
            {
                MessageBox.Show("مشتری یک بار درخواست داده است");
            }

        }
    }
}
