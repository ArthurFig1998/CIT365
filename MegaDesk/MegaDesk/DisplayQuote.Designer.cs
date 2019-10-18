namespace MegaDesk
{
    partial class DisplayQuote
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
            this.quotesDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.quotesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // quotesDataGrid
            // 
            this.quotesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quotesDataGrid.Location = new System.Drawing.Point(-1, 1);
            this.quotesDataGrid.Name = "quotesDataGrid";
            this.quotesDataGrid.Size = new System.Drawing.Size(755, 259);
            this.quotesDataGrid.TabIndex = 0;
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 261);
            this.Controls.Add(this.quotesDataGrid);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DisplayQuote_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.quotesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView quotesDataGrid;
    }
}