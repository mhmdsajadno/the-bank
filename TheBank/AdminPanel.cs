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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;

namespace TheBank
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        //خواندن اطلاعات مشتری از فایل
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            var txtFiles = Directory.EnumerateFiles($@"C:\\Users\\mhmds\\source\\repos\\TheBank\\TheBank\bin\\Debug\\net6.0-windows\\Data\\", "*.txt");
            foreach (string currentFile in txtFiles)
            {
                TextReader textReader = File.OpenText(currentFile);
                string textLine1 = textReader.ReadLine();
                string[] bits1 = textLine1.Split('-');
                dataGridView1.Rows.Add(bits1[0], bits1[1], bits1[2], bits1[3], bits1[4], bits1[5]);
            }
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UserEdit userEdit = new UserEdit();
            userEdit.ShowDialog();
        }

        //بستن برنامه
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //انتخاب فایل توسط ادمین برای ویرایش
        string filename = "";
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                filename = row.Cells[1].Value.ToString() + ".txt";
            }
            FileID.id = filename;
        }

        //حذف حساب و فایل
        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                string str = $@"C:\Users\mhmds\source\repos\TheBank\TheBank\bin\Debug\net6.0-windows\Data\{filename}";
                //string dir = $@"C:\Users\mhmds\source\repos\TheBank\TheBank\bin\Debug\net6.0-windows\Deleted Data";
                //File.Move(str, Path.Combine(dir, Path.GetFileName(str)));
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                dataGridView1.Refresh();
                dataGridView1.RefreshEdit();
                File.Delete(str);
            }
            catch
            {
                MessageBox.Show("!ابتدا یک نفر را از لیست انتخاب کنید", "خطا");
            }

        }

    }
}
