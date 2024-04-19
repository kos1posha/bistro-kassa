using System;
using System.Windows.Forms;

namespace s3_pr_cw
{
    public partial class EditWindow : Form
    {
        Restaurant ThisRestaurant;
        bool ClearCurrentMenus = false;

        public EditWindow(Restaurant restaurant)
        {
            InitializeComponent();
            ThisRestaurant = restaurant;

            nameTextBox.Text = restaurant.Name;
            organizationTextBox.Text = restaurant.Organization;
            addressTextBox.Text = restaurant.Address;
        }

        public static bool Show(Restaurant restaurant)
        {
            EditWindow editWindow = new EditWindow(restaurant);
            editWindow.ShowDialog();
            return editWindow.ClearCurrentMenus;
        }

        private void editEmployeeListButton_Click(object sender, EventArgs e)
            => EditEmployeeListWindow.Show(ThisRestaurant.EmployeeList);
        private void editCashboxListButton_Click(object sender, EventArgs e)
            => EditCashboxWindow.Show(ThisRestaurant.EmployeeList, ThisRestaurant.ThisCashbox);
        private void editMenuButton_Click(object sender, EventArgs e)
            => ClearCurrentMenus = EditMenuWindow.Show(ThisRestaurant.MenuList);
        private void doneButton_Click(object sender, EventArgs e)
            => Dispose();


        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            if (ThisRestaurant.Name == nameTextBox.Text.Trim())
                return;
            if (MessageBox.Show("Подтвердите действие", "Сохранить новое наименование ресторана?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                ThisRestaurant.Name = nameTextBox.Text.Trim();
            else
                nameTextBox.Text = ThisRestaurant.Name;
        }
        private void organizationTextBox_Leave(object sender, EventArgs e)
        {
            if (ThisRestaurant.Organization == organizationTextBox.Text.Trim())
                return;
            if (MessageBox.Show("Подтвердите действие", "Сохранить новое наименование заведующей компании?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                ThisRestaurant.Organization = organizationTextBox.Text.Trim();
            else
                organizationTextBox.Text = ThisRestaurant.Organization;
        }
        private void addressTextBox_Leave(object sender, EventArgs e)
        {
            if (ThisRestaurant.Address == addressTextBox.Text.Trim())
                return;
            if (MessageBox.Show("Подтвердите действие", "Сохранить новый адрес ресторана?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                ThisRestaurant.Address = addressTextBox.Text.Trim();
            else
                addressTextBox.Text = ThisRestaurant.Address;
        }
        private void EditWindow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                restaurantAddressLabel.Focus();
        }
    }
}
