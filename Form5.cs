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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult rslt;
            rslt = MessageBox.Show("変更を保存しますか？", "保存確認"
        , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            //NavigatorSaveItem_Clickイベント使用
            if (rslt == DialogResult.Yes)
            {

            }
            else//変更がない場合、そのまま終了
            {

            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
