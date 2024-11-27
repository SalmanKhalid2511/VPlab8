using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9act1
{
    public partial class Form2 : Form
    {
        Form1 f1 = new Form1();
        public Form2()
        {
            InitializeComponent();
        }
        public void get_information(TextBox t1 , ComboBox c1 , RadioButton r1, CheckBox cc1 , RadioButton r2)
        {
            label1.Text = t1.Text;
            label2.Text = c1.SelectedItem.ToString();
            label3.Text = r1.Checked
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
