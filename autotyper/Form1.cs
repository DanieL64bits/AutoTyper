//----------------------------------------------------------
//if you want to use my code plase give me some credits
//----------------------------------------------------------
using System;
using System.Windows.Forms;

namespace autotyper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            label6.Visible = false;
            label7.Visible = true;
            button2.Enabled = false;
            button3.Enabled = true;


        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            

            if (radioButton1.Checked)
            {
            SendKeys.Send(textBox1.Text);
            SendKeys.Send("{Enter}");
            }
            else if (radioButton2.Checked)
            {
                SendKeys.Send(textBox1.Text);
                SendKeys.Send(" ");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Visible = true;
            label7.Visible = false;
            button2.Enabled = true;
            button3.Enabled = false;
            timer1.Interval = (int)numericUpDown1.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label6.Visible = true;
            label7.Visible = false;
            button2.Enabled = true;
            button3.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
