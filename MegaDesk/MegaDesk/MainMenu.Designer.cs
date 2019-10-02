namespace MegaDesk
{
    partial class MainMenu
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
            this.addNewQuote = new System.Windows.Forms.Button();
            this.exitForm = new System.Windows.Forms.Button();
            this.searchQuotes = new System.Windows.Forms.Button();
            this.viewQuotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNewQuote
            // 
            this.addNewQuote.Location = new System.Drawing.Point(12, 31);
            this.addNewQuote.Name = "addNewQuote";
            this.addNewQuote.Size = new System.Drawing.Size(125, 50);
            this.addNewQuote.TabIndex = 0;
            this.addNewQuote.Text = "Add New Quote";
            this.addNewQuote.UseVisualStyleBackColor = true;
            this.addNewQuote.Click += new System.EventHandler(this.AddNewQuote_Click);
            // 
            // exitForm
            // 
            this.exitForm.Location = new System.Drawing.Point(12, 199);
            this.exitForm.Name = "exitForm";
            this.exitForm.Size = new System.Drawing.Size(125, 50);
            this.exitForm.TabIndex = 1;
            this.exitForm.Text = "Exit";
            this.exitForm.UseVisualStyleBackColor = true;
            this.exitForm.Click += new System.EventHandler(this.Exit_Click);
            // 
            // searchQuotes
            // 
            this.searchQuotes.Location = new System.Drawing.Point(12, 143);
            this.searchQuotes.Name = "searchQuotes";
            this.searchQuotes.Size = new System.Drawing.Size(125, 50);
            this.searchQuotes.TabIndex = 2;
            this.searchQuotes.Text = "Search Quotes";
            this.searchQuotes.UseVisualStyleBackColor = true;
            this.searchQuotes.Click += new System.EventHandler(this.SearchQuotes_Click);
            // 
            // viewQuotes
            // 
            this.viewQuotes.Location = new System.Drawing.Point(12, 87);
            this.viewQuotes.Name = "viewQuotes";
            this.viewQuotes.Size = new System.Drawing.Size(125, 50);
            this.viewQuotes.TabIndex = 3;
            this.viewQuotes.Text = "View Quotes";
            this.viewQuotes.UseVisualStyleBackColor = true;
            this.viewQuotes.Click += new System.EventHandler(this.ViewQuotes_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.viewQuotes);
            this.Controls.Add(this.searchQuotes);
            this.Controls.Add(this.exitForm);
            this.Controls.Add(this.addNewQuote);
            this.Name = "MainMenu";
            this.Text = "Mega Desk - Arthur Figueiredo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNewQuote;
        private System.Windows.Forms.Button exitForm;
        private System.Windows.Forms.Button searchQuotes;
        private System.Windows.Forms.Button viewQuotes;
    }
}

