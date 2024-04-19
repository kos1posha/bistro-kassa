using System;
using System.Windows.Forms;

namespace s3_pr_cw
{
    public partial class SetMenuNameWindow : Form
    {
        Menu CurrentMenu = new Menu();

        public SetMenuNameWindow()
        {
            InitializeComponent();

            editMenuNameLabel.Text = "Создать раздел";
            saveButton.Text = "Создать";
        }
        public SetMenuNameWindow(Menu currentMenu)
        {
            InitializeComponent();

            CurrentMenu = currentMenu;
            editMenuNameTextBox.Text = currentMenu.Name;
        }

        new public static Menu Show()
        {
            SetMenuNameWindow editMenuNameWindow = new SetMenuNameWindow();
            editMenuNameWindow.ShowDialog();
            return editMenuNameWindow.CurrentMenu;
        }
        public static void Show(Menu menu)
        {
            SetMenuNameWindow editMenuNameWindow = new SetMenuNameWindow(menu);
            editMenuNameWindow.ShowDialog();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            CurrentMenu.Name = editMenuNameTextBox.Text.Trim();
            Dispose();
        }
        private void cancelButton_Click(object sender, EventArgs e)
            => Dispose();
    }
}
