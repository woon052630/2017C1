using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox3.Text);
            label1.Text = (x + y).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox3.Text);
            label1.Text = (x - y).ToString();
        }
        private string caculator(int i)
       {
            int num;
            switch (i)
            {
                case 1:
                    num = int.Parse(textBox1.Text) + int.Parse(textBox3.Text);
                    return num.ToString();
                case 2:
                    num = int.Parse(textBox1.Text) * int.Parse(textBox3.Text);
                    return num.ToString();
                case 3:
                    num = int.Parse(textBox1.Text) /int.Parse(textBox3.Text);
                    return num.ToString();

                default:
                    num = int.Parse(textBox3.Text) - int.Parse(textBox1.Text);
                    return num.ToString();

            }
        }



    }
}
