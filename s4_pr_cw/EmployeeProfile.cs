using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace s3_pr_cw
{
    public partial class EmployeeProfile : Form
    {
        Restaurant ThisRestaurant;
        Employee CurrentEmployee => ThisRestaurant.ThisCashbox.CurrentEmployee;
        bool ClearCurrentMenus = false;

        public EmployeeProfile(Restaurant restaurant, string startShift, string todayRevenue)
        {
            InitializeComponent();
            ThisRestaurant = restaurant;

            if (CurrentEmployee.Type != "Администратор")
                editRestaurantButton.Hide();

            UpdateEmployee();
            startShiftLabel.Text = $"Начало смены: {startShift}";
            todayRevenueLabel.Text = $"Выручка: {todayRevenue} руб";
        }

        public static bool Show(Restaurant restaurant, string startShift, decimal todayRevenue)
        {
            EmployeeProfile employeeProfile = new EmployeeProfile(restaurant, startShift, todayRevenue.ToString());
            employeeProfile.ShowDialog();
            return employeeProfile.ClearCurrentMenus;
        }
        void UpdateEmployee()
        {
            nameLabel.Text = $"ФИО: {CurrentEmployee.Name}";
            idLabel.Text = $"ID: {CurrentEmployee.Id}";
            typeLabel.Text = $"Тип: {CurrentEmployee.Type}";
            if (CurrentEmployee.Photo != null)
                employeePhoto.Image = CurrentEmployee.Photo;
        }

        private void endShiftButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Завершить смену", "Вы уверены?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                using (Stream stream = new FileStream("save.dat", FileMode.OpenOrCreate))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(stream, ThisRestaurant);
                }
                Environment.Exit(0);
            }
        }
        private void backButton_Click(object sender, EventArgs e)
            => Dispose();
        private void editRestaurantButton_Click(object sender, EventArgs e)
        {
            ClearCurrentMenus = EditWindow.Show(ThisRestaurant);
            UpdateEmployee();
        }
    }
}
