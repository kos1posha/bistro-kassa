
namespace s3_pr_cw
{
    partial class EmployeeProfile
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
            this.panel = new System.Windows.Forms.Panel();
            this.profileLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.todayRevenueLabel = new System.Windows.Forms.Label();
            this.startShiftLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.editRestaurantButton = new System.Windows.Forms.Button();
            this.endShiftButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.employeePhoto = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Red;
            this.panel.Controls.Add(this.profileLabel);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(528, 37);
            this.panel.TabIndex = 5;
            // 
            // profileLabel
            // 
            this.profileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profileLabel.Location = new System.Drawing.Point(3, 9);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(422, 23);
            this.profileLabel.TabIndex = 3;
            this.profileLabel.Text = "Карточка работника";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(3, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(55, 20);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "ФИО:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idLabel.Location = new System.Drawing.Point(3, 30);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(33, 20);
            this.idLabel.TabIndex = 8;
            this.idLabel.Text = "ID:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.idLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.todayRevenueLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.startShiftLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.typeLabel, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(339, 151);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // todayRevenueLabel
            // 
            this.todayRevenueLabel.AutoSize = true;
            this.todayRevenueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.todayRevenueLabel.Location = new System.Drawing.Point(3, 120);
            this.todayRevenueLabel.Name = "todayRevenueLabel";
            this.todayRevenueLabel.Size = new System.Drawing.Size(85, 20);
            this.todayRevenueLabel.TabIndex = 9;
            this.todayRevenueLabel.Text = "Выручка:";
            // 
            // startShiftLabel
            // 
            this.startShiftLabel.AutoSize = true;
            this.startShiftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startShiftLabel.Location = new System.Drawing.Point(3, 90);
            this.startShiftLabel.Name = "startShiftLabel";
            this.startShiftLabel.Size = new System.Drawing.Size(136, 20);
            this.startShiftLabel.TabIndex = 10;
            this.startShiftLabel.Text = "Начало смены:";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLabel.Location = new System.Drawing.Point(3, 60);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(44, 20);
            this.typeLabel.TabIndex = 11;
            this.typeLabel.Text = "Тип:";
            // 
            // editRestaurantButton
            // 
            this.editRestaurantButton.BackColor = System.Drawing.Color.Gray;
            this.editRestaurantButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.editRestaurantButton.FlatAppearance.BorderSize = 0;
            this.editRestaurantButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editRestaurantButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editRestaurantButton.Location = new System.Drawing.Point(357, 215);
            this.editRestaurantButton.Name = "editRestaurantButton";
            this.editRestaurantButton.Size = new System.Drawing.Size(150, 45);
            this.editRestaurantButton.TabIndex = 11;
            this.editRestaurantButton.Text = "Изменить данные о заведении";
            this.editRestaurantButton.UseVisualStyleBackColor = false;
            this.editRestaurantButton.Click += new System.EventHandler(this.editRestaurantButton_Click);
            // 
            // endShiftButton
            // 
            this.endShiftButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.endShiftButton.BackColor = System.Drawing.Color.Gray;
            this.endShiftButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.endShiftButton.FlatAppearance.BorderSize = 0;
            this.endShiftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endShiftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endShiftButton.Location = new System.Drawing.Point(12, 215);
            this.endShiftButton.Name = "endShiftButton";
            this.endShiftButton.Size = new System.Drawing.Size(150, 45);
            this.endShiftButton.TabIndex = 12;
            this.endShiftButton.Text = "Закончить смену";
            this.endShiftButton.UseVisualStyleBackColor = false;
            this.endShiftButton.Click += new System.EventHandler(this.endShiftButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Gray;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(186, 215);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(150, 45);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // employeePhoto
            // 
            this.employeePhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.employeePhoto.BackgroundImage = global::s3_pr_cw.Properties.Resources.NoAvatarImage;
            this.employeePhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.employeePhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeePhoto.ErrorImage = global::s3_pr_cw.Properties.Resources.NoAvatarImage;
            this.employeePhoto.InitialImage = global::s3_pr_cw.Properties.Resources.NoAvatarImage;
            this.employeePhoto.Location = new System.Drawing.Point(357, 53);
            this.employeePhoto.Name = "employeePhoto";
            this.employeePhoto.Size = new System.Drawing.Size(150, 151);
            this.employeePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.employeePhoto.TabIndex = 6;
            this.employeePhoto.TabStop = false;
            // 
            // EmployeeProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(528, 272);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.endShiftButton);
            this.Controls.Add(this.editRestaurantButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.employeePhoto);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeProfile";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmployeeProfile";
            this.panel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeePhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.PictureBox employeePhoto;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label todayRevenueLabel;
        private System.Windows.Forms.Label startShiftLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Button editRestaurantButton;
        private System.Windows.Forms.Button endShiftButton;
        private System.Windows.Forms.Button backButton;
    }
}