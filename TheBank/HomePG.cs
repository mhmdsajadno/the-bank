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
    public partial class HomePG : UserControl
    {
        public HomePG()
        {
            InitializeComponent();
            
        }

        private void HomePG_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                string? id = Test.id;
                string path = $@"C:\\Users\\mhmds\\source\\repos\\TheBank\\TheBank\bin\\Debug\\net6.0-windows\\Data\\{id}.txt";
                TextReader textReader = File.OpenText(path);
                string? textLine = textReader.ReadLine();
                string[] bits = textLine.Split('-');

                lblName.Text = bits[0];
                lblId.Text = bits[1];
                lblBirthday.Text = bits[2];
                lblPhone.Text = bits[3];
                lblAdd.Text = bits[4];
                lblPostal.Text = bits[5];
                lblMoney.Text = bits[6];
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            long m = long.Parse(lblMoney.Text);
            long res = m + long.Parse(textBox1.Text);
            lblMoney.Text = res.ToString();

            string? id = Test.id;
            string path = $@"C:\\Users\\mhmds\\source\\repos\\TheBank\\TheBank\bin\\Debug\\net6.0-windows\\Data\\{id}.txt";
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('-');
                if (i == 6)
                {
                    lines[6] = lblMoney.Text;
                }
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            File.WriteAllLines(path, lines);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            long m = long.Parse(lblMoney.Text);
            long res = m - long.Parse(textBox1.Text);
            lblMoney.Text = res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            textBox1.Visible = true;
        }
    }
}
