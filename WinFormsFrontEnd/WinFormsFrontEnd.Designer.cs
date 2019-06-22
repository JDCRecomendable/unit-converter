namespace UnitConverter
{
    partial class WinFormsFrontEnd
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
            this.MainArea = new System.Windows.Forms.TableLayoutPanel();
            this.SwapButton = new System.Windows.Forms.Button();
            this.QuantityPicker = new System.Windows.Forms.ListBox();
            this.FromUnitPicker = new System.Windows.Forms.ListBox();
            this.ToUnitPicker = new System.Windows.Forms.ListBox();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.MainArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainArea
            // 
            this.MainArea.ColumnCount = 3;
            this.MainArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MainArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.MainArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.MainArea.Controls.Add(this.SwapButton, 2, 2);
            this.MainArea.Controls.Add(this.QuantityPicker, 0, 0);
            this.MainArea.Controls.Add(this.FromUnitPicker, 1, 0);
            this.MainArea.Controls.Add(this.ToUnitPicker, 2, 0);
            this.MainArea.Controls.Add(this.InputBox, 1, 1);
            this.MainArea.Controls.Add(this.OutputBox, 2, 1);
            this.MainArea.Controls.Add(this.ClearButton, 1, 2);
            this.MainArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainArea.Location = new System.Drawing.Point(0, 0);
            this.MainArea.Name = "MainArea";
            this.MainArea.RowCount = 3;
            this.MainArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.MainArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.MainArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.MainArea.Size = new System.Drawing.Size(464, 201);
            this.MainArea.TabIndex = 0;
            // 
            // SwapButton
            // 
            this.SwapButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SwapButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwapButton.Location = new System.Drawing.Point(311, 171);
            this.SwapButton.Name = "SwapButton";
            this.SwapButton.Size = new System.Drawing.Size(150, 27);
            this.SwapButton.TabIndex = 6;
            this.SwapButton.Text = "&Swap";
            this.SwapButton.UseVisualStyleBackColor = true;
            this.SwapButton.Click += new System.EventHandler(this.SwapButton_Click);
            // 
            // QuantityPicker
            // 
            this.QuantityPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuantityPicker.FormattingEnabled = true;
            this.QuantityPicker.Items.AddRange(new object[] {
            "Length",
            "Area",
            "Volume",
            "Time",
            "Speed",
            "Flow Rate of Area",
            "Flow Rate of Volume",
            "Flow Rate of Mass",
            "Mass",
            "Energy",
            "Pressure",
            "Temperature",
            "Luminance",
            "Illuminance",
            "Angle",
            "Data Size"});
            this.QuantityPicker.Location = new System.Drawing.Point(3, 3);
            this.QuantityPicker.Name = "QuantityPicker";
            this.MainArea.SetRowSpan(this.QuantityPicker, 3);
            this.QuantityPicker.Size = new System.Drawing.Size(148, 195);
            this.QuantityPicker.TabIndex = 0;
            this.QuantityPicker.SelectedIndexChanged += new System.EventHandler(this.QuantityPicker_SelectedIndexChanged);
            // 
            // FromUnitPicker
            // 
            this.FromUnitPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FromUnitPicker.FormattingEnabled = true;
            this.FromUnitPicker.Location = new System.Drawing.Point(157, 3);
            this.FromUnitPicker.Name = "FromUnitPicker";
            this.FromUnitPicker.Size = new System.Drawing.Size(148, 130);
            this.FromUnitPicker.TabIndex = 1;
            this.FromUnitPicker.SelectedIndexChanged += new System.EventHandler(this.FromUnitPicker_SelectedIndexChanged);
            // 
            // ToUnitPicker
            // 
            this.ToUnitPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToUnitPicker.FormattingEnabled = true;
            this.ToUnitPicker.Location = new System.Drawing.Point(311, 3);
            this.ToUnitPicker.Name = "ToUnitPicker";
            this.ToUnitPicker.Size = new System.Drawing.Size(150, 130);
            this.ToUnitPicker.TabIndex = 2;
            this.ToUnitPicker.SelectedIndexChanged += new System.EventHandler(this.ToUnitPicker_SelectedIndexChanged);
            // 
            // InputBox
            // 
            this.InputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputBox.Location = new System.Drawing.Point(157, 141);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(148, 21);
            this.InputBox.TabIndex = 3;
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // OutputBox
            // 
            this.OutputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputBox.Location = new System.Drawing.Point(311, 141);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(150, 21);
            this.OutputBox.TabIndex = 4;
            // 
            // ClearButton
            // 
            this.ClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(157, 171);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(148, 27);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "&Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // WinFormsFrontEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 201);
            this.Controls.Add(this.MainArea);
            this.Name = "WinFormsFrontEnd";
            this.Text = "Unit Converter";
            this.MainArea.ResumeLayout(false);
            this.MainArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainArea;
        private System.Windows.Forms.ListBox QuantityPicker;
        private System.Windows.Forms.ListBox FromUnitPicker;
        private System.Windows.Forms.ListBox ToUnitPicker;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Button SwapButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

