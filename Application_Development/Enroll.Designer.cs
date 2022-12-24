namespace Application_Development
{
    partial class Enroll
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
            this.dataGridReport = new System.Windows.Forms.DataGridView();
            this.dateReport = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridReport
            // 
            this.dataGridReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReport.Location = new System.Drawing.Point(329, 122);
            this.dataGridReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridReport.Name = "dataGridReport";
            this.dataGridReport.RowHeadersWidth = 51;
            this.dataGridReport.Size = new System.Drawing.Size(436, 212);
            this.dataGridReport.TabIndex = 0;
            // 
            // dateReport
            // 
            this.dateReport.Location = new System.Drawing.Point(235, 30);
            this.dateReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateReport.Name = "dateReport";
            this.dateReport.Size = new System.Drawing.Size(265, 22);
            this.dateReport.TabIndex = 1;
            // 
            // Enroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dateReport);
            this.Controls.Add(this.dataGridReport);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Enroll";
            this.Text = "Enroll";
            this.Load += new System.EventHandler(this.Enroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridReport;
        private System.Windows.Forms.DateTimePicker dateReport;
    }
}