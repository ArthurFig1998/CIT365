namespace MegaDesk
{
    partial class SearchQuotes
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
            this.label1 = new System.Windows.Forms.Label();
            this.comSurfaceMaterialSearch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.quotesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // quotesDataGrid
            // 
            this.quotesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quotesDataGrid.Location = new System.Drawing.Point(0, 64);
            this.quotesDataGrid.Name = "quotesDataGrid";
            this.quotesDataGrid.Size = new System.Drawing.Size(940, 201);
            this.quotesDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Surface Material:";
            // 
            // comSurfaceMaterialSearch
            // 
            this.comSurfaceMaterialSearch.FormattingEnabled = true;
            this.comSurfaceMaterialSearch.Location = new System.Drawing.Point(186, 15);
            this.comSurfaceMaterialSearch.Name = "comSurfaceMaterialSearch";
            this.comSurfaceMaterialSearch.Size = new System.Drawing.Size(189, 21);
            this.comSurfaceMaterialSearch.TabIndex = 2;
            this.comSurfaceMaterialSearch.SelectedIndexChanged += new System.EventHandler(this.ComSurfaceMaterialSearch_SelectedIndexChanged);
            this.comSurfaceMaterialSearch.TextChanged += new System.EventHandler(this.ComSurfaceMaterialSearch_TextChanged);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 261);
            this.Controls.Add(this.comSurfaceMaterialSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quotesDataGrid);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchQuotes_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.quotesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView quotesDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comSurfaceMaterialSearch;
    }
}