using System;
using System.Windows.Forms;

namespace s3_pr_cw
{
    public partial class GetFundsWindow : Form
    {
        Order CurrentOrder;
        public int Funds
            => Convert.ToInt32(fundsTextBox.Text);

        public GetFundsWindow(Order order)
        {
            InitializeComponent();
            CurrentOrder = order;
            CurrentOrder.Payment = PaymentMethod.Cash;
        }

        public static DialogResult Show(Order order)
        {
            GetFundsWindow getFundsWindow = new GetFundsWindow(order);
            getFundsWindow.ShowDialog();
            return getFundsWindow.DialogResult;
        }

        private void cashButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                int value = Convert.ToInt32(button.Name.Substring(10));
                if (plusCheckBox.Checked)
                    fundsTextBox.Text = $"{Convert.ToInt32(fundsTextBox.Text) + value}";
                else
                    fundsTextBox.Text = value.ToString();
            }
        }
        private void exactAmountButton_Click(object sender, EventArgs e)
            => fundsTextBox.Text = CurrentOrder.Cost.ToString();
        private void clearButton_Click(object sender, EventArgs e)
            => fundsTextBox.Text = "0";
        private void doneButton_Click(object sender, EventArgs e)
        {
            if (Funds < CurrentOrder.Cost)
                MessageBox.Show("Недостаточно средств", $"Необходимо еще {CurrentOrder.Cost - Funds} рублей");
            else
            {
                CurrentOrder.СontributedFunds = Funds;
                DialogResult = DialogResult.OK;
                if (CurrentOrder.Change != 0)
                    MessageBox.Show($"Сдача: {CurrentOrder.Change} рублей");
                Dispose();
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            CurrentOrder.Payment = PaymentMethod.Noncash;
            Dispose();
        }

        private void fundsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;
            if (!Char.IsDigit(symbol) && symbol != 8)
                e.Handled = true;
        }
        private void fundsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (fundsTextBox.Text != "0")
                fundsTextBox.Text = fundsTextBox.Text.TrimStart('0');
            if (fundsTextBox.Text == "")
                fundsTextBox.Text = "0";
            if (Funds > 99999)
                fundsTextBox.Text = "99999";
        }
    }
}
