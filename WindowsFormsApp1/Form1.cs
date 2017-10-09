using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class form_mainWindow : Form
    {
        public form_mainWindow()
        {
            InitializeComponent();
      
        }

        private void button_copyText_Click(object sender, EventArgs e)
        {
            label_copiedText.Text = textBox_textToCopy.Text;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_showLabel_Click(object sender, EventArgs e)
        {
            if (label_helloWorld.Visible)
            {
                label_helloWorld.Hide();
            }
            else
            {
                label_helloWorld.Show();
            }
        }

        private void radioButton_red_CheckedChanged(object sender, EventArgs e)
        {
            button_color.BackColor = Color.Red;
        }

        private void radioButton_green_CheckedChanged(object sender, EventArgs e)
        {
            button_color.BackColor = Color.Green;
        }

        private void button_close_Click(object sender, EventArgs e) => Close();
    }
}
