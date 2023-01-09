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
    public partial class Installments : UserControl
    {
        public Installments()
        {
            InitializeComponent();
        }

        private void Installments_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string? id = Test.id;
                string path = $@"C:\\Users\\mhmds\\source\\repos\\TheBank\\TheBank\bin\\Debug\\net6.0-windows\\Data2\\{id}L.txt";
                TextReader reader = File.OpenText(path);
                string? textLine = reader.ReadLine();
                string[] bits = textLine.Split('-');
                string res = bits[0];
                long installment = long.Parse(res);
                long a = installment / 12;
                long b = installment % 12;
                for (int i = 1; i <= 12; i++)
                {
                    dataGridView1.Rows.Add(i, a);
                }
                dataGridView1.Rows.Add(13, b);
                dataGridView1.Visible = true;
                button1.Visible = false;
                reader.Close();
            }
            catch
            {
                MessageBox.Show("وامی وجود ندارد");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.RemoveAt(0);
        }
    }
}
