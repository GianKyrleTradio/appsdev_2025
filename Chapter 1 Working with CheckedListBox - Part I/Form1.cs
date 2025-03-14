using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFormsAppWithCheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] Movies = { "Sonic", "Venom", "Stitch" };
            CheckListBox.Items.AddRange(Movies);

            CheckListBox.CheckOnClick = true;
        }

        private void CheckListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            foreach (var Movies in CheckListBox.Items) {
                bool isSelected = CheckListBox.GetItemChecked(CheckListBox.Items.IndexOf(Movies));
                if (isSelected && !ListBox.Items.Contains(Movies)) {
                    ListBox.Items.Add(Movies);
                }
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (ListBox.Items.Count >= 1) {
                ListBox.Items.Remove(ListBox.SelectedItem);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ListBox.Items.Clear();
        }
    }
}
