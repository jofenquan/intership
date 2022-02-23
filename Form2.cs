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

namespace 学生管理情報
{
    public partial class Form2 : Form

    {
        private DataTable table;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            table = new DataTable("Table");

            table.Columns.Add("Login ID");
            table.Columns.Add("性");
            table.Columns.Add("名");
            table.Columns.Add("学年", Type.GetType("System.Int32"));
            table.Columns.Add("学校");
            table.Columns.Add("住所");
            table.Columns.Add("生年月日");
            table.Columns.Add("学部");
            table.Columns.Add("学科");
            table.Columns.Add("メール");
            table.Columns.Add("電話番号");
            table.Columns.Add("参加したインターンシップ");
            table.Columns.Add("コメント");
            
            

            readFileIntoTable(table.Rows);
            //table.Rows.Add("001", "村上 飛鳥", "室蘭工業大学", "工学部", "情報電子工学系学科", "3", "1", "1999", "22", "090", "mery19991811@gmail.com");

            dataGridView1.DataSource = table;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            /*DataRow[] dRows = table.AsEnumerable()
               .Where(row => row.Field<string>("氏名") == textBox1.Text).ToArray();
            DataTable sub = new DataTable("sub");


            sub.Columns.Add("Login ID");
            sub.Columns.Add("氏名");
            sub.Columns.Add("大学");
            sub.Columns.Add("学部");
            sub.Columns.Add("学科");
            sub.Columns.Add("学年", Type.GetType("System.Int32"));
            sub.Columns.Add("性別");
            sub.Columns.Add("生年月日", Type.GetType("System.Int32"));
            sub.Columns.Add("年齢", Type.GetType("System.Int32"));
            sub.Columns.Add("電話番号", Type.GetType("System.Int32"));
            sub.Columns.Add("メール");
            foreach (var row in dRows)
            {
                sub.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10]);
            }

            dataGridView1.DataSource = sub;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection src = dataGridView1.SelectedRows;
            for (int i = src.Count - 1; i >= 0; i--)
            {
                dataGridView1.Rows.RemoveAt(src[i].Index);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            this.Hide();

            if (form3.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();

            if (form5.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form6 form6 = new Form6();
            this.Hide();

            if (form6.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form3 showNewFormOnButtonClick = new Form3(this);
            showNewFormOnButtonClick.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form5 showNewFormOnButtonClick = new Form5();
            showNewFormOnButtonClick.Show();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form6 form6 = new Form6();
            this.Hide();

            if (form6.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void readFileIntoTable(DataRowCollection rowCollection)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\user\Desktop\Login\Text.txt");
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(',');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                rowCollection.Add(row);
            }

        }
    }
}


