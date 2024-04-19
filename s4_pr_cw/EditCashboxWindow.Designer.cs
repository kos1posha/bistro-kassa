
namespace s3_pr_cw
{
    partial class EditCashboxWindow
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
            this.kktTextBox = new System.Windows.Forms.TextBox();
            this.kktLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.doneButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.currentEmployeeComboBox = new System.Windows.Forms.ComboBox();
            this.currentEmployee = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kktTextBox
            // 
            this.kktTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kktTextBox.BackColor = System.Drawing.Color.LightGray;
            this.kktTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kktTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kktTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.kktTextBox.Location = new System.Drawing.Point(26, 50);
            this.kktTextBox.MaxLength = 16;
            this.kktTextBox.Name = "kktTextBox";
            this.kktTextBox.Size = new System.Drawing.Size(401, 26);
            this.kktTextBox.TabIndex = 3;
            this.kktTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kktTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kktTextBox_KeyPress);
            this.kktTextBox.Leave += new System.EventHandler(this.kktTextBox_Leave);
            // 
            // kktLabel
            // 
            this.kktLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kktLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kktLabel.ForeColor = System.Drawing.Color.Black;
            this.kktLabel.Location = new System.Drawing.Point(0, 26);
            this.kktLabel.Name = "kktLabel";
            this.kktLabel.Size = new System.Drawing.Size(450, 30);
            this.kktLabel.TabIndex = 2;
            this.kktLabel.Text = "Код КТТ";
            this.kktLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.doneButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.currentEmployeeComboBox);
            this.panel1.Controls.Add(this.currentEmployee);
            this.panel1.Controls.Add(this.kktTextBox);
            this.panel1.Controls.Add(this.kktLabel);
            this.panel1.Location = new System.Drawing.Point(97, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 199);
            this.panel1.TabIndex = 4;
            // 
            // doneButton
            // 
            this.doneButton.BackColor = System.Drawing.Color.LightGray;
            this.doneButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.doneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doneButton.Location = new System.Drawing.Point(232, 152);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(150, 36);
            this.doneButton.TabIndex = 7;
            this.doneButton.Text = "Готово";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LightGray;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(71, 152);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 36);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // currentEmployeeComboBox
            // 
            this.currentEmployeeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currentEmployeeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentEmployeeComboBox.FormattingEnabled = true;
            this.currentEmployeeComboBox.Location = new System.Drawing.Point(26, 110);
            this.currentEmployeeComboBox.Name = "currentEmployeeComboBox";
            this.currentEmployeeComboBox.Size = new System.Drawing.Size(401, 32);
            this.currentEmployeeComboBox.TabIndex = 5;
            // 
            // currentEmployee
            // 
            this.currentEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentEmployee.ForeColor = System.Drawing.Color.Black;
            this.currentEmployee.Location = new System.Drawing.Point(0, 84);
            this.currentEmployee.Name = "currentEmployee";
            this.currentEmployee.Size = new System.Drawing.Size(450, 30);
            this.currentEmployee.TabIndex = 4;
            this.currentEmployee.Text = "Текущий сотрудник";
            this.currentEmployee.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EditCashboxWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 383);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditCashboxWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditCashboxWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox kktTextBox;
        private System.Windows.Forms.Label kktLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox currentEmployeeComboBox;
        private System.Windows.Forms.Label currentEmployee;
    }
}