
namespace s3_pr_cw
{
    partial class EditEmployeeListWindow
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
            this.employeeListPanel = new System.Windows.Forms.Panel();
            this.cashierListLabel = new System.Windows.Forms.Label();
            this.cashierListComboBox = new System.Windows.Forms.ComboBox();
            this.adminListLabel = new System.Windows.Forms.Label();
            this.adminListComboBox = new System.Windows.Forms.ComboBox();
            this.employeeListLabel = new System.Windows.Forms.Label();
            this.deleteEmployeeButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.addNewEmployeeButton = new System.Windows.Forms.Button();
            this.saveEmployeeButton = new System.Windows.Forms.Button();
            this.employeeListComboBox = new System.Windows.Forms.ComboBox();
            this.editEmployeePanel = new System.Windows.Forms.Panel();
            this.currentEmployeeEmptyLabel2 = new System.Windows.Forms.Label();
            this.currentEmployeeEmptyLabel1 = new System.Windows.Forms.Label();
            this.currentEmployeePanel = new System.Windows.Forms.Panel();
            this.deletePhotoButton = new System.Windows.Forms.Button();
            this.editPhotoButton = new System.Windows.Forms.Button();
            this.employeePhoto = new System.Windows.Forms.PictureBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.thirthnameTextBox = new System.Windows.Forms.TextBox();
            this.thirthnameLabel = new System.Windows.Forms.Label();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.secondnameTextBox = new System.Windows.Forms.TextBox();
            this.secondnameLabel = new System.Windows.Forms.Label();
            this.employeeListPanel.SuspendLayout();
            this.editEmployeePanel.SuspendLayout();
            this.currentEmployeePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeListPanel
            // 
            this.employeeListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.employeeListPanel.BackColor = System.Drawing.Color.Gray;
            this.employeeListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeeListPanel.Controls.Add(this.cashierListLabel);
            this.employeeListPanel.Controls.Add(this.cashierListComboBox);
            this.employeeListPanel.Controls.Add(this.adminListLabel);
            this.employeeListPanel.Controls.Add(this.adminListComboBox);
            this.employeeListPanel.Controls.Add(this.employeeListLabel);
            this.employeeListPanel.Controls.Add(this.deleteEmployeeButton);
            this.employeeListPanel.Controls.Add(this.doneButton);
            this.employeeListPanel.Controls.Add(this.addNewEmployeeButton);
            this.employeeListPanel.Controls.Add(this.saveEmployeeButton);
            this.employeeListPanel.Controls.Add(this.employeeListComboBox);
            this.employeeListPanel.Location = new System.Drawing.Point(12, 12);
            this.employeeListPanel.Name = "employeeListPanel";
            this.employeeListPanel.Size = new System.Drawing.Size(304, 359);
            this.employeeListPanel.TabIndex = 0;
            // 
            // cashierListLabel
            // 
            this.cashierListLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cashierListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cashierListLabel.Location = new System.Drawing.Point(15, 127);
            this.cashierListLabel.Name = "cashierListLabel";
            this.cashierListLabel.Size = new System.Drawing.Size(276, 23);
            this.cashierListLabel.TabIndex = 9;
            this.cashierListLabel.Text = "Список кассиров";
            this.cashierListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cashierListComboBox
            // 
            this.cashierListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cashierListComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cashierListComboBox.FormattingEnabled = true;
            this.cashierListComboBox.Location = new System.Drawing.Point(15, 153);
            this.cashierListComboBox.Name = "cashierListComboBox";
            this.cashierListComboBox.Size = new System.Drawing.Size(276, 28);
            this.cashierListComboBox.TabIndex = 8;
            this.cashierListComboBox.SelectedIndexChanged += new System.EventHandler(this.cashierListComboBox_SelectedIndexChanged);
            // 
            // adminListLabel
            // 
            this.adminListLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminListLabel.Location = new System.Drawing.Point(15, 70);
            this.adminListLabel.Name = "adminListLabel";
            this.adminListLabel.Size = new System.Drawing.Size(276, 23);
            this.adminListLabel.TabIndex = 7;
            this.adminListLabel.Text = "Список администраторов";
            this.adminListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminListComboBox
            // 
            this.adminListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.adminListComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminListComboBox.FormattingEnabled = true;
            this.adminListComboBox.Location = new System.Drawing.Point(15, 96);
            this.adminListComboBox.Name = "adminListComboBox";
            this.adminListComboBox.Size = new System.Drawing.Size(276, 28);
            this.adminListComboBox.TabIndex = 6;
            this.adminListComboBox.SelectedIndexChanged += new System.EventHandler(this.adminListComboBox_SelectedIndexChanged);
            // 
            // employeeListLabel
            // 
            this.employeeListLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeListLabel.Location = new System.Drawing.Point(15, 13);
            this.employeeListLabel.Name = "employeeListLabel";
            this.employeeListLabel.Size = new System.Drawing.Size(276, 23);
            this.employeeListLabel.TabIndex = 5;
            this.employeeListLabel.Text = "Список сотрудников";
            this.employeeListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteEmployeeButton
            // 
            this.deleteEmployeeButton.BackColor = System.Drawing.Color.LightGray;
            this.deleteEmployeeButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.deleteEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteEmployeeButton.Location = new System.Drawing.Point(156, 234);
            this.deleteEmployeeButton.Name = "deleteEmployeeButton";
            this.deleteEmployeeButton.Size = new System.Drawing.Size(135, 53);
            this.deleteEmployeeButton.TabIndex = 4;
            this.deleteEmployeeButton.Text = "Удалить сотрудника";
            this.deleteEmployeeButton.UseVisualStyleBackColor = false;
            this.deleteEmployeeButton.Click += new System.EventHandler(this.deleteEmployeeButton_Click);
            // 
            // doneButton
            // 
            this.doneButton.BackColor = System.Drawing.Color.LightGray;
            this.doneButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.doneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doneButton.Location = new System.Drawing.Point(156, 293);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(135, 53);
            this.doneButton.TabIndex = 3;
            this.doneButton.Text = "Готово";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // addNewEmployeeButton
            // 
            this.addNewEmployeeButton.BackColor = System.Drawing.Color.LightGray;
            this.addNewEmployeeButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.addNewEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewEmployeeButton.Location = new System.Drawing.Point(15, 234);
            this.addNewEmployeeButton.Name = "addNewEmployeeButton";
            this.addNewEmployeeButton.Size = new System.Drawing.Size(135, 53);
            this.addNewEmployeeButton.TabIndex = 2;
            this.addNewEmployeeButton.Text = "Добавить сотрудника";
            this.addNewEmployeeButton.UseVisualStyleBackColor = false;
            this.addNewEmployeeButton.Click += new System.EventHandler(this.addNewEmployeeButton_Click);
            // 
            // saveEmployeeButton
            // 
            this.saveEmployeeButton.BackColor = System.Drawing.Color.LightGray;
            this.saveEmployeeButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.saveEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveEmployeeButton.Location = new System.Drawing.Point(15, 293);
            this.saveEmployeeButton.Name = "saveEmployeeButton";
            this.saveEmployeeButton.Size = new System.Drawing.Size(135, 53);
            this.saveEmployeeButton.TabIndex = 1;
            this.saveEmployeeButton.Text = "Сохранить";
            this.saveEmployeeButton.UseVisualStyleBackColor = false;
            this.saveEmployeeButton.Click += new System.EventHandler(this.saveEmployeeButton_Click);
            // 
            // employeeListComboBox
            // 
            this.employeeListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeListComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeListComboBox.FormattingEnabled = true;
            this.employeeListComboBox.Location = new System.Drawing.Point(15, 39);
            this.employeeListComboBox.Name = "employeeListComboBox";
            this.employeeListComboBox.Size = new System.Drawing.Size(276, 28);
            this.employeeListComboBox.TabIndex = 0;
            this.employeeListComboBox.SelectedIndexChanged += new System.EventHandler(this.employeeListComboBox_SelectedIndexChanged);
            // 
            // editEmployeePanel
            // 
            this.editEmployeePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editEmployeePanel.BackColor = System.Drawing.Color.Gray;
            this.editEmployeePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editEmployeePanel.Controls.Add(this.currentEmployeeEmptyLabel2);
            this.editEmployeePanel.Controls.Add(this.currentEmployeeEmptyLabel1);
            this.editEmployeePanel.Location = new System.Drawing.Point(329, 12);
            this.editEmployeePanel.Name = "editEmployeePanel";
            this.editEmployeePanel.Size = new System.Drawing.Size(304, 359);
            this.editEmployeePanel.TabIndex = 1;
            // 
            // currentEmployeeEmptyLabel2
            // 
            this.currentEmployeeEmptyLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentEmployeeEmptyLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentEmployeeEmptyLabel2.Location = new System.Drawing.Point(3, 170);
            this.currentEmployeeEmptyLabel2.Name = "currentEmployeeEmptyLabel2";
            this.currentEmployeeEmptyLabel2.Size = new System.Drawing.Size(296, 22);
            this.currentEmployeeEmptyLabel2.TabIndex = 1;
            this.currentEmployeeEmptyLabel2.Text = "из списка";
            this.currentEmployeeEmptyLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentEmployeeEmptyLabel1
            // 
            this.currentEmployeeEmptyLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentEmployeeEmptyLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentEmployeeEmptyLabel1.Location = new System.Drawing.Point(3, 146);
            this.currentEmployeeEmptyLabel1.Name = "currentEmployeeEmptyLabel1";
            this.currentEmployeeEmptyLabel1.Size = new System.Drawing.Size(296, 22);
            this.currentEmployeeEmptyLabel1.TabIndex = 0;
            this.currentEmployeeEmptyLabel1.Text = "Выберите сотрудника";
            this.currentEmployeeEmptyLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentEmployeePanel
            // 
            this.currentEmployeePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentEmployeePanel.BackColor = System.Drawing.Color.Gray;
            this.currentEmployeePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentEmployeePanel.Controls.Add(this.deletePhotoButton);
            this.currentEmployeePanel.Controls.Add(this.editPhotoButton);
            this.currentEmployeePanel.Controls.Add(this.employeePhoto);
            this.currentEmployeePanel.Controls.Add(this.typeComboBox);
            this.currentEmployeePanel.Controls.Add(this.typeLabel);
            this.currentEmployeePanel.Controls.Add(this.idTextBox);
            this.currentEmployeePanel.Controls.Add(this.idLabel);
            this.currentEmployeePanel.Controls.Add(this.thirthnameTextBox);
            this.currentEmployeePanel.Controls.Add(this.thirthnameLabel);
            this.currentEmployeePanel.Controls.Add(this.firstnameTextBox);
            this.currentEmployeePanel.Controls.Add(this.firstnameLabel);
            this.currentEmployeePanel.Controls.Add(this.secondnameTextBox);
            this.currentEmployeePanel.Controls.Add(this.secondnameLabel);
            this.currentEmployeePanel.Location = new System.Drawing.Point(329, 12);
            this.currentEmployeePanel.Name = "currentEmployeePanel";
            this.currentEmployeePanel.Size = new System.Drawing.Size(304, 359);
            this.currentEmployeePanel.TabIndex = 2;
            this.currentEmployeePanel.Visible = false;
            // 
            // deletePhotoButton
            // 
            this.deletePhotoButton.BackColor = System.Drawing.Color.LightGray;
            this.deletePhotoButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.deletePhotoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePhotoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deletePhotoButton.Location = new System.Drawing.Point(17, 98);
            this.deletePhotoButton.Name = "deletePhotoButton";
            this.deletePhotoButton.Size = new System.Drawing.Size(98, 53);
            this.deletePhotoButton.TabIndex = 20;
            this.deletePhotoButton.Text = "Удалить фото";
            this.deletePhotoButton.UseVisualStyleBackColor = false;
            this.deletePhotoButton.Click += new System.EventHandler(this.deletePhotoButton_Click);
            // 
            // editPhotoButton
            // 
            this.editPhotoButton.BackColor = System.Drawing.Color.LightGray;
            this.editPhotoButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.editPhotoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editPhotoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editPhotoButton.Location = new System.Drawing.Point(17, 39);
            this.editPhotoButton.Name = "editPhotoButton";
            this.editPhotoButton.Size = new System.Drawing.Size(98, 53);
            this.editPhotoButton.TabIndex = 19;
            this.editPhotoButton.Text = "Изменить фото";
            this.editPhotoButton.UseVisualStyleBackColor = false;
            this.editPhotoButton.Click += new System.EventHandler(this.employeePhoto_Edit);
            // 
            // employeePhoto
            // 
            this.employeePhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.employeePhoto.BackgroundImage = global::s3_pr_cw.Properties.Resources.NoAvatarImage;
            this.employeePhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.employeePhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeePhoto.ErrorImage = global::s3_pr_cw.Properties.Resources.NoAvatarImage;
            this.employeePhoto.InitialImage = global::s3_pr_cw.Properties.Resources.NoAvatarImage;
            this.employeePhoto.Location = new System.Drawing.Point(130, 17);
            this.employeePhoto.Name = "employeePhoto";
            this.employeePhoto.Size = new System.Drawing.Size(150, 151);
            this.employeePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.employeePhoto.TabIndex = 17;
            this.employeePhoto.TabStop = false;
            this.employeePhoto.DoubleClick += new System.EventHandler(this.employeePhoto_Edit);
            // 
            // typeComboBox
            // 
            this.typeComboBox.BackColor = System.Drawing.Color.LightGray;
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Кассир",
            "Администратор"});
            this.typeComboBox.Location = new System.Drawing.Point(107, 325);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(191, 21);
            this.typeComboBox.TabIndex = 16;
            // 
            // typeLabel
            // 
            this.typeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLabel.Location = new System.Drawing.Point(107, 304);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(192, 23);
            this.typeLabel.TabIndex = 15;
            this.typeLabel.Text = "Тип";
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idTextBox.BackColor = System.Drawing.Color.LightGray;
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idTextBox.Location = new System.Drawing.Point(7, 326);
            this.idTextBox.MaxLength = 6;
            this.idTextBox.Multiline = true;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(94, 20);
            this.idTextBox.TabIndex = 14;
            this.idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbs_KeyPress);
            // 
            // idLabel
            // 
            this.idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idLabel.Location = new System.Drawing.Point(3, 304);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(98, 23);
            this.idLabel.TabIndex = 13;
            this.idLabel.Text = "ID";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thirthnameTextBox
            // 
            this.thirthnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thirthnameTextBox.BackColor = System.Drawing.Color.LightGray;
            this.thirthnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thirthnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirthnameTextBox.Location = new System.Drawing.Point(7, 281);
            this.thirthnameTextBox.MaxLength = 26;
            this.thirthnameTextBox.Multiline = true;
            this.thirthnameTextBox.Name = "thirthnameTextBox";
            this.thirthnameTextBox.Size = new System.Drawing.Size(292, 20);
            this.thirthnameTextBox.TabIndex = 12;
            this.thirthnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.thirthnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_KeyPress);
            // 
            // thirthnameLabel
            // 
            this.thirthnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thirthnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirthnameLabel.Location = new System.Drawing.Point(3, 259);
            this.thirthnameLabel.Name = "thirthnameLabel";
            this.thirthnameLabel.Size = new System.Drawing.Size(296, 23);
            this.thirthnameLabel.TabIndex = 11;
            this.thirthnameLabel.Text = "Отчество";
            this.thirthnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstnameTextBox.BackColor = System.Drawing.Color.LightGray;
            this.firstnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstnameTextBox.Location = new System.Drawing.Point(7, 236);
            this.firstnameTextBox.MaxLength = 26;
            this.firstnameTextBox.Multiline = true;
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(292, 20);
            this.firstnameTextBox.TabIndex = 10;
            this.firstnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.firstnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_KeyPress);
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstnameLabel.Location = new System.Drawing.Point(3, 214);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(296, 23);
            this.firstnameLabel.TabIndex = 9;
            this.firstnameLabel.Text = "Имя";
            this.firstnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondnameTextBox
            // 
            this.secondnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secondnameTextBox.BackColor = System.Drawing.Color.LightGray;
            this.secondnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondnameTextBox.Location = new System.Drawing.Point(7, 191);
            this.secondnameTextBox.MaxLength = 26;
            this.secondnameTextBox.Multiline = true;
            this.secondnameTextBox.Name = "secondnameTextBox";
            this.secondnameTextBox.Size = new System.Drawing.Size(292, 20);
            this.secondnameTextBox.TabIndex = 8;
            this.secondnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.secondnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_KeyPress);
            // 
            // secondnameLabel
            // 
            this.secondnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secondnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondnameLabel.Location = new System.Drawing.Point(3, 169);
            this.secondnameLabel.Name = "secondnameLabel";
            this.secondnameLabel.Size = new System.Drawing.Size(296, 23);
            this.secondnameLabel.TabIndex = 7;
            this.secondnameLabel.Text = "Фамилия";
            this.secondnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditEmployeeListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 383);
            this.Controls.Add(this.currentEmployeePanel);
            this.Controls.Add(this.editEmployeePanel);
            this.Controls.Add(this.employeeListPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditEmployeeListWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditEmployeeListWindow";
            this.employeeListPanel.ResumeLayout(false);
            this.editEmployeePanel.ResumeLayout(false);
            this.currentEmployeePanel.ResumeLayout(false);
            this.currentEmployeePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeePhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel employeeListPanel;
        private System.Windows.Forms.Button deleteEmployeeButton;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button saveEmployeeButton;
        private System.Windows.Forms.ComboBox employeeListComboBox;
        private System.Windows.Forms.Panel editEmployeePanel;
        private System.Windows.Forms.Label employeeListLabel;
        private System.Windows.Forms.Label currentEmployeeEmptyLabel2;
        private System.Windows.Forms.Label currentEmployeeEmptyLabel1;
        private System.Windows.Forms.Panel currentEmployeePanel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox thirthnameTextBox;
        private System.Windows.Forms.Label thirthnameLabel;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.TextBox secondnameTextBox;
        private System.Windows.Forms.Label secondnameLabel;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.PictureBox employeePhoto;
        private System.Windows.Forms.Label cashierListLabel;
        private System.Windows.Forms.ComboBox cashierListComboBox;
        private System.Windows.Forms.Label adminListLabel;
        private System.Windows.Forms.ComboBox adminListComboBox;
        private System.Windows.Forms.Button addNewEmployeeButton;
        private System.Windows.Forms.Button deletePhotoButton;
        private System.Windows.Forms.Button editPhotoButton;
    }
}