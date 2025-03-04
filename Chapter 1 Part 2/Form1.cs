﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFormsAppWithMessageBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FirstNameValue = FirstName.Text;
            string MiddleNameValue = MiddleName.Text;
            string LastNameValue = LastName.Text;
            string SuffixValue = Suffix.Text;

            DialogResult Result = MessageBox.Show("Are you sure you want to submit?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Result == DialogResult.Yes) {

                MessageBox.Show($"Hello There! {FirstNameValue} {MiddleNameValue} {LastNameValue} {SuffixValue}!", "Greetings!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else {

                MessageBox.Show($"Information was not submitted!", "Cancel Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
