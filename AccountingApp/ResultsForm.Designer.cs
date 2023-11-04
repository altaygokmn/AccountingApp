namespace AccountingApp
{
    partial class ResultsForm
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
            dgwResultsTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgwResultsTable).BeginInit();
            SuspendLayout();
            // 
            // dgwResultsTable
            // 
            dgwResultsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwResultsTable.Location = new Point(0, -1);
            dgwResultsTable.Name = "dgwResultsTable";
            dgwResultsTable.RowHeadersWidth = 51;
            dgwResultsTable.RowTemplate.Height = 29;
            dgwResultsTable.Size = new Size(1340, 514);
            dgwResultsTable.TabIndex = 0;
            dgwResultsTable.CellContentClick += dgwResultsTable_CellContentClick;
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1338, 512);
            Controls.Add(dgwResultsTable);
            Name = "ResultsForm";
            Text = "ResultsForm";
            Load += ResultsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgwResultsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwResultsTable;
    }
}