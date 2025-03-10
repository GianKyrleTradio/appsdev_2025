using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFormsAppWithListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBox.Text) && !lstBox.Items.Contains(txtBox.Text)) 
            {

                lstBox.Items.Add(txtBox.Text);    

            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {

            lstBox.Items.Remove(lstBox.SelectedItem);

        }

        private void Clear_Click(object sender, EventArgs e)
        {

            lstBox.Items.Clear();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
