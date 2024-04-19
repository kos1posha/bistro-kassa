
namespace s3_pr_cw
{
    partial class EditMenuWindow
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
            this.currentProductPanel = new System.Windows.Forms.Panel();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.editColorButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editPhotoButton = new System.Windows.Forms.Button();
            this.productImage = new System.Windows.Forms.PictureBox();
            this.vaxTextBox = new System.Windows.Forms.TextBox();
            this.vaxLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.editProductPanel = new System.Windows.Forms.Panel();
            this.currentProductEmptyLabel2 = new System.Windows.Forms.Label();
            this.currentProductEmptyLabel1 = new System.Windows.Forms.Label();
            this.menuAndProductListsPanel = new System.Windows.Forms.Panel();
            this.editMenuNameButton = new System.Windows.Forms.Button();
            this.deleteMenuButton = new System.Windows.Forms.Button();
            this.addNewMenuButton = new System.Windows.Forms.Button();
            this.productListLabel = new System.Windows.Forms.Label();
            this.productListComboBox = new System.Windows.Forms.ComboBox();
            this.menuListLabel = new System.Windows.Forms.Label();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.addNewProductButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.menuListComboBox = new System.Windows.Forms.ComboBox();
            this.currentProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).BeginInit();
            this.editProductPanel.SuspendLayout();
            this.menuAndProductListsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentProductPanel
            // 
            this.currentProductPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentProductPanel.BackColor = System.Drawing.Color.Gray;
            this.currentProductPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentProductPanel.Controls.Add(this.numberTextBox);
            this.currentProductPanel.Controls.Add(this.numberLabel);
            this.currentProductPanel.Controls.Add(this.editColorButton);
            this.currentProductPanel.Controls.Add(this.deleteButton);
            this.currentProductPanel.Controls.Add(this.editPhotoButton);
            this.currentProductPanel.Controls.Add(this.productImage);
            this.currentProductPanel.Controls.Add(this.vaxTextBox);
            this.currentProductPanel.Controls.Add(this.vaxLabel);
            this.currentProductPanel.Controls.Add(this.priceTextBox);
            this.currentProductPanel.Controls.Add(this.priceLabel);
            this.currentProductPanel.Controls.Add(this.weightTextBox);
            this.currentProductPanel.Controls.Add(this.weightLabel);
            this.currentProductPanel.Controls.Add(this.nameTextBox);
            this.currentProductPanel.Controls.Add(this.nameLabel);
            this.currentProductPanel.Location = new System.Drawing.Point(329, 12);
            this.currentProductPanel.Name = "currentProductPanel";
            this.currentProductPanel.Size = new System.Drawing.Size(304, 359);
            this.currentProductPanel.TabIndex = 5;
            this.currentProductPanel.Visible = false;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numberTextBox.BackColor = System.Drawing.Color.LightGray;
            this.numberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberTextBox.Location = new System.Drawing.Point(209, 320);
            this.numberTextBox.MaxLength = 2;
            this.numberTextBox.Multiline = true;
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(90, 26);
            this.numberTextBox.TabIndex = 23;
            this.numberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberTextBox.TextChanged += new System.EventHandler(this.numberTextBox_TextChanged);
            this.numberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumb_KeyPress);
            this.numberTextBox.Leave += new System.EventHandler(this.numberTextBox_Leave);
            // 
            // numberLabel
            // 
            this.numberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLabel.Location = new System.Drawing.Point(7, 319);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(196, 27);
            this.numberLabel.TabIndex = 22;
            this.numberLabel.Text = "Номер в меню (1 - 25)";
            this.numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editColorButton
            // 
            this.editColorButton.BackColor = System.Drawing.Color.LightGray;
            this.editColorButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.editColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editColorButton.Location = new System.Drawing.Point(20, 70);
            this.editColorButton.Name = "editColorButton";
            this.editColorButton.Size = new System.Drawing.Size(98, 45);
            this.editColorButton.TabIndex = 21;
            this.editColorButton.Text = "Задать цвет";
            this.editColorButton.UseVisualStyleBackColor = false;
            this.editColorButton.Click += new System.EventHandler(this.editColorButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.LightGray;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(20, 123);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(98, 45);
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // editPhotoButton
            // 
            this.editPhotoButton.BackColor = System.Drawing.Color.LightGray;
            this.editPhotoButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.editPhotoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editPhotoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editPhotoButton.Location = new System.Drawing.Point(20, 17);
            this.editPhotoButton.Name = "editPhotoButton";
            this.editPhotoButton.Size = new System.Drawing.Size(98, 45);
            this.editPhotoButton.TabIndex = 19;
            this.editPhotoButton.Text = "Изменить фото";
            this.editPhotoButton.UseVisualStyleBackColor = false;
            this.editPhotoButton.Click += new System.EventHandler(this.editPhotoButton_Click);
            // 
            // productImage
            // 
            this.productImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productImage.BackColor = System.Drawing.Color.LightGray;
            this.productImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.productImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productImage.ErrorImage = null;
            this.productImage.InitialImage = null;
            this.productImage.Location = new System.Drawing.Point(130, 17);
            this.productImage.Name = "productImage";
            this.productImage.Size = new System.Drawing.Size(150, 151);
            this.productImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productImage.TabIndex = 17;
            this.productImage.TabStop = false;
            // 
            // vaxTextBox
            // 
            this.vaxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vaxTextBox.BackColor = System.Drawing.Color.LightGray;
            this.vaxTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vaxTextBox.Location = new System.Drawing.Point(209, 287);
            this.vaxTextBox.MaxLength = 2;
            this.vaxTextBox.Multiline = true;
            this.vaxTextBox.Name = "vaxTextBox";
            this.vaxTextBox.Size = new System.Drawing.Size(90, 20);
            this.vaxTextBox.TabIndex = 14;
            this.vaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vaxLabel
            // 
            this.vaxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vaxLabel.Location = new System.Drawing.Point(209, 265);
            this.vaxLabel.Name = "vaxLabel";
            this.vaxLabel.Size = new System.Drawing.Size(90, 23);
            this.vaxLabel.TabIndex = 13;
            this.vaxLabel.Text = "НДС (%)";
            this.vaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceTextBox.BackColor = System.Drawing.Color.LightGray;
            this.priceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTextBox.Location = new System.Drawing.Point(7, 287);
            this.priceTextBox.MaxLength = 26;
            this.priceTextBox.Multiline = true;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(196, 20);
            this.priceTextBox.TabIndex = 12;
            this.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumb_KeyPress);
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(3, 265);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(200, 23);
            this.priceLabel.TabIndex = 11;
            this.priceLabel.Text = "Цена (в руб.)";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weightTextBox.BackColor = System.Drawing.Color.LightGray;
            this.weightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightTextBox.Location = new System.Drawing.Point(7, 242);
            this.weightTextBox.MaxLength = 26;
            this.weightTextBox.Multiline = true;
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(292, 20);
            this.weightTextBox.TabIndex = 10;
            this.weightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.weightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumb_KeyPress);
            // 
            // weightLabel
            // 
            this.weightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightLabel.Location = new System.Drawing.Point(3, 220);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(296, 23);
            this.weightLabel.TabIndex = 9;
            this.weightLabel.Text = "Вес (в гр.)";
            this.weightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.BackColor = System.Drawing.Color.LightGray;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(7, 197);
            this.nameTextBox.MaxLength = 26;
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(292, 20);
            this.nameTextBox.TabIndex = 8;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_KeyPress);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(3, 175);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(296, 23);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Название";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editProductPanel
            // 
            this.editProductPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editProductPanel.BackColor = System.Drawing.Color.Gray;
            this.editProductPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editProductPanel.Controls.Add(this.currentProductEmptyLabel2);
            this.editProductPanel.Controls.Add(this.currentProductEmptyLabel1);
            this.editProductPanel.Location = new System.Drawing.Point(329, 12);
            this.editProductPanel.Name = "editProductPanel";
            this.editProductPanel.Size = new System.Drawing.Size(304, 359);
            this.editProductPanel.TabIndex = 4;
            // 
            // currentProductEmptyLabel2
            // 
            this.currentProductEmptyLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentProductEmptyLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentProductEmptyLabel2.Location = new System.Drawing.Point(3, 170);
            this.currentProductEmptyLabel2.Name = "currentProductEmptyLabel2";
            this.currentProductEmptyLabel2.Size = new System.Drawing.Size(296, 22);
            this.currentProductEmptyLabel2.TabIndex = 1;
            this.currentProductEmptyLabel2.Text = "из списка";
            this.currentProductEmptyLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentProductEmptyLabel1
            // 
            this.currentProductEmptyLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentProductEmptyLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentProductEmptyLabel1.Location = new System.Drawing.Point(3, 146);
            this.currentProductEmptyLabel1.Name = "currentProductEmptyLabel1";
            this.currentProductEmptyLabel1.Size = new System.Drawing.Size(296, 22);
            this.currentProductEmptyLabel1.TabIndex = 0;
            this.currentProductEmptyLabel1.Text = "Выберите продукт";
            this.currentProductEmptyLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuAndProductListsPanel
            // 
            this.menuAndProductListsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menuAndProductListsPanel.BackColor = System.Drawing.Color.Gray;
            this.menuAndProductListsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuAndProductListsPanel.Controls.Add(this.editMenuNameButton);
            this.menuAndProductListsPanel.Controls.Add(this.deleteMenuButton);
            this.menuAndProductListsPanel.Controls.Add(this.addNewMenuButton);
            this.menuAndProductListsPanel.Controls.Add(this.productListLabel);
            this.menuAndProductListsPanel.Controls.Add(this.productListComboBox);
            this.menuAndProductListsPanel.Controls.Add(this.menuListLabel);
            this.menuAndProductListsPanel.Controls.Add(this.deleteProductButton);
            this.menuAndProductListsPanel.Controls.Add(this.doneButton);
            this.menuAndProductListsPanel.Controls.Add(this.addNewProductButton);
            this.menuAndProductListsPanel.Controls.Add(this.saveButton);
            this.menuAndProductListsPanel.Controls.Add(this.menuListComboBox);
            this.menuAndProductListsPanel.Location = new System.Drawing.Point(12, 12);
            this.menuAndProductListsPanel.Name = "menuAndProductListsPanel";
            this.menuAndProductListsPanel.Size = new System.Drawing.Size(304, 359);
            this.menuAndProductListsPanel.TabIndex = 3;
            // 
            // editMenuNameButton
            // 
            this.editMenuNameButton.BackColor = System.Drawing.Color.LightGray;
            this.editMenuNameButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.editMenuNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editMenuNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editMenuNameButton.Location = new System.Drawing.Point(33, 73);
            this.editMenuNameButton.Name = "editMenuNameButton";
            this.editMenuNameButton.Size = new System.Drawing.Size(240, 34);
            this.editMenuNameButton.TabIndex = 10;
            this.editMenuNameButton.Text = "Изменить название раздела";
            this.editMenuNameButton.UseVisualStyleBackColor = false;
            this.editMenuNameButton.Click += new System.EventHandler(this.editMenuNameButton_Click);
            // 
            // deleteMenuButton
            // 
            this.deleteMenuButton.BackColor = System.Drawing.Color.LightGray;
            this.deleteMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.deleteMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteMenuButton.Location = new System.Drawing.Point(156, 175);
            this.deleteMenuButton.Name = "deleteMenuButton";
            this.deleteMenuButton.Size = new System.Drawing.Size(135, 53);
            this.deleteMenuButton.TabIndex = 9;
            this.deleteMenuButton.Text = "Удалить раздел";
            this.deleteMenuButton.UseVisualStyleBackColor = false;
            this.deleteMenuButton.Click += new System.EventHandler(this.deleteMenuButton_Click);
            // 
            // addNewMenuButton
            // 
            this.addNewMenuButton.BackColor = System.Drawing.Color.LightGray;
            this.addNewMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.addNewMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewMenuButton.Location = new System.Drawing.Point(15, 175);
            this.addNewMenuButton.Name = "addNewMenuButton";
            this.addNewMenuButton.Size = new System.Drawing.Size(135, 53);
            this.addNewMenuButton.TabIndex = 8;
            this.addNewMenuButton.Text = "Добавить раздел";
            this.addNewMenuButton.UseVisualStyleBackColor = false;
            this.addNewMenuButton.Click += new System.EventHandler(this.addNewMenuButton_Click);
            // 
            // productListLabel
            // 
            this.productListLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productListLabel.Location = new System.Drawing.Point(15, 114);
            this.productListLabel.Name = "productListLabel";
            this.productListLabel.Size = new System.Drawing.Size(276, 23);
            this.productListLabel.TabIndex = 7;
            this.productListLabel.Text = "Список продуктов";
            this.productListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productListComboBox
            // 
            this.productListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productListComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productListComboBox.FormattingEnabled = true;
            this.productListComboBox.Location = new System.Drawing.Point(15, 140);
            this.productListComboBox.Name = "productListComboBox";
            this.productListComboBox.Size = new System.Drawing.Size(276, 28);
            this.productListComboBox.TabIndex = 6;
            this.productListComboBox.SelectedIndexChanged += new System.EventHandler(this.productListComboBox_SelectedIndexChanged);
            // 
            // menuListLabel
            // 
            this.menuListLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuListLabel.Location = new System.Drawing.Point(15, 13);
            this.menuListLabel.Name = "menuListLabel";
            this.menuListLabel.Size = new System.Drawing.Size(276, 23);
            this.menuListLabel.TabIndex = 5;
            this.menuListLabel.Text = "Список разделов";
            this.menuListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.BackColor = System.Drawing.Color.LightGray;
            this.deleteProductButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.deleteProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteProductButton.Location = new System.Drawing.Point(156, 234);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(135, 53);
            this.deleteProductButton.TabIndex = 4;
            this.deleteProductButton.Text = "Удалить продукт";
            this.deleteProductButton.UseVisualStyleBackColor = false;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
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
            // addNewProductButton
            // 
            this.addNewProductButton.BackColor = System.Drawing.Color.LightGray;
            this.addNewProductButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.addNewProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewProductButton.Location = new System.Drawing.Point(15, 234);
            this.addNewProductButton.Name = "addNewProductButton";
            this.addNewProductButton.Size = new System.Drawing.Size(135, 53);
            this.addNewProductButton.TabIndex = 2;
            this.addNewProductButton.Text = "Добавить продукт";
            this.addNewProductButton.UseVisualStyleBackColor = false;
            this.addNewProductButton.Click += new System.EventHandler(this.addNewProductButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LightGray;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(15, 293);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(135, 53);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // menuListComboBox
            // 
            this.menuListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuListComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuListComboBox.FormattingEnabled = true;
            this.menuListComboBox.Location = new System.Drawing.Point(15, 39);
            this.menuListComboBox.Name = "menuListComboBox";
            this.menuListComboBox.Size = new System.Drawing.Size(276, 28);
            this.menuListComboBox.TabIndex = 0;
            this.menuListComboBox.SelectedIndexChanged += new System.EventHandler(this.menuListComboBox_SelectedIndexChanged);
            // 
            // EditMenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(645, 383);
            this.Controls.Add(this.currentProductPanel);
            this.Controls.Add(this.editProductPanel);
            this.Controls.Add(this.menuAndProductListsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditMenuWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditMenuWindow";
            this.currentProductPanel.ResumeLayout(false);
            this.currentProductPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).EndInit();
            this.editProductPanel.ResumeLayout(false);
            this.menuAndProductListsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel currentProductPanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editPhotoButton;
        private System.Windows.Forms.PictureBox productImage;
        private System.Windows.Forms.TextBox vaxTextBox;
        private System.Windows.Forms.Label vaxLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel editProductPanel;
        private System.Windows.Forms.Label currentProductEmptyLabel2;
        private System.Windows.Forms.Label currentProductEmptyLabel1;
        private System.Windows.Forms.Panel menuAndProductListsPanel;
        private System.Windows.Forms.Button deleteMenuButton;
        private System.Windows.Forms.Button addNewMenuButton;
        private System.Windows.Forms.Label productListLabel;
        private System.Windows.Forms.ComboBox productListComboBox;
        private System.Windows.Forms.Label menuListLabel;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button addNewProductButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox menuListComboBox;
        private System.Windows.Forms.Button editColorButton;
        private System.Windows.Forms.Button editMenuNameButton;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.TextBox numberTextBox;
    }
}