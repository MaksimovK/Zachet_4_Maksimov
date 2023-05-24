using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zachet_4_Maksimov
{
    public partial class Form1 : Form
    {
        List<int> numbersFile;
        List<char> lettersFile;
        List<string> colorsFile;
        List<object> cartesianProduct = new List<object>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void LoadData()
        {
            try
            {
                string[] lettersData = File.ReadAllLines("letters.txt");
                lettersFile = new List<char>(lettersData.Select(line => char.Parse(line)));

                string[] numbersData = File.ReadAllLines("numbers.txt");
                numbersFile = new List<int>(numbersData.Select(line => int.Parse(line)));

                colorsFile = new List<string>(File.ReadAllLines("colors.txt"));
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Файл не найден.");
                return;
            }
            catch (IOException)
            {
                MessageBox.Show("Ошибка чтения файла.");
                return;
            }
        }

        private void btnGenericA_Click(object sender, EventArgs e)
        {
            if (cmbSign.Text == "")
            {
                MessageBox.Show("Выберите признак", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> letters = new List<string>() { "A", "B" };
            List<int> numbers = new List<int>() { 1, 2, 3 };
            List<string> colors = new List<string>() { "зеленый", "оранжевый" };

            var cartesianProduct = from letter in letters
                from number in numbers
                from color in colors
                select new { Буква = letter, Число = number, Цвет = color };

            string groupBy = cmbSign.Text;

            var groupedCartesianProduct = from product in cartesianProduct
                group product by product.GetType().GetProperty(groupBy).GetValue(product, null)
                into g
                select new { GroupName = g.Key, Items = g.ToList() };

            foreach (var group in groupedCartesianProduct)
            {
                MessageBox.Show("Группа: " + group.GroupName + "\n" + String.Join(Environment.NewLine, group.Items),
                    "Декартовы произведения", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGenericB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLetter.Text) || string.IsNullOrWhiteSpace(txtNumber.Text) ||
                string.IsNullOrWhiteSpace(txtColors.Text))
            {
                MessageBox.Show("Есть пустые поля");
                return;
            }

            foreach (var el in txtNumber.Text)
            {
                if (!char.IsDigit(el))
                {
                    MessageBox.Show("Поле цифры содержит буквы!");
                    return;
                }
            }

            if (txtNumber.Text.Length > 1)
            {
                MessageBox.Show("Поле должно содержать только 1 элемент");
                return;
            }

            if (txtLetter.Text.Length > 1)
            {
                MessageBox.Show("Поле должно содержать только 1 элемент");
                return;
            }

            string newLetter = txtLetter.Text;
            int newNumber = Convert.ToInt32(txtNumber.Text);
            string newColor = txtColors.Text;

            var newProduct = new { Буква = newLetter, Число = newNumber, Цвет = newColor };


            List<object> cartesianProductList = new List<object>();

            foreach (var item in cartesianProduct)
            {
                cartesianProductList.Add(item);
            }

            cartesianProductList.Add(newProduct);

            cartesianProduct = cartesianProductList;

            var result = String.Join(Environment.NewLine, cartesianProduct);

            MessageBox.Show(result, "Декартовы произведения", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
            if (cmbSign.Text == "")
            {
                MessageBox.Show("Выберите признак", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var cartesianProduct = from letter in lettersFile
                from number in numbersFile
                from color in colorsFile
                select new { Буква = letter, Число = number, Цвет = color };

            string groupBy = cmbSign.Text;

            var groupedCartesianProduct = from product in cartesianProduct
                group product by product.GetType().GetProperty(groupBy).GetValue(product, null)
                into g
                select new { GroupName = g.Key, Items = g.ToList() };

            foreach (var group in groupedCartesianProduct)
            {
                MessageBox.Show("Группа: " + group.GroupName + "\n" + String.Join(Environment.NewLine, group.Items),
                    "Декартовы произведения", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}