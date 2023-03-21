using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab_1_Marushchak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_name.Text) || String.IsNullOrEmpty(textBox_length.Text))
            {
                MessageBox.Show("Введiть усi дані!");
            }
            else
            {
                File a = new File();

                string name = Convert.ToString(textBox_name.Text);
                DateTime createdDate = dateTimePicker_1.Value;
                int length = Convert.ToInt32(textBox_length.Text);

                a.Add(name, createdDate, length);

                text.Text += a.Print();
                

             
            }
            
        }

        private void textBox_length_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
