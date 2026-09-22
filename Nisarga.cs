using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Nisarga : Form
    {
        public Nisarga()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(comboBox1.SelectedItem);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }
        public void SetResult(string text)
        {
            if (comboBox1.SelectedItem == "A Shift")
            {
                label8.Text = text;
            }
        }
        int pass = 0;
        int total = 0;
        private void btnPass_Click(object sender, EventArgs e)
        {
            pass++;
            if (comboBox1.SelectedItem == "A Shift")
            {
                label3.Text = pass.ToString();
                total = pass + fail;
                label13.Text = total.ToString();
            }
            else if (comboBox1.SelectedItem == "B Shift")
            {
                label9.Text = pass.ToString();
                total = pass + fail;
                label12.Text = total.ToString();
            }
            else if(comboBox1.SelectedItem == "C Shift")
            {
                label16.Text = pass.ToString();
                total = pass + fail;
                label14.Text = total.ToString();
            }

        }
        int fail = 0;
        private void btnFail_Click(object sender, EventArgs e)
        {
            fail++;

            if (comboBox1.SelectedItem == "A Shift")
            {
                label8.Text = fail.ToString();
                total = pass + fail;
                label13.Text = total.ToString();
            }
            else if (comboBox1.SelectedItem == "B Shift")
            {
                label7.Text = fail.ToString();
                total = pass + fail;
                label12.Text = total.ToString();
            }
            else if (comboBox1.SelectedItem == "C Shift")
            {
                label15.Text = fail.ToString();
                total = pass + fail;
                label14.Text = total.ToString();
            }
        }
    }
}
