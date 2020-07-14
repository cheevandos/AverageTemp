namespace TempAverage
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.measurementsGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.averageTempButton = new System.Windows.Forms.Button();
            this.datePanel = new System.Windows.Forms.Panel();
            this.averageTempTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.measurementsGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.datePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // measurementsGridView
            // 
            this.measurementsGridView.AllowUserToAddRows = false;
            this.measurementsGridView.AllowUserToDeleteRows = false;
            this.measurementsGridView.AllowUserToResizeRows = false;
            this.measurementsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.measurementsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.measurementsGridView.BackgroundColor = System.Drawing.Color.DarkGray;
            this.measurementsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.measurementsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.measurementsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.measurementsGridView.ColumnHeadersHeight = 42;
            this.measurementsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.measurementsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.temperatureColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.measurementsGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.measurementsGridView.EnableHeadersVisualStyles = false;
            this.measurementsGridView.Location = new System.Drawing.Point(11, 50);
            this.measurementsGridView.MultiSelect = false;
            this.measurementsGridView.Name = "measurementsGridView";
            this.measurementsGridView.ReadOnly = true;
            this.measurementsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.measurementsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.measurementsGridView.RowHeadersVisible = false;
            this.measurementsGridView.RowHeadersWidth = 40;
            this.measurementsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.measurementsGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.measurementsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.measurementsGridView.Size = new System.Drawing.Size(376, 300);
            this.measurementsGridView.TabIndex = 1;
            // 
            // idColumn
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.idColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.idColumn.HeaderText = "Дата измерения";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            // 
            // temperatureColumn
            // 
            this.temperatureColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.temperatureColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.temperatureColumn.HeaderText = "Температура, C°";
            this.temperatureColumn.Name = "temperatureColumn";
            this.temperatureColumn.ReadOnly = true;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.DimGray;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(11, 356);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(186, 42);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить значение";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(11, 8);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(376, 39);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Подсчет средней температуры";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.averageTempButton);
            this.panel1.Controls.Add(this.datePanel);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.measurementsGridView);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Controls.Add(this.quitButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 509);
            this.panel1.TabIndex = 10;
            // 
            // averageTempButton
            // 
            this.averageTempButton.BackColor = System.Drawing.Color.Goldenrod;
            this.averageTempButton.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.averageTempButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.averageTempButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.averageTempButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.averageTempButton.ForeColor = System.Drawing.Color.White;
            this.averageTempButton.Location = new System.Drawing.Point(11, 404);
            this.averageTempButton.Name = "averageTempButton";
            this.averageTempButton.Size = new System.Drawing.Size(266, 42);
            this.averageTempButton.TabIndex = 6;
            this.averageTempButton.Text = "Вычислить среднее значение";
            this.averageTempButton.UseVisualStyleBackColor = false;
            this.averageTempButton.Click += new System.EventHandler(this.AverageTempButton_Click);
            // 
            // datePanel
            // 
            this.datePanel.BackColor = System.Drawing.Color.DarkGray;
            this.datePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.datePanel.Controls.Add(this.averageTempTextBox);
            this.datePanel.Location = new System.Drawing.Point(283, 404);
            this.datePanel.Name = "datePanel";
            this.datePanel.Size = new System.Drawing.Size(104, 42);
            this.datePanel.TabIndex = 5;
            // 
            // averageTempTextBox
            // 
            this.averageTempTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.averageTempTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.averageTempTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.averageTempTextBox.ForeColor = System.Drawing.Color.White;
            this.averageTempTextBox.Location = new System.Drawing.Point(3, 8);
            this.averageTempTextBox.Name = "averageTempTextBox";
            this.averageTempTextBox.ReadOnly = true;
            this.averageTempTextBox.Size = new System.Drawing.Size(96, 24);
            this.averageTempTextBox.TabIndex = 0;
            this.averageTempTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.DimGray;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(203, 356);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(184, 42);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Удалить значение";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.IndianRed;
            this.quitButton.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.quitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quitButton.ForeColor = System.Drawing.Color.White;
            this.quitButton.Location = new System.Drawing.Point(12, 452);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(376, 42);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Выйти";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(401, 509);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ПК";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.measurementsGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.datePanel.ResumeLayout(false);
            this.datePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView measurementsGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureColumn;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button averageTempButton;
        private System.Windows.Forms.Panel datePanel;
        private System.Windows.Forms.TextBox averageTempTextBox;
    }
}