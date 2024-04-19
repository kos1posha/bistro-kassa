using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace s3_pr_cw
{
    public partial class EditMenuWindow : Form
    {
        List<Menu> MenuList;

        Menu CurrentMenu => (Menu)menuListComboBox.SelectedItem;
        Product CurrentProduct => CurrentMenu.Products[CurrentProductIndex];
        int CurrentProductIndex => productListComboBox.SelectedIndex == -1 ? Convert.ToInt32(numberTextBox.Text) - 1 : Convert.ToInt32(productListComboBox.SelectedItem.ToString().Substring(1, 2)) - 1;
        bool ClearCurrentMenus = true;

        public EditMenuWindow(List<Menu> menuList)
        {
            InitializeComponent();

            MenuList = menuList;

            UpdateMenuListComboBox();
        }

        public static bool Show(List<Menu> menuList)
        {
            EditMenuWindow editMenuWindow = new EditMenuWindow(menuList);
            editMenuWindow.ShowDialog();
            return editMenuWindow.ClearCurrentMenus;
        }

        Menu UpdateMenuListComboBox()
        {
            Menu currentMenu = CurrentMenu;
            menuListComboBox.Items.Clear();
            foreach (Menu menu in MenuList)
                menuListComboBox.Items.Add(menu);
            return currentMenu;
        }
        void UpdateProductListComboBox()
        {
            Menu currentMenu = CurrentMenu;
            productListComboBox.Items.Clear();
            for (int i = 0; i < 24; i++)
                if (!currentMenu.Products[i].IsEmpty)
                    productListComboBox.Items.Add(ComboBoxView(currentMenu, i));
        }
        void CreateProduct()
        {
            if (CurrentMenu == null)
            {
                MessageBox.Show("Выберите раздел, в который хотите добавить продукт");
                return;
            }
            if (CurrentMenu.IsFull)
            {
                MessageBox.Show("Раздел заполнен", "Добавление новых продуктов невозможно");
                return;
            }
            currentProductPanel.Visible = true;
            productImage.Image = null;
            productImage.BackColor = Color.LightGray;
            nameTextBox.Text = "";
            weightTextBox.Text = "";
            priceTextBox.Text = "";
            vaxTextBox.Text = "20";
            for (int i = 0; i < 24; i++)
                if (CurrentMenu.Products[i].IsEmpty)
                {
                    numberTextBox.Text = (i + 1).ToString();
                    break;
                }
        }
        void ShowProduct(int index)
        {
            Product product = CurrentMenu.Products[index];
            currentProductPanel.Visible = true;
            productImage.Image = null;
            if (product.Image != null)
                productImage.Image = product.Image;
            else
                productImage.BackColor = product.Color;
            nameTextBox.Text = product.Name;
            weightTextBox.Text = product.Weight.ToString();
            priceTextBox.Text = product.Price.ToString();
            vaxTextBox.Text = product.VAX.ToString();
            numberTextBox.Text = (index + 1).ToString();
        }
        string ComboBoxView(Menu menu, int index)
            => $"[{(index + 1).ToString().PadLeft(2, '0')}] {menu.Products[index].Name}";

        private void addNewMenuButton_Click(object sender, EventArgs e)
        {
            Menu newMenu = SetMenuNameWindow.Show();
            if (!(newMenu.Name == null))
                MenuList.Add(newMenu);
            UpdateMenuListComboBox();
        }
        private void deleteMenuButton_Click(object sender, EventArgs e)
        {
            if (CurrentMenu == null)
            {
                MessageBox.Show("Выберите раздел, который хотите удалить, из списка");
                return;
            }
            if (MessageBox.Show("Вы уверены?", "Выбранный раздел будет безвозвратно удален", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MenuList.Remove(CurrentMenu);
                currentProductPanel.Visible = false;
                productListComboBox.Items.Clear();
                UpdateMenuListComboBox();
            }
        }
        private void editMenuNameButton_Click(object sender, EventArgs e)
        {
            if (menuListComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите раздел, название которого хотите изменить");
                return;
            }
            SetMenuNameWindow.Show(CurrentMenu);
            menuListComboBox.SelectedItem = UpdateMenuListComboBox();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (currentProductPanel.Visible == false)
                return;
            int currentIndex = CurrentProductIndex;
            string message = string.Empty;
            if (nameTextBox.Text == "")
                message += " название,";
            if (weightTextBox.Text == "")
                message += " вес,";
            if (priceTextBox.Text == "")
                message += " цена,";
            if (vaxTextBox.Text == "")
                message += " НДС,";
            if (numberTextBox.Text == "")
                message += " номер в меню,";
            if (message != string.Empty)
            {
                MessageBox.Show($"Не указано:{message.Remove(message.Length - 1)} продукта");
                return;
            }
            message = productListComboBox.SelectedIndex == -1 ? "Добавить новый продукт?" : "Сохранить изменения?";
            if (MessageBox.Show(message, MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (productListComboBox.SelectedIndex != -1)
                    CurrentMenu.Add(new Product(), currentIndex);
                CurrentMenu.Add(new Product(nameTextBox.Text, Convert.ToInt32(weightTextBox.Text), Convert.ToInt32(vaxTextBox.Text), Convert.ToDecimal(priceTextBox.Text), productImage.BackColor, productImage.Image), Convert.ToInt32(numberTextBox.Text) - 1);
                ShowProduct(Convert.ToInt32(numberTextBox.Text) - 1);
            }
            UpdateProductListComboBox();
            currentProductPanel.Visible = false;
        }
        private void doneButton_Click(object sender, EventArgs e)
            => Hide();

        private void menuListComboBox_SelectedIndexChanged(object sender, EventArgs e)
            => UpdateProductListComboBox();
        private void enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                menuListLabel.Focus();
        }
        private void onlyNumb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;
            if (!char.IsDigit(symbol) && symbol != 8)
                e.Handled = true;
            if (e.KeyChar == 13)
                menuListLabel.Focus();
        }
        private void numberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (numberTextBox.Text != "")
                if (Convert.ToInt32(numberTextBox.Text) > 25)
                    numberTextBox.Text = "25";
        }
        private void numberTextBox_Leave(object sender, EventArgs e)
        {
            int index;
            try { index = Convert.ToInt32(numberTextBox.Text) - 1; }
            catch { return; }
            if (!CurrentMenu.Products[index].IsEmpty && index != CurrentProductIndex)
                MessageBox.Show("Внимание", $"Данный пункт меню уже занят ({CurrentMenu.Products[index].Name}). В случае сохранения старый продукт будет безвозвратно удален");
        }
        private void productListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productListComboBox.SelectedIndex != -1)
                ShowProduct(CurrentProductIndex);
        }

        private void addNewProductButton_Click(object sender, EventArgs e)
        {
            productListComboBox.SelectedIndex = -1;
            CreateProduct();
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            if (CurrentProduct == null)
            {
                MessageBox.Show("Выберите продукт, который хотите удалить, из списка");
                return;
            }
            if (MessageBox.Show("Вы уверены?", "Выбранный прoдукт будет безвозвратно удален", MessageBoxButtons.OKCancel) == DialogResult.OK)
                CurrentMenu.Remove(CurrentProduct);
            currentProductPanel.Visible = false;
            UpdateProductListComboBox();
        }

        private void editPhotoButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Файл \"JPG\" (*.jpg)|*.jpg|Файл \"PNG\" (*.png)|*.png";
                openFileDialog.ShowDialog();
                if (openFileDialog.FileName != "")
                    if (MessageBox.Show("Сохранить фотографию?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        CurrentProduct.Image = Image.FromFile(openFileDialog.FileName);
                        CurrentProduct.Color = Color.LightGray;
                    }
            }
            productImage.Image = CurrentProduct.Image;
            productImage.BackColor = CurrentProduct.Color;
        }

        private void editColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.ShowDialog();
                if (!colorDialog.Color.IsEmpty)
                    if (MessageBox.Show("Сохранить цвет?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        CurrentProduct.Image = null;
                        CurrentProduct.Color = colorDialog.Color;
                    }
            }
            productImage.Image = CurrentProduct.Image;
            productImage.BackColor = CurrentProduct.Color;
        }
    }
}
