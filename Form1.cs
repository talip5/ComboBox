using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load+=Form1_Load;
            comboBox1.TextChanged+=ComboBox1_TextChanged;
        }

        private void ComboBox1_TextChanged(object sender, EventArgs e)
        {
            //label1.Text = comboBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("izmir");
            comboBox1.Items.Add("ankara");
            comboBox1.Items.Add("istanbul");
            //lalabel1.Text = comboBox1.Items[1].ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //comboBox1.Items.RemoveAt(0);
            //label1.Text = comboBox1.SelectedItem.ToString();
            int changed = comboBox1.SelectedIndex;
            if (changed>=0)
            {
                label1.Text = changed.ToString();
                comboBox1.Items.RemoveAt(changed);
            }
            else
            {
                label1.Text ="please City entering";
            }
            
            //comboBox1.Items.Remove("izmir");
        }
    }
}
