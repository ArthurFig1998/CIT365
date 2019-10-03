namespace MegaDesk
{
    partial class AddQuote
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
            this.CustomerName = new System.Windows.Forms.Label();
            this.Width = new System.Windows.Forms.Label();
            this.Depth = new System.Windows.Forms.Label();
            this.NumberOfDrawers = new System.Windows.Forms.Label();
            this.SurfaceMaterial = new System.Windows.Forms.Label();
            this.ShippingType = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.todaysDate = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.sendQuote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Location = new System.Drawing.Point(12, 65);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(35, 13);
            this.CustomerName.TabIndex = 0;
            this.CustomerName.Text = "Name";
            // 
            // Width
            // 
            this.Width.AutoSize = true;
            this.Width.Location = new System.Drawing.Point(12, 91);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(35, 13);
            this.Width.TabIndex = 1;
            this.Width.Text = "Width";
            // 
            // Depth
            // 
            this.Depth.AutoSize = true;
            this.Depth.Location = new System.Drawing.Point(12, 117);
            this.Depth.Name = "Depth";
            this.Depth.Size = new System.Drawing.Size(36, 13);
            this.Depth.TabIndex = 2;
            this.Depth.Text = "Depth";
            // 
            // NumberOfDrawers
            // 
            this.NumberOfDrawers.AutoSize = true;
            this.NumberOfDrawers.Location = new System.Drawing.Point(12, 143);
            this.NumberOfDrawers.Name = "NumberOfDrawers";
            this.NumberOfDrawers.Size = new System.Drawing.Size(100, 13);
            this.NumberOfDrawers.TabIndex = 3;
            this.NumberOfDrawers.Text = "Number Of Drawers";
            // 
            // SurfaceMaterial
            // 
            this.SurfaceMaterial.AutoSize = true;
            this.SurfaceMaterial.Location = new System.Drawing.Point(12, 170);
            this.SurfaceMaterial.Name = "SurfaceMaterial";
            this.SurfaceMaterial.Size = new System.Drawing.Size(112, 13);
            this.SurfaceMaterial.TabIndex = 4;
            this.SurfaceMaterial.Text = "Desk Surface Material";
            // 
            // ShippingType
            // 
            this.ShippingType.AutoSize = true;
            this.ShippingType.Location = new System.Drawing.Point(12, 197);
            this.ShippingType.Name = "ShippingType";
            this.ShippingType.Size = new System.Drawing.Size(75, 13);
            this.ShippingType.TabIndex = 5;
            this.ShippingType.Text = "Shipping Type";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(139, 84);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(139, 110);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 7;
            this.numericUpDown2.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(140, 136);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.comboBox1.Location = new System.Drawing.Point(140, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "3 Days",
            "5 Days",
            "7 Days"});
            this.comboBox2.Location = new System.Drawing.Point(140, 189);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // todaysDate
            // 
            this.todaysDate.AutoSize = true;
            this.todaysDate.Location = new System.Drawing.Point(225, 13);
            this.todaysDate.Name = "todaysDate";
            this.todaysDate.Size = new System.Drawing.Size(0, 13);
            this.todaysDate.TabIndex = 12;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(276, 24);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 13);
            this.dateLabel.TabIndex = 13;
            // 
            // sendQuote
            // 
            this.sendQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendQuote.Location = new System.Drawing.Point(297, 226);
            this.sendQuote.Name = "sendQuote";
            this.sendQuote.Size = new System.Drawing.Size(75, 23);
            this.sendQuote.TabIndex = 14;
            this.sendQuote.Text = "Submit";
            this.sendQuote.UseVisualStyleBackColor = true;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.sendQuote);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.todaysDate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.ShippingType);
            this.Controls.Add(this.SurfaceMaterial);
            this.Controls.Add(this.NumberOfDrawers);
            this.Controls.Add(this.Depth);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.CustomerName);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.Label Width;
        private System.Windows.Forms.Label Depth;
        private System.Windows.Forms.Label NumberOfDrawers;
        private System.Windows.Forms.Label SurfaceMaterial;
        private System.Windows.Forms.Label ShippingType;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label todaysDate;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button sendQuote;
    }
}