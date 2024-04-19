
namespace s3_pr_cw
{
    partial class GetFundsWindow
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
            this.fundsTextBox = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.captionLabel = new System.Windows.Forms.Label();
            this.exactAmountButton = new System.Windows.Forms.Button();
            this.cashButton10 = new System.Windows.Forms.Button();
            this.cashButton50 = new System.Windows.Forms.Button();
            this.cashButton100 = new System.Windows.Forms.Button();
            this.cashButton200 = new System.Windows.Forms.Button();
            this.cashButton500 = new System.Windows.Forms.Button();
            this.cashButton1000 = new System.Windows.Forms.Button();
            this.cashButton2000 = new System.Windows.Forms.Button();
            this.cashButton5000 = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.plusCheckBox = new System.Windows.Forms.CheckBox();
            this.doneButton = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fundsTextBox
            // 
            this.fundsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fundsTextBox.BackColor = System.Drawing.Color.LightGray;
            this.fundsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fundsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fundsTextBox.Location = new System.Drawing.Point(12, 45);
            this.fundsTextBox.MaxLength = 5;
            this.fundsTextBox.Name = "fundsTextBox";
            this.fundsTextBox.Size = new System.Drawing.Size(358, 47);
            this.fundsTextBox.TabIndex = 1;
            this.fundsTextBox.Text = "0";
            this.fundsTextBox.TextChanged += new System.EventHandler(this.fundsTextBox_TextChanged);
            this.fundsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fundsTextBox_KeyPress);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Red;
            this.panel.Controls.Add(this.captionLabel);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(382, 37);
            this.panel.TabIndex = 5;
            // 
            // captionLabel
            // 
            this.captionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.captionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.captionLabel.Location = new System.Drawing.Point(3, 9);
            this.captionLabel.Name = "captionLabel";
            this.captionLabel.Size = new System.Drawing.Size(376, 23);
            this.captionLabel.TabIndex = 3;
            this.captionLabel.Text = "Внесение наличных средств";
            this.captionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // exactAmountButton
            // 
            this.exactAmountButton.BackColor = System.Drawing.Color.LightGray;
            this.exactAmountButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.exactAmountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exactAmountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exactAmountButton.Location = new System.Drawing.Point(255, 98);
            this.exactAmountButton.Name = "exactAmountButton";
            this.exactAmountButton.Size = new System.Drawing.Size(115, 47);
            this.exactAmountButton.TabIndex = 6;
            this.exactAmountButton.Text = "Точная сумма";
            this.exactAmountButton.UseVisualStyleBackColor = false;
            this.exactAmountButton.Click += new System.EventHandler(this.exactAmountButton_Click);
            // 
            // cashButton10
            // 
            this.cashButton10.BackColor = System.Drawing.Color.LightGray;
            this.cashButton10.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.cashButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cashButton10.Location = new System.Drawing.Point(12, 98);
            this.cashButton10.Name = "cashButton10";
            this.cashButton10.Size = new System.Drawing.Size(118, 47);
            this.cashButton10.TabIndex = 8;
            this.cashButton10.Text = "10";
            this.cashButton10.UseVisualStyleBackColor = false;
            this.cashButton10.Click += new System.EventHandler(this.cashButton_Click);
            // 
            // cashButton50
            // 
            this.cashButton50.BackColor = System.Drawing.Color.LightGray;
            this.cashButton50.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.cashButton50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashButton50.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cashButton50.Location = new System.Drawing.Point(131, 98);
            this.cashButton50.Name = "cashButton50";
            this.cashButton50.Size = new System.Drawing.Size(118, 47);
            this.cashButton50.TabIndex = 9;
            this.cashButton50.Text = "50";
            this.cashButton50.UseVisualStyleBackColor = false;
            this.cashButton50.Click += new System.EventHandler(this.cashButton_Click);
            // 
            // cashButton100
            // 
            this.cashButton100.BackColor = System.Drawing.Color.LightGray;
            this.cashButton100.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.cashButton100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashButton100.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cashButton100.Location = new System.Drawing.Point(12, 146);
            this.cashButton100.Name = "cashButton100";
            this.cashButton100.Size = new System.Drawing.Size(118, 47);
            this.cashButton100.TabIndex = 10;
            this.cashButton100.Text = "100";
            this.cashButton100.UseVisualStyleBackColor = false;
            this.cashButton100.Click += new System.EventHandler(this.cashButton_Click);
            // 
            // cashButton200
            // 
            this.cashButton200.BackColor = System.Drawing.Color.LightGray;
            this.cashButton200.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.cashButton200.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashButton200.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cashButton200.Location = new System.Drawing.Point(131, 146);
            this.cashButton200.Name = "cashButton200";
            this.cashButton200.Size = new System.Drawing.Size(118, 47);
            this.cashButton200.TabIndex = 11;
            this.cashButton200.Text = "200";
            this.cashButton200.UseVisualStyleBackColor = false;
            this.cashButton200.Click += new System.EventHandler(this.cashButton_Click);
            // 
            // cashButton500
            // 
            this.cashButton500.BackColor = System.Drawing.Color.LightGray;
            this.cashButton500.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.cashButton500.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashButton500.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cashButton500.Location = new System.Drawing.Point(12, 194);
            this.cashButton500.Name = "cashButton500";
            this.cashButton500.Size = new System.Drawing.Size(118, 47);
            this.cashButton500.TabIndex = 12;
            this.cashButton500.Text = "500";
            this.cashButton500.UseVisualStyleBackColor = false;
            this.cashButton500.Click += new System.EventHandler(this.cashButton_Click);
            // 
            // cashButton1000
            // 
            this.cashButton1000.BackColor = System.Drawing.Color.LightGray;
            this.cashButton1000.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.cashButton1000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashButton1000.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cashButton1000.Location = new System.Drawing.Point(131, 194);
            this.cashButton1000.Name = "cashButton1000";
            this.cashButton1000.Size = new System.Drawing.Size(118, 47);
            this.cashButton1000.TabIndex = 13;
            this.cashButton1000.Text = "1000";
            this.cashButton1000.UseVisualStyleBackColor = false;
            this.cashButton1000.Click += new System.EventHandler(this.cashButton_Click);
            // 
            // cashButton2000
            // 
            this.cashButton2000.BackColor = System.Drawing.Color.LightGray;
            this.cashButton2000.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.cashButton2000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashButton2000.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cashButton2000.Location = new System.Drawing.Point(12, 242);
            this.cashButton2000.Name = "cashButton2000";
            this.cashButton2000.Size = new System.Drawing.Size(118, 47);
            this.cashButton2000.TabIndex = 14;
            this.cashButton2000.Text = "2000";
            this.cashButton2000.UseVisualStyleBackColor = false;
            this.cashButton2000.Click += new System.EventHandler(this.cashButton_Click);
            // 
            // cashButton5000
            // 
            this.cashButton5000.BackColor = System.Drawing.Color.LightGray;
            this.cashButton5000.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.cashButton5000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashButton5000.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cashButton5000.Location = new System.Drawing.Point(131, 242);
            this.cashButton5000.Name = "cashButton5000";
            this.cashButton5000.Size = new System.Drawing.Size(118, 47);
            this.cashButton5000.TabIndex = 15;
            this.cashButton5000.Text = "5000";
            this.cashButton5000.UseVisualStyleBackColor = false;
            this.cashButton5000.Click += new System.EventHandler(this.cashButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.LightGray;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(255, 146);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(115, 47);
            this.clearButton.TabIndex = 16;
            this.clearButton.Text = "Стереть";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.LightGray;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(255, 242);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(115, 47);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // plusCheckBox
            // 
            this.plusCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.plusCheckBox.AutoSize = true;
            this.plusCheckBox.BackColor = System.Drawing.Color.LightGray;
            this.plusCheckBox.Checked = true;
            this.plusCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.plusCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusCheckBox.Location = new System.Drawing.Point(313, 48);
            this.plusCheckBox.Name = "plusCheckBox";
            this.plusCheckBox.Size = new System.Drawing.Size(53, 41);
            this.plusCheckBox.TabIndex = 18;
            this.plusCheckBox.Text = "+";
            this.plusCheckBox.UseVisualStyleBackColor = false;
            // 
            // doneButton
            // 
            this.doneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.doneButton.BackColor = System.Drawing.Color.LightGray;
            this.doneButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.doneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doneButton.Location = new System.Drawing.Point(255, 194);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(115, 47);
            this.doneButton.TabIndex = 19;
            this.doneButton.Text = "Внести";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // GetFundsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(382, 299);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.plusCheckBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.cashButton5000);
            this.Controls.Add(this.cashButton2000);
            this.Controls.Add(this.cashButton1000);
            this.Controls.Add(this.cashButton500);
            this.Controls.Add(this.cashButton200);
            this.Controls.Add(this.cashButton100);
            this.Controls.Add(this.cashButton50);
            this.Controls.Add(this.cashButton10);
            this.Controls.Add(this.exactAmountButton);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.fundsTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GetFundsWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetFundsWindow";
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox fundsTextBox;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label captionLabel;
        private System.Windows.Forms.Button exactAmountButton;
        private System.Windows.Forms.Button cashButton10;
        private System.Windows.Forms.Button cashButton50;
        private System.Windows.Forms.Button cashButton100;
        private System.Windows.Forms.Button cashButton200;
        private System.Windows.Forms.Button cashButton500;
        private System.Windows.Forms.Button cashButton1000;
        private System.Windows.Forms.Button cashButton2000;
        private System.Windows.Forms.Button cashButton5000;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox plusCheckBox;
        private System.Windows.Forms.Button doneButton;
    }
}