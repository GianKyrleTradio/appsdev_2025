using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFavoriteCartoonFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] Cartoon = { "Spongebob", "Patrick", "Mr.Krabs", "Sandy" };
            ComboBox.Items.AddRange(Cartoon);

            ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            ComboBox.SelectedIndex = 0;

        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            PictureBox.Image = null;
        }

        private void View_Click(object sender, EventArgs e)
        {
            
            string selectedItems = ComboBox.SelectedItem.ToString();

            switch (selectedItems) 
            {

                case "Spongebob":
                    PictureBox.Image = Image.FromFile(@"C:/Users/OO144/Downloads/190503220200-spongebob-squarepants-story-top.jpg");
                    break;

                case "Patrick":
                    PictureBox.Image = Image.FromFile(@"C:/Users/OO144/Downloads/dumb-patrick.gif");
                    break;

                case "Mr.Krabs":
                    PictureBox.Image = Image.FromFile(@"C:/Users/OO144/Downloads/images.jpg");
                    break;

                case "Sandy":
                    PictureBox.Image = Image.FromFile(@"C:/Users/OO144/Downloads/415a8e50dcab4ef99543548b5ad938147d5fc194_00.jpg");
                    break;

                default:
                    PictureBox = null;
                    break;
            }

        }
    }
}
