using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace s3_pr_cw
{
    public partial class EditCashboxWindow : Form
    {
        Cashbox ThisCashbox;

        public EditCashboxWindow(List<Employee> employeeList, Cashbox currentCashbox)
        {
            InitializeComponent();

            ThisCashbox = currentCashbox;

            foreach (Employee employee in employeeList)
            {
                currentEmployeeComboBox.Items.Add(employee);
                if (employee == ThisCashbox.CurrentEmployee)
                    currentEmployeeComboBox.SelectedItem = employee;
                kktTextBox.Text = ThisCashbox.KKT;
                kktLabel.Focus();
            }
        }

        public static void Show(List<Employee> employeeList, Cashbox currentCashbox)
        {
            EditCashboxWindow editCashboxWindow = new EditCashboxWindow(employeeList, currentCashbox);
            editCashboxWindow.ShowDialog();
        }

        private void doneButton_Click(object sender, EventArgs e)
            => Dispose();

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сохранить изменения?") == DialogResult.OK)
            {
                ThisCashbox.CurrentEmployee = (Employee)currentEmployeeComboBox.SelectedItem;
                ThisCashbox.KKT = kktTextBox.Text;
                Dispose();
            }
        }

        private void kktTextBox_Leave(object sender, EventArgs e)
        {
            if (kktTextBox.Text.Length != 16)
                MessageBox.Show("ККТ - 16 значный код. Его длина не может быть меньше");
        }

        private void kktTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;
            if (!char.IsDigit(symbol) && symbol != 8)
                e.Handled = true;
            if (e.KeyChar == 13)
                kktLabel.Focus();
        }
    }
}
