
namespace s3_pr_cw
{
    partial class EditWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditWindow));
            this.doneButton = new System.Windows.Forms.Button();
            this.editCashboxButton = new System.Windows.Forms.Button();
            this.editEmployeeListButton = new System.Windows.Forms.Button();
            this.registrationRestaurantPanel = new System.Windows.Forms.Panel();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.restaurantAddressLabel = new System.Windows.Forms.Label();
            this.organizationTextBox = new System.Windows.Forms.TextBox();
            this.restaurantOrganizationLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.restaurantNameLabel = new System.Windows.Forms.Label();
            this.generalPanel = new System.Windows.Forms.Panel();
            this.editMenuButton = new System.Windows.Forms.Button();
            this.registrationRestaurantPanel.SuspendLayout();
            this.generalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // doneButton
            // 
            this.doneButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doneButton.BackColor = System.Drawing.Color.Gray;
            this.doneButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.doneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doneButton.Location = new System.Drawing.Point(12, 306);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(310, 65);
            this.doneButton.TabIndex = 7;
            this.doneButton.Text = "Готово";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // editCashboxButton
            // 
            this.editCashboxButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editCashboxButton.BackColor = System.Drawing.Color.Gray;
            this.editCashboxButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.editCashboxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCashboxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editCashboxButton.Location = new System.Drawing.Point(323, 306);
            this.editCashboxButton.Name = "editCashboxButton";
            this.editCashboxButton.Size = new System.Drawing.Size(310, 65);
            this.editCashboxButton.TabIndex = 6;
            this.editCashboxButton.Text = "Кассовый аппарат";
            this.editCashboxButton.UseVisualStyleBackColor = false;
            this.editCashboxButton.Click += new System.EventHandler(this.editCashboxListButton_Click);
            // 
            // editEmployeeListButton
            // 
            this.editEmployeeListButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editEmployeeListButton.BackColor = System.Drawing.Color.Gray;
            this.editEmployeeListButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.editEmployeeListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editEmployeeListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editEmployeeListButton.Location = new System.Drawing.Point(0, 228);
            this.editEmployeeListButton.Name = "editEmployeeListButton";
            this.editEmployeeListButton.Size = new System.Drawing.Size(310, 65);
            this.editEmployeeListButton.TabIndex = 5;
            this.editEmployeeListButton.Text = "Сотрудники";
            this.editEmployeeListButton.UseVisualStyleBackColor = false;
            this.editEmployeeListButton.Click += new System.EventHandler(this.editEmployeeListButton_Click);
            // 
            // registrationRestaurantPanel
            // 
            this.registrationRestaurantPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registrationRestaurantPanel.BackColor = System.Drawing.Color.Gray;
            this.registrationRestaurantPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registrationRestaurantPanel.Controls.Add(this.addressTextBox);
            this.registrationRestaurantPanel.Controls.Add(this.restaurantAddressLabel);
            this.registrationRestaurantPanel.Controls.Add(this.organizationTextBox);
            this.registrationRestaurantPanel.Controls.Add(this.restaurantOrganizationLabel);
            this.registrationRestaurantPanel.Controls.Add(this.nameTextBox);
            this.registrationRestaurantPanel.Controls.Add(this.restaurantNameLabel);
            this.registrationRestaurantPanel.Location = new System.Drawing.Point(0, 0);
            this.registrationRestaurantPanel.Name = "registrationRestaurantPanel";
            this.registrationRestaurantPanel.Size = new System.Drawing.Size(621, 227);
            this.registrationRestaurantPanel.TabIndex = 4;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTextBox.BackColor = System.Drawing.Color.LightGray;
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.addressTextBox.Location = new System.Drawing.Point(110, 180);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(399, 26);
            this.addressTextBox.TabIndex = 5;
            this.addressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addressTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditWindow_KeyPress);
            this.addressTextBox.Leave += new System.EventHandler(this.addressTextBox_Leave);
            // 
            // restaurantAddressLabel
            // 
            this.restaurantAddressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.restaurantAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restaurantAddressLabel.ForeColor = System.Drawing.Color.Black;
            this.restaurantAddressLabel.Location = new System.Drawing.Point(0, 150);
            this.restaurantAddressLabel.Name = "restaurantAddressLabel";
            this.restaurantAddressLabel.Size = new System.Drawing.Size(619, 30);
            this.restaurantAddressLabel.TabIndex = 4;
            this.restaurantAddressLabel.Text = "Адрес филиала";
            this.restaurantAddressLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // organizationTextBox
            // 
            this.organizationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.organizationTextBox.BackColor = System.Drawing.Color.LightGray;
            this.organizationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.organizationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.organizationTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.organizationTextBox.Location = new System.Drawing.Point(110, 110);
            this.organizationTextBox.Name = "organizationTextBox";
            this.organizationTextBox.Size = new System.Drawing.Size(399, 26);
            this.organizationTextBox.TabIndex = 3;
            this.organizationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.organizationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditWindow_KeyPress);
            this.organizationTextBox.Leave += new System.EventHandler(this.organizationTextBox_Leave);
            // 
            // restaurantOrganizationLabel
            // 
            this.restaurantOrganizationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.restaurantOrganizationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restaurantOrganizationLabel.ForeColor = System.Drawing.Color.Black;
            this.restaurantOrganizationLabel.Location = new System.Drawing.Point(0, 80);
            this.restaurantOrganizationLabel.Name = "restaurantOrganizationLabel";
            this.restaurantOrganizationLabel.Size = new System.Drawing.Size(619, 30);
            this.restaurantOrganizationLabel.TabIndex = 2;
            this.restaurantOrganizationLabel.Text = "Название заведующей компании";
            this.restaurantOrganizationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.BackColor = System.Drawing.Color.LightGray;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nameTextBox.Location = new System.Drawing.Point(110, 40);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(399, 26);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditWindow_KeyPress);
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_Leave);
            // 
            // restaurantNameLabel
            // 
            this.restaurantNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.restaurantNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restaurantNameLabel.ForeColor = System.Drawing.Color.Black;
            this.restaurantNameLabel.Location = new System.Drawing.Point(0, 10);
            this.restaurantNameLabel.Name = "restaurantNameLabel";
            this.restaurantNameLabel.Size = new System.Drawing.Size(619, 30);
            this.restaurantNameLabel.TabIndex = 0;
            this.restaurantNameLabel.Text = "Название ресторана";
            this.restaurantNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // generalPanel
            // 
            this.generalPanel.Controls.Add(this.editMenuButton);
            this.generalPanel.Controls.Add(this.registrationRestaurantPanel);
            this.generalPanel.Controls.Add(this.editEmployeeListButton);
            this.generalPanel.Location = new System.Drawing.Point(12, 12);
            this.generalPanel.Name = "generalPanel";
            this.generalPanel.Size = new System.Drawing.Size(621, 293);
            this.generalPanel.TabIndex = 8;
            // 
            // editMenuButton
            // 
            this.editMenuButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editMenuButton.BackColor = System.Drawing.Color.Gray;
            this.editMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.editMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editMenuButton.Location = new System.Drawing.Point(311, 228);
            this.editMenuButton.Name = "editMenuButton";
            this.editMenuButton.Size = new System.Drawing.Size(310, 65);
            this.editMenuButton.TabIndex = 7;
            this.editMenuButton.Text = "Меню";
            this.editMenuButton.UseVisualStyleBackColor = false;
            this.editMenuButton.Click += new System.EventHandler(this.editMenuButton_Click);
            // 
            // EditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 383);
            this.Controls.Add(this.generalPanel);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.editCashboxButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationWindow";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditWindow_KeyPress);
            this.registrationRestaurantPanel.ResumeLayout(false);
            this.registrationRestaurantPanel.PerformLayout();
            this.generalPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button editCashboxButton;
        private System.Windows.Forms.Button editEmployeeListButton;
        private System.Windows.Forms.Panel registrationRestaurantPanel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label restaurantAddressLabel;
        private System.Windows.Forms.TextBox organizationTextBox;
        private System.Windows.Forms.Label restaurantOrganizationLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label restaurantNameLabel;
        private System.Windows.Forms.Panel generalPanel;
        private System.Windows.Forms.Button editMenuButton;
    }
}