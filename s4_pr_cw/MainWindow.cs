using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace s3_pr_cw
{
    public partial class BistroKassa : Form
    {
        public static Restaurant ThisRestaurant;
        public static Cashbox ThisCashbox => ThisRestaurant.ThisCashbox;

        decimal TodayRevenue
        {
            get
            {
                decimal value = 0m;
                foreach (Order order in OrdersList)
                    if (order.Status == OrderStatus.Done)
                        value += order.Cost;
                return value;
            }
        }
        string CurrentTime => $"{DateTime.Now.Hour}:".PadLeft(3, '0') + $"{DateTime.Now.Minute}:".PadLeft(3, '0') + $"{DateTime.Now.Second}".PadLeft(2, '0');
        string CurrentDate => $"{DateTime.Now.Day}.".PadLeft(3, '0') + $"{DateTime.Now.Month}.".PadLeft(3, '0') + $"{DateTime.Now.Year}";
        string StartShift;

        List<Order> OrdersList = new List<Order>();
        List<Menu> MenusList => ThisRestaurant.MenuList;

        public BistroKassa()
        {
            InitializeComponent();
            Initial();
            UpdateMenuList();

            StartShift = $"{CurrentTime}, {CurrentDate}";
        }

        public BistroKassa(Restaurant restaurant)
        {
            InitializeComponent();
            Initial(restaurant);
            UpdateMenuList();

            StartShift = $"{CurrentTime}, {CurrentDate}";
            timeLabel.Text = $"{CurrentTime}  {CurrentDate}";
            employeeNameLabel.Text = ThisCashbox.CurrentEmployee.Name;
            employeeTypeLabel.Text = ThisCashbox.CurrentEmployee.Type;
        }

        void UpdateMenuList()
        {
            menuComboBox1.Items.Clear();
            menuComboBox2.Items.Clear();

            foreach (Menu menu in MenusList)
            {
                menuComboBox1.Items.Add(menu);
                menuComboBox2.Items.Add(menu);
            }
        }
        void Initial()
            => Initial(new Restaurant("И рыба, и мясо", "OOO \"ИРИМис\"", "70000, г.Краснодар, ул.Тюляева, д.25",
                new List<Menu>()
            {
                    new Menu("Бургеры", new Dictionary<int, Product>()
                    {
                        { 0, new Product("Большой бургер", 220, 159) },
                        { 1, new Product("Средний бургер", 160, 119) },
                        { 2, new Product("Маленький бургер", 110, 89) },
                        { 24, new Product("Особый бургер", 350, 229) }
                    }),
                    new Menu("Закуски", new Dictionary<int, Product>()
                    {
                        { 0, new Product("Картошка фри", 75, 89)},
                        { 1, new Product("Картошка по-деревенски", 85, 89)},
                        { 2, new Product("Чипсы Lays", 130, 159)},
                        { 3, new Product("Сырные палочки", 75, 119)},
                        { 15, new Product("Нагетсы большие", 120, 139)},
                        { 16, new Product("Нагетсы маленькие", 75, 119)}
                    }),
                    new Menu("Напитки", new Dictionary<int, Product>()
                    {
                        { 0, new Product("Кола маленькая", 330, 89)},
                        { 1, new Product("Кола большая", 600, 119)},
                        { 5, new Product("Спрайт маленький", 330, 89)},
                        { 6, new Product("Спрайт большой", 600, 119)},
                        { 10, new Product("Фанта маленькая", 330, 89)},
                        { 11, new Product("Фанта большая", 600, 119)},
                        { 20, new Product("Чай черный", 130, 69)},
                        { 21, new Product("Чай черный", 130, 69)},
                        { 22, new Product("Кофе черный", 90, 89)}
                    }),
                    new Menu("Соусы", new Dictionary<int, Product>()
                    {
                        { 0, new Product("Сырный соус", 60, 40)},
                        { 1, new Product("Кетчуп", 60, 40)},
                        { 2, new Product("Чилли соус", 60, 40)},
                        { 3, new Product("1000 островов", 60, 40)},
                        { 4, new Product("Тар-тар", 60, 40)}
                    }),
            },
                new Cashbox("1000000000000016"),
                new List<Employee>()
                {
                    new Employee("Цой Ирина Евгеньевна", "Администратор", "107110"),
                    new Employee("Альбертов Михаил Мальбертович", "Кассир", "821900")
                }));
        void Initial(Restaurant restaurant)
        {
            ThisRestaurant = restaurant;
            ThisCashbox.CurrentEmployee = ThisRestaurant.EmployeeList[0];
        }

        #region createOrderPage

        int CurrentIndexCOP => currentOrderList.SelectedIndex;
        Product CurrentProductCOP => (Product)currentOrderList.SelectedItem;
        Order CurrentOrderCOP = new Order();
        Menu[] CurrentMenus = new Menu[2];

        private void button_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
                AddToCurrentOrder(CurrentMenus[Convert.ToInt32(button.Tag.ToString().Substring(0, 1))].Products[Convert.ToInt32(button.Tag.ToString().Substring(1, 2))]);
        }
        private void clearCurrentOrderButton_Click(object sender, EventArgs e)
            => ClearCurrentOrder();
        private void seeOrdersList_Click(object sender, EventArgs e)
        {
            if (OrdersList.Count == 0)
                MessageBox.Show("Список заказов пуст");
            else
                tabControl.SelectedIndex = 1;
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (CurrentIndexCOP != -1)
                DeleteCurrentProduct();
        }
        private void addOrderButton_Click(object sender, EventArgs e)
        {
            if (CurrentOrderCOP.Products.Count == 0)
            {
                MessageBox.Show("Заказ пуст");
                return;
            }
            if (cashRadioButton.Checked)
            {
                if (GetFundsWindow.Show(CurrentOrderCOP) == DialogResult.OK)
                    CurrentOrderCOP.Payment = PaymentMethod.Cash;
                else
                {
                    CurrentOrderCOP.Payment = PaymentMethod.Noncash;
                    return;
                }
            }
            else if (noncashRadioButton.Checked)
            {
                if (MessageBox.Show("Ожидание оплаты", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    CurrentOrderCOP.СontributedFunds = CurrentOrderCOP.Cost;
                else
                    return;
            }
            else
            {
                MessageBox.Show("Внимание", "Не указан способ оплаты");
                return;
            }

            if (ordersNoteTextBox1.ForeColor != Color.DimGray)
                CurrentOrderCOP.Note = ordersNoteTextBox1.Text;
            CurrentOrderCOP.Time = $"{CurrentTime}, {CurrentDate}";
            OrdersList.Add(CurrentOrderCOP);

            CurrentOrderCOP.PrintCheque();
            foreach (Menu menu in MenusList)
                menu.CountToOne();
            ClearCurrentOrder();

        }
        private void plusNapkinsButton_Click(object sender, EventArgs e)
        {
            if (CurrentOrderCOP.NapkinsCount != 99)
                napkinsCountLabel.Text = (++CurrentOrderCOP.NapkinsCount).ToString();
            totalCostLabel.Text = $"{CurrentOrderCOP.Cost} руб";
        }
        private void minusNupkinsButton_Click(object sender, EventArgs e)
        {
            if (CurrentOrderCOP.NapkinsCount != 0)
                napkinsCountLabel.Text = (--CurrentOrderCOP.NapkinsCount).ToString();
            totalCostLabel.Text = $"{CurrentOrderCOP.Cost} руб";
        }
        private void orderTypeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (orderTypeCheckBox.Checked)
                CurrentOrderCOP.Issue = true;
            else
                CurrentOrderCOP.Issue = false;
        }

        void UpdateCurrentMenu()
        {
            UpdateCurrentMenu(1, new Menu());
            UpdateCurrentMenu(2, new Menu());
        }
        void UpdateCurrentMenu(int number, Menu menu)
        {
            CurrentMenus[number - 1] = menu;
            switch (number)
            {
                case 1:
                    UpdateButton(button100, menu.Products[0]);
                    UpdateButton(button101, menu.Products[1]);
                    UpdateButton(button102, menu.Products[2]);
                    UpdateButton(button103, menu.Products[3]);
                    UpdateButton(button104, menu.Products[4]);
                    UpdateButton(button105, menu.Products[5]);
                    UpdateButton(button106, menu.Products[6]);
                    UpdateButton(button107, menu.Products[7]);
                    UpdateButton(button108, menu.Products[8]);
                    UpdateButton(button109, menu.Products[9]);
                    UpdateButton(button110, menu.Products[10]);
                    UpdateButton(button111, menu.Products[11]);
                    UpdateButton(button112, menu.Products[12]);
                    UpdateButton(button113, menu.Products[13]);
                    UpdateButton(button114, menu.Products[14]);
                    UpdateButton(button115, menu.Products[15]);
                    UpdateButton(button116, menu.Products[16]);
                    UpdateButton(button117, menu.Products[17]);
                    UpdateButton(button118, menu.Products[18]);
                    UpdateButton(button119, menu.Products[19]);
                    UpdateButton(button120, menu.Products[20]);
                    UpdateButton(button121, menu.Products[21]);
                    UpdateButton(button122, menu.Products[22]);
                    UpdateButton(button123, menu.Products[23]);
                    UpdateButton(button124, menu.Products[24]);
                    break;
                case 2:
                    UpdateButton(button200, menu.Products[0]);
                    UpdateButton(button201, menu.Products[1]);
                    UpdateButton(button202, menu.Products[2]);
                    UpdateButton(button203, menu.Products[3]);
                    UpdateButton(button204, menu.Products[4]);
                    UpdateButton(button205, menu.Products[5]);
                    UpdateButton(button206, menu.Products[6]);
                    UpdateButton(button207, menu.Products[7]);
                    UpdateButton(button208, menu.Products[8]);
                    UpdateButton(button209, menu.Products[9]);
                    UpdateButton(button210, menu.Products[10]);
                    UpdateButton(button211, menu.Products[11]);
                    UpdateButton(button212, menu.Products[12]);
                    UpdateButton(button213, menu.Products[13]);
                    UpdateButton(button214, menu.Products[14]);
                    UpdateButton(button215, menu.Products[15]);
                    UpdateButton(button216, menu.Products[16]);
                    UpdateButton(button217, menu.Products[17]);
                    UpdateButton(button218, menu.Products[18]);
                    UpdateButton(button219, menu.Products[19]);
                    UpdateButton(button220, menu.Products[20]);
                    UpdateButton(button221, menu.Products[21]);
                    UpdateButton(button222, menu.Products[22]);
                    UpdateButton(button223, menu.Products[23]);
                    UpdateButton(button224, menu.Products[24]);
                    break;
            }
        }
        void UpdateButton(Button button, Product product)
        {
            button.Text = product.Name;
            button.Image = product.Image;
            button.BackColor = product.Color;
            if (product.IsEmpty)
                button.Hide();
            else
                button.Show();
        }
        void AddToCurrentOrder(Product product)
        {
            if (product.IsEmpty) return;
            if (CurrentOrderCOP.Add(product))
                currentOrderList.Items.Add(product);
            currentOrderList.Enabled = false;
            currentOrderList.Enabled = true;
            totalCostLabel.Text = $"{CurrentOrderCOP.Cost} руб";
        }
        void ClearCurrentOrder()
        {
            CountToOne();
            CurrentOrderCOP = new Order();
            currentOrderList.Items.Clear();
            cashRadioButton.Checked = false;
            noncashRadioButton.Checked = false;
            orderTypeCheckBox.Checked = false;
            ordersNoteTextBox1.Text = "Примечание";
            ordersNoteTextBox1.ForeColor = Color.DimGray;
            napkinsCountLabel.Text = "0";
            totalCostLabel.Text = "0 руб";
        }
        void DeleteCurrentProduct()
        {
            CurrentProductCOP.CountInOrder = 1;
            CurrentOrderCOP.Products.Remove(CurrentProductCOP);
            currentOrderList.Items.RemoveAt(CurrentIndexCOP);
            totalCostLabel.Text = $"{CurrentOrderCOP.Cost} руб";
        }
        void CountToOne()
        {
            foreach (Product product in currentOrderList.Items)
                product.CountInOrder = 1;
        }

        private void menuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox menuComboBox)
                foreach (Menu menu in MenusList)
                    if (menuComboBox.SelectedItem == menu)
                        UpdateCurrentMenu(Convert.ToInt32(menuComboBox.Name[12].ToString()), menu);
        }
        private void ordersNoteTextBox1_TextChanged(object sender, EventArgs e)
            => ordersNoteTextBox1.ForeColor = Color.Black;
        private void ordersNoteTextBox1_Enter(object sender, EventArgs e)
        {
            if (ordersNoteTextBox1.Text == "Примечание")
                ordersNoteTextBox1.Text = string.Empty;
        }
        private void ordersNoteTextBox1_Leave(object sender, EventArgs e)
        {
            if (ordersNoteTextBox1.Text == string.Empty)
            {
                ordersNoteTextBox1.Text = "Примечание";
                ordersNoteTextBox1.ForeColor = Color.DimGray;
            }
        }

        #endregion

        #region seeOrdersList

        int CurrentIndexSOL;
        Order CurrentOrderSOL
           => OrdersList[CurrentIndexSOL];

        private void nextOrderButton_Click(object sender, EventArgs e)
        {
            if (CurrentIndexSOL == OrdersList.Count - 1)
                return;
            else
            {
                CurrentIndexSOL++;
                ShowOrder();
            }
        }
        private void previousOrderButton_Click(object sender, EventArgs e)
        {
            if (CurrentIndexSOL == 0)
                return;
            else
            {
                CurrentIndexSOL--;
                ShowOrder();
            }
        }
        private void closeOrdersWindowButton_Click(object sender, EventArgs e)
            => tabControl.SelectedTab = tabControl.TabPages[0];
        private void cancelOrderButtom_Click(object sender, EventArgs e)
        {

            switch (CurrentOrderSOL.Status)
            {
                case OrderStatus.Delete:
                    MessageBox.Show("Это заказ уже удален");
                    return;
                case OrderStatus.Cancelled:
                    MessageBox.Show("Это заказ уже отменен");
                    return;
            }
            DialogResult dialogResult = MessageBox.Show("Вы уверены?", $"Статус заказа №{CurrentOrderSOL.Number} будет изменен на \"Отменен\" или \"Удален\" в зависимости от текущего статуса заказа.", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
                switch (CurrentOrderSOL.Status)
                {
                    case OrderStatus.Done:
                        CurrentOrderSOL.Status = OrderStatus.Delete;
                        break;
                    case OrderStatus.Preparing:
                        CurrentOrderSOL.Status = OrderStatus.Cancelled;
                        break;
                }
            ShowOrder();
        }
        private void giveAnOrderButton_Click(object sender, EventArgs e)
        {
            switch (CurrentOrderSOL.Status)
            {
                case OrderStatus.Preparing:
                    CurrentOrderSOL.EndTime = $"{CurrentTime}, {CurrentDate}";
                    CurrentOrderSOL.Status = OrderStatus.Done;
                    break;
                case OrderStatus.Done:
                    MessageBox.Show("Заказ уже отдан");
                    break;
                case OrderStatus.Cancelled:
                    MessageBox.Show("Заказ отменен", "Отменненый заказ нельзя отдать.");
                    break;
                case OrderStatus.Delete:
                    MessageBox.Show("Заказ удален", "Удаленный заказ нельзя отдать.");
                    break;
            }
            ShowOrder();
        }
        private void printChequeButton_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show($"Распечатать чек для заказа №{CurrentOrderSOL.Number}?", "Если в каталоге уже существует заказ с подобным номером, он будет перезаписан.", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
                CurrentOrderSOL.PrintCheque();
        }

        private void ShowOrder()
        {
            productsList.Items.Clear();
            ordersTime.Text = $"Время заказа: {CurrentOrderSOL.Time}";
            ordersEndTime.Text = $"Время выдачи: {CurrentOrderSOL.EndTime}";
            ordersNapkinsCount.Text = $"Салфетки: {CurrentOrderSOL.GetNapkinsCount()}";
            ordersIssue.Text = $"Выдача: {CurrentOrderSOL.GetIssue()}";
            ordersStatus.Text = $"Статус: {CurrentOrderSOL.GetStatus()}";
            ordersPaymentMethod.Text = $"Способ оплаты: {CurrentOrderSOL.GetPaymentMethod()}";
            ordersCost.Text = $"Итоговая цена: {CurrentOrderSOL.Cost} руб";
            ordersNoteTextBox2.Text = CurrentOrderSOL.Note;
            ordersNumber.Text = $"Заказ №{CurrentOrderSOL.Number}";
            foreach (Product product in CurrentOrderSOL.Products.Keys)
            {
                product.CountInOrder = CurrentOrderSOL.Products[product];
                productsList.Items.Add(product);
            }
            productsList.Update();
        }
        #endregion


        private void infoButton_Click(object sender, EventArgs e)
        {
            if (EmployeeProfile.Show(ThisRestaurant, StartShift, TodayRevenue))
            {
                UpdateCurrentMenu();
                UpdateMenuList();
            }
        }
        private void list_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (sender is ListBox listBox)
                if (listBox.Items.Count > 0)
                {
                    e.DrawBackground();
                    e.DrawFocusRectangle();
                    e.Graphics.DrawString(listBox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
                }
        }
        private void list_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (sender is ListBox listBox)
                e.ItemHeight = (int)e.Graphics.MeasureString(listBox.Items[e.Index].ToString(), listBox.Font, listBox.Width).Height;
        }
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    return;
                case 1:
                    CurrentIndexSOL = OrdersList.Count - 1;
                    ShowOrder();
                    return;
            }
        }
        private void infoButton_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath buttonPath = new GraphicsPath();
            Rectangle newRectangle = infoButton.ClientRectangle;
            newRectangle.Inflate(-5, -5);
            e.Graphics.DrawEllipse(Pens.DarkGray, newRectangle);
            newRectangle.Inflate(1, 1);
            buttonPath.AddEllipse(newRectangle);
            infoButton.Region = new Region(buttonPath);
        }
        private void time_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = $"{CurrentTime}  {CurrentDate}";
            employeeNameLabel.Text = ThisCashbox.CurrentEmployee.Name;
            employeeTypeLabel.Text = ThisCashbox.CurrentEmployee.Type;
        }
        private void BistroKassa_Load(object sender, EventArgs e)
        {
            timeLabel.Text = $"{CurrentTime}  {CurrentDate}";
            employeeNameLabel.Text = ThisCashbox.CurrentEmployee.Name;
            employeeTypeLabel.Text = ThisCashbox.CurrentEmployee.Type;
        }
    }
}
