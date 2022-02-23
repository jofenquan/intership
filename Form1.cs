using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生管理情報
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Id = "2";
            string Pass = "2";
            string Id1 = textBox1.Text;
            string Pass1 = textBox2.Text;

            if (Id1.Equals(Id))
            {
                if (Pass1.Equals(Pass))
                {
                    Form2 form2 = new Form2();
                    this.Hide();

                    if (form2.ShowDialog() == DialogResult.Cancel)
                    {
                        this.Show();
                    }
                }
                else
                {
                    label3.Text = "ID,PASSが違います";
                }
            }
            else
            {
                label3.Text = "ID,PASSが違います";
            }

        
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
