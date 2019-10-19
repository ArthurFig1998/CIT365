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
            this.label1 = new System.Windows.Forms.Label();
            this.sendQuote = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.todaysDate = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.comShippingType = new System.Windows.Forms.ComboBox();
            this.comSurfaceMaterial = new System.Windows.Forms.ComboBox();
            this.numDrawers = new System.Windows.Forms.NumericUpDown();
            this.numDepth = new System.Windows.Forms.NumericUpDown();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.ShippingType = new System.Windows.Forms.Label();
            this.SurfaceMaterial = new System.Windows.Forms.Label();
            this.NumberOfDrawers = new System.Windows.Forms.Label();
            this.Depth = new System.Windows.Forms.Label();
            this.Width = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.quotePriceBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 39);
            this.label1.TabIndex = 31;
            this.label1.Text = "Add New Quote";
            // 
            // sendQuote
            // 
            this.sendQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendQuote.Location = new System.Drawing.Point(617, 365);
            this.sendQuote.Margin = new System.Windows.Forms.Padding(4);
            this.sendQuote.Name = "sendQuote";
            this.sendQuote.Size = new System.Drawing.Size(100, 28);
            this.sendQuote.TabIndex = 30;
            this.sendQuote.Text = "Done";
            this.sendQuote.UseVisualStyleBackColor = true;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(378, 39);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 17);
            this.dateLabel.TabIndex = 29;
            // 
            // todaysDate
            // 
            this.todaysDate.AutoSize = true;
            this.todaysDate.Location = new System.Drawing.Point(310, 25);
            this.todaysDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.todaysDate.Name = "todaysDate";
            this.todaysDate.Size = new System.Drawing.Size(0, 17);
            this.todaysDate.TabIndex = 28;
            // 
            // customerName
            // 
            this.customerName.Enabled = false;
            this.customerName.Location = new System.Drawing.Point(230, 128);
            this.customerName.Margin = new System.Windows.Forms.Padding(4);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(332, 22);
            this.customerName.TabIndex = 27;
            // 
            // comShippingType
            // 
            this.comShippingType.Enabled = false;
            this.comShippingType.FormattingEnabled = true;
            this.comShippingType.Location = new System.Drawing.Point(570, 256);
            this.comShippingType.Margin = new System.Windows.Forms.Padding(4);
            this.comShippingType.Name = "comShippingType";
            this.comShippingType.Size = new System.Drawing.Size(160, 24);
            this.comShippingType.TabIndex = 26;
            // 
            // comSurfaceMaterial
            // 
            this.comSurfaceMaterial.Enabled = false;
            this.comSurfaceMaterial.FormattingEnabled = true;
            this.comSurfaceMaterial.Location = new System.Drawing.Point(570, 208);
            this.comSurfaceMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.comSurfaceMaterial.Name = "comSurfaceMaterial";
            this.comSurfaceMaterial.Size = new System.Drawing.Size(160, 24);
            this.comSurfaceMaterial.TabIndex = 25;
            // 
            // numDrawers
            // 
            this.numDrawers.Enabled = false;
            this.numDrawers.Location = new System.Drawing.Point(403, 303);
            this.numDrawers.Margin = new System.Windows.Forms.Padding(4);
            this.numDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numDrawers.Name = "numDrawers";
            this.numDrawers.Size = new System.Drawing.Size(48, 22);
            this.numDrawers.TabIndex = 24;
            // 
            // numDepth
            // 
            this.numDepth.Enabled = false;
            this.numDepth.Location = new System.Drawing.Point(150, 256);
            this.numDepth.Margin = new System.Windows.Forms.Padding(4);
            this.numDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numDepth.Name = "numDepth";
            this.numDepth.Size = new System.Drawing.Size(160, 22);
            this.numDepth.TabIndex = 23;
            this.numDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // numWidth
            // 
            this.numWidth.Enabled = false;
            this.numWidth.Location = new System.Drawing.Point(150, 208);
            this.numWidth.Margin = new System.Windows.Forms.Padding(4);
            this.numWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(160, 22);
            this.numWidth.TabIndex = 22;
            this.numWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // ShippingType
            // 
            this.ShippingType.AutoSize = true;
            this.ShippingType.Location = new System.Drawing.Point(378, 260);
            this.ShippingType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ShippingType.Name = "ShippingType";
            this.ShippingType.Size = new System.Drawing.Size(99, 17);
            this.ShippingType.TabIndex = 21;
            this.ShippingType.Text = "Shipping Type";
            // 
            // SurfaceMaterial
            // 
            this.SurfaceMaterial.AutoSize = true;
            this.SurfaceMaterial.Location = new System.Drawing.Point(378, 212);
            this.SurfaceMaterial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SurfaceMaterial.Name = "SurfaceMaterial";
            this.SurfaceMaterial.Size = new System.Drawing.Size(147, 17);
            this.SurfaceMaterial.TabIndex = 20;
            this.SurfaceMaterial.Text = "Desk Surface Material";
            // 
            // NumberOfDrawers
            // 
            this.NumberOfDrawers.AutoSize = true;
            this.NumberOfDrawers.Location = new System.Drawing.Point(226, 306);
            this.NumberOfDrawers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumberOfDrawers.Name = "NumberOfDrawers";
            this.NumberOfDrawers.Size = new System.Drawing.Size(133, 17);
            this.NumberOfDrawers.TabIndex = 19;
            this.NumberOfDrawers.Text = "Number Of Drawers";
            // 
            // Depth
            // 
            this.Depth.AutoSize = true;
            this.Depth.Location = new System.Drawing.Point(26, 259);
            this.Depth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Depth.Name = "Depth";
            this.Depth.Size = new System.Drawing.Size(46, 17);
            this.Depth.TabIndex = 18;
            this.Depth.Text = "Depth";
            // 
            // Width
            // 
            this.Width.AutoSize = true;
            this.Width.Location = new System.Drawing.Point(27, 211);
            this.Width.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(44, 17);
            this.Width.TabIndex = 17;
            this.Width.Text = "Width";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(95, 132);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(109, 17);
            this.nameLabel.TabIndex = 16;
            this.nameLabel.Text = "Customer Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(277, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 48);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quote";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Price";
            // 
            // quotePriceBox
            // 
            this.quotePriceBox.Enabled = false;
            this.quotePriceBox.Location = new System.Drawing.Point(361, 362);
            this.quotePriceBox.Margin = new System.Windows.Forms.Padding(4);
            this.quotePriceBox.Name = "quotePriceBox";
            this.quotePriceBox.Size = new System.Drawing.Size(109, 22);
            this.quotePriceBox.TabIndex = 33;
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 418);
            this.Controls.Add(this.quotePriceBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendQuote);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.todaysDate);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.comShippingType);
            this.Controls.Add(this.comSurfaceMaterial);
            this.Controls.Add(this.numDrawers);
            this.Controls.Add(this.numDepth);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.ShippingType);
            this.Controls.Add(this.SurfaceMaterial);
            this.Controls.Add(this.NumberOfDrawers);
            this.Controls.Add(this.Depth);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.nameLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DisplayQuote_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numDrawers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sendQuote;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label todaysDate;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.ComboBox comShippingType;
        private System.Windows.Forms.ComboBox comSurfaceMaterial;
        private System.Windows.Forms.NumericUpDown numDrawers;
        private System.Windows.Forms.NumericUpDown numDepth;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Label ShippingType;
        private System.Windows.Forms.Label SurfaceMaterial;
        private System.Windows.Forms.Label NumberOfDrawers;
        private System.Windows.Forms.Label Depth;
        private System.Windows.Forms.Label Width;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quotePriceBox;
    }
}