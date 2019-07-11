namespace UnitConverter
{
    partial class DeleteCustomUnit
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
            this.CustomUnitNameLabel = new System.Windows.Forms.Label();
            this.QuantityPicker = new System.Windows.Forms.ListBox();
            this.ButtonArea = new System.Windows.Forms.TableLayoutPanel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DeleteAndCloseButton = new System.Windows.Forms.Button();
            this.CustomUnitsListBox = new System.Windows.Forms.CheckedListBox();
            this.MainArea.SuspendLayout();
            this.ButtonArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainArea
            // 
            this.MainArea.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.MainArea.ColumnCount = 2;
            this.MainArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MainArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66667F));
            this.MainArea.Controls.Add(this.CustomUnitNameLabel, 0, 0);
            this.MainArea.Controls.Add(this.QuantityPicker, 0, 0);
            this.MainArea.Controls.Add(this.ButtonArea, 1, 2);
            this.MainArea.Controls.Add(this.CustomUnitsListBox, 1, 1);
            this.MainArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainArea.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainArea.Location = new System.Drawing.Point(0, 0);
            this.MainArea.Name = "MainArea";
            this.MainArea.RowCount = 3;
            this.MainArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.MainArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MainArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainArea.Size = new System.Drawing.Size(464, 281);
            this.MainArea.TabIndex = 1;
            // 
            // CustomUnitNameLabel
            // 
            this.CustomUnitNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomUnitNameLabel.AutoSize = true;
            this.CustomUnitNameLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomUnitNameLabel.Location = new System.Drawing.Point(157, 7);
            this.CustomUnitNameLabel.Name = "CustomUnitNameLabel";
            this.CustomUnitNameLabel.Size = new System.Drawing.Size(304, 13);
            this.CustomUnitNameLabel.TabIndex = 8;
            this.CustomUnitNameLabel.Text = "Select Units to Delete";
            this.CustomUnitNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuantityPicker
            // 
            this.QuantityPicker.BackColor = System.Drawing.Color.Gray;
            this.QuantityPicker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuantityPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuantityPicker.ForeColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.QuantityPicker.Size = new System.Drawing.Size(148, 275);
            this.QuantityPicker.TabIndex = 0;
            this.QuantityPicker.SelectedIndexChanged += new System.EventHandler(this.QuantityPicker_SelectedIndexChanged);
            // 
            // ButtonArea
            // 
            this.ButtonArea.ColumnCount = 3;
            this.ButtonArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonArea.Controls.Add(this.CloseButton, 0, 0);
            this.ButtonArea.Controls.Add(this.DeleteButton, 1, 0);
            this.ButtonArea.Controls.Add(this.DeleteAndCloseButton, 2, 0);
            this.ButtonArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonArea.Location = new System.Drawing.Point(157, 241);
            this.ButtonArea.Name = "ButtonArea";
            this.ButtonArea.RowCount = 1;
            this.ButtonArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.ButtonArea.Size = new System.Drawing.Size(304, 37);
            this.ButtonArea.TabIndex = 7;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(3, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(95, 31);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.TabStop = false;
            this.CloseButton.Text = "&Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(104, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(95, 31);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "&Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteAndCloseButton
            // 
            this.DeleteAndCloseButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DeleteAndCloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteAndCloseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteAndCloseButton.FlatAppearance.BorderSize = 0;
            this.DeleteAndCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteAndCloseButton.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAndCloseButton.Location = new System.Drawing.Point(205, 3);
            this.DeleteAndCloseButton.Name = "DeleteAndCloseButton";
            this.DeleteAndCloseButton.Size = new System.Drawing.Size(96, 31);
            this.DeleteAndCloseButton.TabIndex = 6;
            this.DeleteAndCloseButton.Text = "D&elete and Close";
            this.DeleteAndCloseButton.UseVisualStyleBackColor = false;
            this.DeleteAndCloseButton.Click += new System.EventHandler(this.DeleteAndCloseButton_Click);
            // 
            // CustomUnitsListBox
            // 
            this.CustomUnitsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CustomUnitsListBox.BackColor = System.Drawing.Color.Gray;
            this.CustomUnitsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomUnitsListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomUnitsListBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustomUnitsListBox.FormattingEnabled = true;
            this.CustomUnitsListBox.Location = new System.Drawing.Point(249, 31);
            this.CustomUnitsListBox.Name = "CustomUnitsListBox";
            this.CustomUnitsListBox.Size = new System.Drawing.Size(120, 195);
            this.CustomUnitsListBox.TabIndex = 9;
            // 
            // DeleteCustomUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(464, 281);
            this.ControlBox = false;
            this.Controls.Add(this.MainArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteCustomUnit";
            this.Text = "Delete Custom Unit";
            this.MainArea.ResumeLayout(false);
            this.MainArea.PerformLayout();
            this.ButtonArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainArea;
        private System.Windows.Forms.ListBox QuantityPicker;
        private System.Windows.Forms.TableLayoutPanel ButtonArea;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button DeleteAndCloseButton;
        private System.Windows.Forms.Label CustomUnitNameLabel;
        private System.Windows.Forms.CheckedListBox CustomUnitsListBox;
    }
}