namespace Willett_405
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Browse = new System.Windows.Forms.Button();
            this.TaskFile = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.UPButton = new System.Windows.Forms.Button();
            this.itemsTable = new System.Windows.Forms.DataGridView();
            this.DNButton = new System.Windows.Forms.Button();
            this.PgUPButton = new System.Windows.Forms.Button();
            this.PgDNButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Finished = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemsTable)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Browse
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Browse, 2);
            this.Browse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Browse.Location = new System.Drawing.Point(627, 3);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(154, 36);
            this.Browse.TabIndex = 1;
            this.Browse.Text = "Обзор...";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // TaskFile
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TaskFile, 2);
            this.TaskFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaskFile.Enabled = false;
            this.TaskFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskFile.Location = new System.Drawing.Point(129, 3);
            this.TaskFile.Name = "TaskFile";
            this.TaskFile.Size = new System.Drawing.Size(492, 35);
            this.TaskFile.TabIndex = 3;
            this.TaskFile.Text = "Путь к файлу с заданием";
            // 
            // NextButton
            // 
            this.NextButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextButton.Location = new System.Drawing.Point(157, 519);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(464, 39);
            this.NextButton.TabIndex = 0;
            this.NextButton.Text = "Старт/Следующий";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ExitButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ExitButton, 2);
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(627, 519);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(154, 39);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Закрыть";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ApplyButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ApplyButton, 2);
            this.ApplyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ApplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyButton.Location = new System.Drawing.Point(3, 519);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(148, 39);
            this.ApplyButton.TabIndex = 6;
            this.ApplyButton.Text = "Применить";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // UPButton
            // 
            this.UPButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UPButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UPButton.Location = new System.Drawing.Point(739, 93);
            this.UPButton.Name = "UPButton";
            this.UPButton.Size = new System.Drawing.Size(42, 42);
            this.UPButton.TabIndex = 8;
            this.UPButton.Text = "UP";
            this.UPButton.UseVisualStyleBackColor = true;
            this.UPButton.Click += new System.EventHandler(this.UPButton_Click);
            // 
            // itemsTable
            // 
            this.itemsTable.AllowUserToAddRows = false;
            this.itemsTable.AllowUserToDeleteRows = false;
            this.itemsTable.AllowUserToResizeRows = false;
            this.itemsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.itemsTable, 4);
            this.itemsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.itemsTable.Location = new System.Drawing.Point(3, 45);
            this.itemsTable.MultiSelect = false;
            this.itemsTable.Name = "itemsTable";
            this.itemsTable.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.itemsTable, 5);
            this.itemsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemsTable.ShowCellErrors = false;
            this.itemsTable.ShowCellToolTips = false;
            this.itemsTable.ShowEditingIcon = false;
            this.itemsTable.ShowRowErrors = false;
            this.itemsTable.Size = new System.Drawing.Size(730, 468);
            this.itemsTable.TabIndex = 15;
            this.itemsTable.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsTable_RowEnter);
            // 
            // DNButton
            // 
            this.DNButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DNButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DNButton.Location = new System.Drawing.Point(739, 423);
            this.DNButton.Name = "DNButton";
            this.DNButton.Size = new System.Drawing.Size(42, 42);
            this.DNButton.TabIndex = 12;
            this.DNButton.Text = "DN";
            this.DNButton.UseVisualStyleBackColor = true;
            this.DNButton.Click += new System.EventHandler(this.DNButton_Click);
            // 
            // PgUPButton
            // 
            this.PgUPButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PgUPButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PgUPButton.Location = new System.Drawing.Point(739, 45);
            this.PgUPButton.Name = "PgUPButton";
            this.PgUPButton.Size = new System.Drawing.Size(42, 42);
            this.PgUPButton.TabIndex = 14;
            this.PgUPButton.Text = "PgUP";
            this.PgUPButton.UseVisualStyleBackColor = true;
            this.PgUPButton.Click += new System.EventHandler(this.PgUPButton_Click);
            // 
            // PgDNButton
            // 
            this.PgDNButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PgDNButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PgDNButton.Location = new System.Drawing.Point(739, 471);
            this.PgDNButton.Name = "PgDNButton";
            this.PgDNButton.Size = new System.Drawing.Size(42, 42);
            this.PgDNButton.TabIndex = 13;
            this.PgDNButton.Text = "PgDN";
            this.PgDNButton.UseVisualStyleBackColor = true;
            this.PgDNButton.Click += new System.EventHandler(this.PgDNButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Controls.Add(this.PgDNButton, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.PgUPButton, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.DNButton, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.itemsTable, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.UPButton, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.ApplyButton, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.ExitButton, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.NextButton, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.TaskFile, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Browse, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Finished, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.StopButton, 4, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // Finished
            // 
            this.Finished.AutoSize = true;
            this.Finished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Finished.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Finished.ForeColor = System.Drawing.Color.Red;
            this.Finished.Location = new System.Drawing.Point(3, 0);
            this.Finished.Name = "Finished";
            this.Finished.Size = new System.Drawing.Size(120, 42);
            this.Finished.TabIndex = 16;
            this.Finished.Text = "Изгот.";
            this.Finished.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Finished.Visible = false;
            // 
            // StopButton
            // 
            this.StopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopButton.Location = new System.Drawing.Point(739, 141);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(42, 276);
            this.StopButton.TabIndex = 17;
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsTable)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button PgDNButton;
        private System.Windows.Forms.Button PgUPButton;
        private System.Windows.Forms.Button DNButton;
        private System.Windows.Forms.DataGridView itemsTable;
        private System.Windows.Forms.Button UPButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TextBox TaskFile;
        private System.Windows.Forms.Label Finished;
        private System.Windows.Forms.Button StopButton;
    }
}

