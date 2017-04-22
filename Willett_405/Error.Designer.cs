namespace Willett_405
{
    partial class Error
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ErrorText = new System.Windows.Forms.Label();
            this.ErrorOk = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.ErrorText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ErrorOk, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(404, 164);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorText.Location = new System.Drawing.Point(23, 0);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(358, 124);
            this.ErrorText.TabIndex = 0;
            this.ErrorText.Text = "ОШИБКА!!!";
            this.ErrorText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ErrorOk
            // 
            this.ErrorOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorOk.Location = new System.Drawing.Point(23, 127);
            this.ErrorOk.Name = "ErrorOk";
            this.ErrorOk.Size = new System.Drawing.Size(358, 34);
            this.ErrorOk.TabIndex = 1;
            this.ErrorOk.Text = "OK";
            this.ErrorOk.UseVisualStyleBackColor = true;
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 164);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Error";
            this.Text = "Ошибка!!!";
            this.Load += new System.EventHandler(this.Error_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ErrorText;
        private System.Windows.Forms.Button ErrorOk;
    }
}