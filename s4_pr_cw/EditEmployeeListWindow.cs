using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace s3_pr_cw
{
    public partial class EditEmployeeListWindow : Form
    {
        List<Employee> EmployeeList;
        Employee CurrentEmployee
        {
            get
            {
                if (employeeListComboBox.SelectedItem is Employee employee1)
                    return employee1;
                if (adminListComboBox.SelectedItem is Employee employee2)
                    return employee2;
                if (cashierListComboBox.SelectedItem is Employee employee3)
                    return employee3;
                return new Employee();
            }
        }

        public EditEmployeeListWindow(List<Employee> employeeList)
        {
            InitializeComponent();
            EmployeeList = employeeList;

            UpdateEmployeeList();
        }

        public static void Show(List<Employee> employeeList)
        {
            EditEmployeeListWindow editEmployeeListWindow = new EditEmployeeListWindow(employeeList);
            editEmployeeListWindow.ShowDialog();
        }

        void UpdateEmployee(Employee employee)
        {
            if (employee == null)
                return;

            currentEmployeePanel.Visible = true;

            if (employee.Photo != null)
                employeePhoto.Image = employee.Photo;
            else
                employeePhoto.Image = Properties.Resources.NoAvatarImage;
            string[] names = employee.Name.Split(' ');
            try { secondnameTextBox.Text = names[0]; }
            catch { secondnameTextBox.Text = ""; }
            try { firstnameTextBox.Text = names[1]; }
            catch { firstnameTextBox.Text = ""; }
            try { thirthnameTextBox.Text = names[2]; }
            catch { thirthnameTextBox.Text = ""; }
            try { idTextBox.Text = employee.Id; }
            catch { idTextBox.Text = ""; }
            switch (employee.Type)
            {
                case "Кассир":
                    typeComboBox.SelectedIndex = 0;
                    break;
                case "Администратор":
                    typeComboBox.SelectedIndex = 1;
                    break;
                default:
                    typeComboBox.SelectedIndex = -1;
                    break;
            }
        }
        void UpdateEmployee(Employee employee, bool clearComboBoxes)
        {
            if (clearComboBoxes)
            {
                employeeListComboBox.SelectedIndex = -1;
                adminListComboBox.SelectedIndex = -1;
                cashierListComboBox.SelectedIndex = -1;
            }
            UpdateEmployee(employee);
        }
        void UpdateEmployeeList()
        {
            employeeListComboBox.Items.Clear();
            adminListComboBox.Items.Clear();
            cashierListComboBox.Items.Clear();

            foreach (Employee employee in EmployeeList)
            {
                employeeListComboBox.Items.Add(employee);
                if (employee.Type == "Администратор")
                    adminListComboBox.Items.Add(employee);
                else
                    cashierListComboBox.Items.Add(employee);
            }
        }
        void UpdateComboBox(ComboBox comboBox)
        {
            if (!comboBox.Focused)
                comboBox.SelectedIndex = -1;
        }

        private void addNewEmployeeButton_Click(object sender, EventArgs e)
        {
            UpdateEmployee(new Employee(), true);
        }
        private void deleteEmployeeButton_Click(object sender, EventArgs e)
        {
            if (CurrentEmployee == BistroKassa.ThisCashbox.CurrentEmployee)
            {
                MessageBox.Show("Невозможно удалить текущего сотрудника");
                return;
            }
            if (MessageBox.Show("Вы уверены?", "Выбранный сотрудник будет безвозвратно удален", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;

            foreach (Employee employee in EmployeeList)
                if (employee.Equals(CurrentEmployee))
                {
                    EmployeeList.Remove(employee);
                    break;
                }
            UpdateEmployee(new Employee(), true);
            UpdateEmployeeList();
        }
        private void saveEmployeeButton_Click(object sender, EventArgs e)
        {
            if (!currentEmployeePanel.Visible)
                return;
            string message = string.Empty;
            if (secondnameTextBox.Text.Trim() == "")
                message += " фамилия,";
            if (firstnameTextBox.Text.Trim() == "")
                message += " имя,";
            if (thirthnameTextBox.Text.Trim() == "")
                message += " отчество,";
            if (idTextBox.Text.Trim() == "")
                message += " идентификационный номер,";
            if (typeComboBox.SelectedIndex == -1)
                message += " тип,";
            if (message != string.Empty)
            {
                MessageBox.Show($"Не указано:{message.Remove(message.Length - 1)} сотрудника");
                return;
            }
            foreach (Employee employee in EmployeeList)
                if (employee.Id == idTextBox.Text.Trim() && employee != CurrentEmployee)
                {
                    MessageBox.Show("Данный идентификационный номер уже используется другим сотрудником");
                    return;
                }

            if (employeeListComboBox.SelectedIndex == -1 && adminListComboBox.SelectedIndex == -1 && cashierListComboBox.SelectedIndex == -1)
            {
                if (MessageBox.Show("Добавить нового сотрудника?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    EmployeeList.Add(new Employee($"{secondnameTextBox.Text} {firstnameTextBox.Text} {thirthnameTextBox.Text}", (string)typeComboBox.SelectedItem, idTextBox.Text));
                else
                    return;
            }
            else
            {
                if (MessageBox.Show("Сохранить изменения?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (employeePhoto.Image != Properties.Resources.NoAvatarImage)
                        CurrentEmployee.Photo = (Bitmap)employeePhoto.Image;
                    CurrentEmployee.Name = $"{secondnameTextBox.Text} {firstnameTextBox.Text} {thirthnameTextBox.Text}";
                    CurrentEmployee.Type = (string)typeComboBox.SelectedItem;
                    CurrentEmployee.Id = idTextBox.Text;
                }
                else
                    return;
            }
            currentEmployeePanel.Visible = false;
            UpdateEmployeeList();
        }
        private void doneButton_Click(object sender, EventArgs e)
            => Dispose();

        private void employeePhoto_Edit(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Файл \"JPG\" (*.jpg)|*.jpg|Файл \"PNG\" (*.png)|*.png";
                openFileDialog.ShowDialog();
                if (openFileDialog.FileName != "")
                    if (MessageBox.Show("Сохранить фотографию?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        CurrentEmployee.Photo = Image.FromFile(openFileDialog.FileName);
            }
            employeePhoto.Image = CurrentEmployee.Photo;
        }
        private void deletePhotoButton_Click(object sender, EventArgs e)
        {
            CurrentEmployee.Photo = null;
            UpdateEmployee(CurrentEmployee);
        }

        private void employeeListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComboBox(adminListComboBox);
            UpdateComboBox(cashierListComboBox);
            UpdateEmployee((Employee)employeeListComboBox.SelectedItem);
        }
        private void adminListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComboBox(employeeListComboBox);
            UpdateComboBox(cashierListComboBox);
            UpdateEmployee((Employee)adminListComboBox.SelectedItem);
        }
        private void cashierListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComboBox(employeeListComboBox);
            UpdateComboBox(adminListComboBox);
            UpdateEmployee((Employee)cashierListComboBox.SelectedItem);
        }

        private void enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                adminListLabel.Focus();
        }
        private void onlyNumbs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                employeeListLabel.Focus();
            char symbol = e.KeyChar;
            if (!Char.IsDigit(symbol) && symbol != 8)
                e.Handled = true;
        }
    }
}
