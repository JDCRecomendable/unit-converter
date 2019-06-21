namespace UnitConverter
{
    partial class WindowsFrontEnd
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
            this.quantityPicker = new System.Windows.Forms.ListBox();
            this.fromUnitPicker = new System.Windows.Forms.ListBox();
            this.toUnitPicker = new System.Windows.Forms.ListBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // quantityPicker
            // 
            this.quantityPicker.FormattingEnabled = true;
            this.quantityPicker.Items.AddRange(new object[] {
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
            this.quantityPicker.Location = new System.Drawing.Point(12, 12);
            this.quantityPicker.Name = "quantityPicker";
            this.quantityPicker.Size = new System.Drawing.Size(117, 173);
            this.quantityPicker.TabIndex = 0;
            this.quantityPicker.SelectedIndexChanged += new System.EventHandler(this.quantityPicker_SelectedIndexChanged);
            // 
            // fromUnitPicker
            // 
            this.fromUnitPicker.FormattingEnabled = true;
            this.fromUnitPicker.Location = new System.Drawing.Point(174, 14);
            this.fromUnitPicker.Name = "fromUnitPicker";
            this.fromUnitPicker.Size = new System.Drawing.Size(117, 134);
            this.fromUnitPicker.TabIndex = 1;
            // 
            // toUnitPicker
            // 
            this.toUnitPicker.FormattingEnabled = true;
            this.toUnitPicker.Location = new System.Drawing.Point(335, 14);
            this.toUnitPicker.Name = "toUnitPicker";
            this.toUnitPicker.Size = new System.Drawing.Size(117, 134);
            this.toUnitPicker.TabIndex = 2;
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(174, 165);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(117, 20);
            this.inputBox.TabIndex = 3;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(335, 165);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(117, 20);
            this.outputBox.TabIndex = 4;
            // 
            // WindowsFrontEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 201);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.toUnitPicker);
            this.Controls.Add(this.fromUnitPicker);
            this.Controls.Add(this.quantityPicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WindowsFrontEnd";
            this.Text = "Unit Converter";
            this.Load += new System.EventHandler(this.WindowsFrontEnd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox quantityPicker;
        private System.Windows.Forms.ListBox fromUnitPicker;
        private System.Windows.Forms.ListBox toUnitPicker;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TextBox outputBox;
    }
}