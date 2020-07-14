namespace TempAverage
{
    partial class MeasurementAddingForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.datePanel = new System.Windows.Forms.Panel();
            this.dateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.temperaturePanel = new System.Windows.Forms.Panel();
            this.tempMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.belowZeroCheckBox = new System.Windows.Forms.CheckBox();
            this.datePanel.SuspendLayout();
            this.temperaturePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.DimGray;
            this.okButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.okButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.Location = new System.Drawing.Point(11, 216);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(98, 42);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "ОК";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(271, 39);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Укажите дату измерения:";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // datePanel
            // 
            this.datePanel.BackColor = System.Drawing.Color.DimGray;
            this.datePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.datePanel.Controls.Add(this.dateMaskedTextBox);
            this.datePanel.Location = new System.Drawing.Point(12, 51);
            this.datePanel.Name = "datePanel";
            this.datePanel.Size = new System.Drawing.Size(271, 42);
            this.datePanel.TabIndex = 4;
            // 
            // dateMaskedTextBox
            // 
            this.dateMaskedTextBox.BackColor = System.Drawing.Color.DimGray;
            this.dateMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateMaskedTextBox.ForeColor = System.Drawing.Color.White;
            this.dateMaskedTextBox.Location = new System.Drawing.Point(6, 11);
            this.dateMaskedTextBox.Mask = "00/00/0000";
            this.dateMaskedTextBox.Name = "dateMaskedTextBox";
            this.dateMaskedTextBox.Size = new System.Drawing.Size(257, 19);
            this.dateMaskedTextBox.TabIndex = 0;
            this.dateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // temperaturePanel
            // 
            this.temperaturePanel.BackColor = System.Drawing.Color.DimGray;
            this.temperaturePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.temperaturePanel.Controls.Add(this.tempMaskedTextBox);
            this.temperaturePanel.Location = new System.Drawing.Point(12, 138);
            this.temperaturePanel.Name = "temperaturePanel";
            this.temperaturePanel.Size = new System.Drawing.Size(271, 42);
            this.temperaturePanel.TabIndex = 6;
            // 
            // tempMaskedTextBox
            // 
            this.tempMaskedTextBox.BackColor = System.Drawing.Color.DimGray;
            this.tempMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tempMaskedTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tempMaskedTextBox.ForeColor = System.Drawing.Color.White;
            this.tempMaskedTextBox.Location = new System.Drawing.Point(6, 10);
            this.tempMaskedTextBox.Mask = "00.0";
            this.tempMaskedTextBox.Name = "tempMaskedTextBox";
            this.tempMaskedTextBox.Size = new System.Drawing.Size(257, 20);
            this.tempMaskedTextBox.TabIndex = 1;
            this.tempMaskedTextBox.ValidatingType = typeof(int);
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.temperatureLabel.ForeColor = System.Drawing.Color.White;
            this.temperatureLabel.Location = new System.Drawing.Point(15, 96);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(271, 39);
            this.temperatureLabel.TabIndex = 7;
            this.temperatureLabel.Text = "Укажите температуру:";
            this.temperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.IndianRed;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(115, 216);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(167, 42);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Закрыть";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.belowZeroCheckBox);
            this.panel1.Controls.Add(this.okButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 272);
            this.panel1.TabIndex = 9;
            // 
            // belowZeroCheckBox
            // 
            this.belowZeroCheckBox.AutoSize = true;
            this.belowZeroCheckBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.belowZeroCheckBox.ForeColor = System.Drawing.Color.White;
            this.belowZeroCheckBox.Location = new System.Drawing.Point(19, 185);
            this.belowZeroCheckBox.Name = "belowZeroCheckBox";
            this.belowZeroCheckBox.Size = new System.Drawing.Size(104, 24);
            this.belowZeroCheckBox.TabIndex = 0;
            this.belowZeroCheckBox.Text = "Ниже нуля";
            this.belowZeroCheckBox.UseVisualStyleBackColor = true;
            // 
            // MeasurementAddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(295, 272);
            this.Controls.Add(this.temperatureLabel);
            this.Controls.Add(this.temperaturePanel);
            this.Controls.Add(this.datePanel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MeasurementAddingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ПК";
            this.datePanel.ResumeLayout(false);
            this.datePanel.PerformLayout();
            this.temperaturePanel.ResumeLayout(false);
            this.temperaturePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel datePanel;
        private System.Windows.Forms.Panel temperaturePanel;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox dateMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox tempMaskedTextBox;
        private System.Windows.Forms.CheckBox belowZeroCheckBox;
    }
}