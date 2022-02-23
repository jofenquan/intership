using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生管理情報
{
    public partial class Form3 : Form
    {
        private static string FILE_PATH = @"C:\Users\user\Desktop\Login\";
        private static string FILE_NAME = "Text.txt";
        Form2 fgrid;
        public Form3(Form2 fg)
        {
            InitializeComponent();

            this.fgrid = fg;
            

            this.loginId.ScrollBars = ScrollBars.Vertical;

            this.loginId.HideSelection = false;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter Writer = new StreamWriter(FILE_PATH + FILE_NAME, true);

            string[] txt = { loginId.Text, lastName.Text, firstName.Text, year.Text, school.Text, address.Text, birthday.Text, department.Text, subject.Text, mail.Text, tel.Text, intership.Text, comment.Text };
            TextBox[] textB = { loginId, lastName, year, school, address, subject, department, tel, firstName, birthday, mail, intership, comment };

            for (int i = 0; i < 12; i++)
            {
                Writer.Write("{0},", txt[i]);
            }
            Writer.WriteLine(comment.Text);

            for (int i = 0; i < 13; i++)
            {
                textB[i].Text = "";

            }
            Writer.Close();
            /*MessageBox.Show("データ送信完了しました", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
            String[] lines = File.ReadAllLines(@"C:\Users\user\Desktop\Login\Text.txt");
            String[] Values;
            //fgrid.dataGridView1.Rows.Clear();]


            for (int i = 0; i < lines.Length; i++)
            {
                Values = lines[i].ToString().Split('/');
                String[] row = new string[Values.Length];
                for (int j = 0; j < Values.Length; j++)
                {
                    row[j] = Values[j].Trim();
                }
                //object p = fgrid.dataGridView1.Rows.Add(row);
            }
            this.Hide();*/

        
    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            string textValue = loginId.Text;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string textValue = year.Text;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            string textValue = birthday.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string textValue = address.Text;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            string textValue = address.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string textValue = lastName.Text;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            string textValue = firstName.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string textValue = school.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string textValue = department.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string textValue = subject.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            string textValue = tel.Text;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            string textValue = intership.Text;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("終了しますか？", "確認",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
            }
            else
            {
                this.Close();
            }
        }
    }
}
