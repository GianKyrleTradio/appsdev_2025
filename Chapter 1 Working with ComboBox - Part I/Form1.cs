using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFormsAppWithComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] Cuisine = { "Filipino", "Japanese", "Chinese", "Korean" };
            ComboBox.Items.AddRange(Cuisine);

            ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            ComboBox.SelectedItem = 0;

            FoodCheckListBox.CheckOnClick = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            foreach (var item in FoodCheckListBox.Items){
                bool isSelected = FoodCheckListBox.GetItemChecked(FoodCheckListBox.Items.IndexOf(item));
                if (isSelected && !FoodListBox.Items.Contains(item))
                {
                    FoodListBox.Items.Add(item);
                }
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (FoodListBox.Items.Count >= 1)
            {
                FoodListBox.Items.Remove(FoodListBox.SelectedItem);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            FoodListBox.Items.Clear();
        }

        private void Select_Click(object sender, EventArgs e)
        {
            string[] FilipinoDish = { "Adobo", "Sinigang", "Lechon", "Pancit", "Lumpia" };
            string[] JapaneseDish = { "Sushi", "Omurice", "Tonkatsu", "Yakitori", "Curry",};
            string[] ChineseDish = { "Dim Sum", "Dumplings", "Tofu", "Char Siu", "Hot Pot" };
            string[] KoreanDish = { "Kimchi", "Japchae", "Mandu", "Bulgog", "Bibimbap" };

            FoodCheckListBox.Items.Clear();

            if (ComboBox.SelectedItem.ToString().Contains("Filipino"))
            {
                FoodCheckListBox.Items.AddRange(FilipinoDish);
            }
            else if (ComboBox.SelectedItem.ToString().Contains("Japanese"))
            {
                FoodCheckListBox.Items.AddRange(JapaneseDish);
            }
            else if (ComboBox.SelectedItem.ToString().Contains("Chinese"))
            {
                FoodCheckListBox.Items.AddRange(ChineseDish);
            }
            else if (ComboBox.SelectedItem.ToString().Contains("Korean"))
            {
                FoodCheckListBox.Items.AddRange(KoreanDish);
            }
        }

        private void FoodCheckListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
    

