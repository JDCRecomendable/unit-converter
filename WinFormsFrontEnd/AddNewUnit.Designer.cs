namespace UnitConverter
{
    partial class AddNewUnit
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
            this.GlobalArea = new System.Windows.Forms.TableLayoutPanel();
            this.MainArea = new System.Windows.Forms.TableLayoutPanel();
            this.QuantityPicker = new System.Windows.Forms.ListBox();
            this.CustomUnitNameLabel = new System.Windows.Forms.Label();
            this.BasedOnUnitLabel = new System.Windows.Forms.Label();
            this.GradientLabel = new System.Windows.Forms.Label();
            this.InterceptLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.FootnoteLabel = new System.Windows.Forms.Label();
            this.ButtonArea = new System.Windows.Forms.TableLayoutPanel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddAndCloseButton = new System.Windows.Forms.Button();
            this.CustomUnitNameInput = new System.Windows.Forms.TextBox();
            this.GradientInput = new System.Windows.Forms.TextBox();
            this.InterceptInput = new System.Windows.Forms.TextBox();
            this.BasedOnUnitDropDown = new System.Windows.Forms.ComboBox();
            this.GlobalArea.SuspendLayout();
            this.MainArea.SuspendLayout();
            this.ButtonArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // GlobalArea
            // 
            this.GlobalArea.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.GlobalArea.ColumnCount = 1;
            this.GlobalArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalArea.Controls.Add(this.MainArea, 0, 0);
            this.GlobalArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalArea.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GlobalArea.Location = new System.Drawing.Point(0, 0);
            this.GlobalArea.Name = "GlobalArea";
            this.GlobalArea.RowCount = 1;
            this.GlobalArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GlobalArea.Size = new System.Drawing.Size(464, 281);
            this.GlobalArea.TabIndex = 4;
            // 
            // MainArea
            // 
            this.MainArea.ColumnCount = 3;
            this.MainArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.MainArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.MainArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.MainArea.Controls.Add(this.QuantityPicker, 0, 0);
            this.MainArea.Controls.Add(this.CustomUnitNameLabel, 1, 0);
            this.MainArea.Controls.Add(this.BasedOnUnitLabel, 1, 1);
            this.MainArea.Controls.Add(this.GradientLabel, 1, 3);
            this.MainArea.Controls.Add(this.InterceptLabel, 1, 4);
            this.MainArea.Controls.Add(this.DescriptionLabel, 1, 2);
            this.MainArea.Controls.Add(this.FootnoteLabel, 1, 5);
            this.MainArea.Controls.Add(this.ButtonArea, 1, 6);
            this.MainArea.Controls.Add(this.CustomUnitNameInput, 2, 0);
            this.MainArea.Controls.Add(this.GradientInput, 2, 3);
            this.MainArea.Controls.Add(this.InterceptInput, 2, 4);
            this.MainArea.Controls.Add(this.BasedOnUnitDropDown, 2, 1);
            this.MainArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainArea.Location = new System.Drawing.Point(3, 3);
            this.MainArea.Name = "MainArea";
            this.MainArea.RowCount = 7;
            this.MainArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.MainArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.MainArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.MainArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.MainArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.MainArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MainArea.Size = new System.Drawing.Size(458, 275);
            this.MainArea.TabIndex = 0;
            // 
            // QuantityPicker
            // 
            this.QuantityPicker.BackColor = System.Drawing.Color.Gray;
            this.QuantityPicker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuantityPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuantityPicker.ForeColor = System.Drawing.SystemColors.Window;
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
            this.MainArea.SetRowSpan(this.QuantityPicker, 7);
            this.QuantityPicker.Size = new System.Drawing.Size(146, 269);
            this.QuantityPicker.TabIndex = 0;
            this.QuantityPicker.SelectedIndexChanged += new System.EventHandler(this.QuantityPicker_SelectedIndexChanged);
            // 
            // CustomUnitNameLabel
            // 
            this.CustomUnitNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomUnitNameLabel.AutoSize = true;
            this.CustomUnitNameLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomUnitNameLabel.Location = new System.Drawing.Point(155, 10);
            this.CustomUnitNameLabel.Name = "CustomUnitNameLabel";
            this.CustomUnitNameLabel.Size = new System.Drawing.Size(146, 13);
            this.CustomUnitNameLabel.TabIndex = 1;
            this.CustomUnitNameLabel.Text = "Name of Custom Unit*";
            // 
            // BasedOnUnitLabel
            // 
            this.BasedOnUnitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BasedOnUnitLabel.AutoSize = true;
            this.BasedOnUnitLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasedOnUnitLabel.Location = new System.Drawing.Point(155, 43);
            this.BasedOnUnitLabel.Name = "BasedOnUnitLabel";
            this.BasedOnUnitLabel.Size = new System.Drawing.Size(146, 13);
            this.BasedOnUnitLabel.TabIndex = 2;
            this.BasedOnUnitLabel.Text = "Based On*";
            // 
            // GradientLabel
            // 
            this.GradientLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GradientLabel.AutoSize = true;
            this.GradientLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradientLabel.Location = new System.Drawing.Point(155, 144);
            this.GradientLabel.Name = "GradientLabel";
            this.GradientLabel.Size = new System.Drawing.Size(146, 13);
            this.GradientLabel.TabIndex = 3;
            this.GradientLabel.Text = "Gradient (m)*";
            // 
            // InterceptLabel
            // 
            this.InterceptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InterceptLabel.AutoSize = true;
            this.InterceptLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterceptLabel.Location = new System.Drawing.Point(155, 177);
            this.InterceptLabel.Name = "InterceptLabel";
            this.InterceptLabel.Size = new System.Drawing.Size(146, 13);
            this.InterceptLabel.TabIndex = 4;
            this.InterceptLabel.Text = "y-intercpet (c)";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.MainArea.SetColumnSpan(this.DescriptionLabel, 2);
            this.DescriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(155, 66);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(300, 68);
            this.DescriptionLabel.TabIndex = 5;
            this.DescriptionLabel.Text = "y = mx + c,\r\nwhere y is the unit to compare against,\r\nand x is the custom unit";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FootnoteLabel
            // 
            this.FootnoteLabel.AutoSize = true;
            this.MainArea.SetColumnSpan(this.FootnoteLabel, 2);
            this.FootnoteLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FootnoteLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FootnoteLabel.Location = new System.Drawing.Point(155, 200);
            this.FootnoteLabel.Name = "FootnoteLabel";
            this.FootnoteLabel.Size = new System.Drawing.Size(300, 33);
            this.FootnoteLabel.TabIndex = 6;
            this.FootnoteLabel.Text = "*mandatory";
            this.FootnoteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonArea
            // 
            this.ButtonArea.ColumnCount = 3;
            this.MainArea.SetColumnSpan(this.ButtonArea, 2);
            this.ButtonArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonArea.Controls.Add(this.CloseButton, 0, 0);
            this.ButtonArea.Controls.Add(this.AddButton, 1, 0);
            this.ButtonArea.Controls.Add(this.AddAndCloseButton, 2, 0);
            this.ButtonArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonArea.Location = new System.Drawing.Point(155, 236);
            this.ButtonArea.Name = "ButtonArea";
            this.ButtonArea.RowCount = 1;
            this.ButtonArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.ButtonArea.Size = new System.Drawing.Size(300, 36);
            this.ButtonArea.TabIndex = 7;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Gray;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(3, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(94, 30);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.TabStop = false;
            this.CloseButton.Text = "&Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Gray;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(103, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 30);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "&Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddAndCloseButton
            // 
            this.AddAndCloseButton.BackColor = System.Drawing.Color.Gray;
            this.AddAndCloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddAndCloseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddAndCloseButton.FlatAppearance.BorderSize = 0;
            this.AddAndCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAndCloseButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAndCloseButton.Location = new System.Drawing.Point(203, 3);
            this.AddAndCloseButton.Name = "AddAndCloseButton";
            this.AddAndCloseButton.Size = new System.Drawing.Size(94, 30);
            this.AddAndCloseButton.TabIndex = 6;
            this.AddAndCloseButton.Text = "A&dd and Close";
            this.AddAndCloseButton.UseVisualStyleBackColor = false;
            this.AddAndCloseButton.Click += new System.EventHandler(this.AddAndCloseButton_Click);
            // 
            // CustomUnitNameInput
            // 
            this.CustomUnitNameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomUnitNameInput.BackColor = System.Drawing.Color.Gray;
            this.CustomUnitNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomUnitNameInput.ForeColor = System.Drawing.SystemColors.Window;
            this.CustomUnitNameInput.Location = new System.Drawing.Point(307, 6);
            this.CustomUnitNameInput.Name = "CustomUnitNameInput";
            this.CustomUnitNameInput.Size = new System.Drawing.Size(148, 20);
            this.CustomUnitNameInput.TabIndex = 1;
            // 
            // GradientInput
            // 
            this.GradientInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GradientInput.BackColor = System.Drawing.Color.Gray;
            this.GradientInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GradientInput.ForeColor = System.Drawing.SystemColors.Window;
            this.GradientInput.Location = new System.Drawing.Point(307, 140);
            this.GradientInput.Name = "GradientInput";
            this.GradientInput.Size = new System.Drawing.Size(148, 20);
            this.GradientInput.TabIndex = 3;
            // 
            // InterceptInput
            // 
            this.InterceptInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InterceptInput.BackColor = System.Drawing.Color.Gray;
            this.InterceptInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InterceptInput.ForeColor = System.Drawing.SystemColors.Window;
            this.InterceptInput.Location = new System.Drawing.Point(307, 173);
            this.InterceptInput.Name = "InterceptInput";
            this.InterceptInput.Size = new System.Drawing.Size(148, 20);
            this.InterceptInput.TabIndex = 4;
            // 
            // BasedOnUnitDropDown
            // 
            this.BasedOnUnitDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BasedOnUnitDropDown.BackColor = System.Drawing.Color.Gray;
            this.BasedOnUnitDropDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BasedOnUnitDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BasedOnUnitDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BasedOnUnitDropDown.ForeColor = System.Drawing.SystemColors.Window;
            this.BasedOnUnitDropDown.FormattingEnabled = true;
            this.BasedOnUnitDropDown.Location = new System.Drawing.Point(307, 39);
            this.BasedOnUnitDropDown.Name = "BasedOnUnitDropDown";
            this.BasedOnUnitDropDown.Size = new System.Drawing.Size(148, 21);
            this.BasedOnUnitDropDown.TabIndex = 2;
            // 
            // AddNewUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(464, 281);
            this.ControlBox = false;
            this.Controls.Add(this.GlobalArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewUnit";
            this.Text = "Add Custom Unit";
            this.GlobalArea.ResumeLayout(false);
            this.MainArea.ResumeLayout(false);
            this.MainArea.PerformLayout();
            this.ButtonArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel GlobalArea;
        private System.Windows.Forms.TableLayoutPanel MainArea;
        private System.Windows.Forms.ListBox QuantityPicker;
        private System.Windows.Forms.Label CustomUnitNameLabel;
        private System.Windows.Forms.Label BasedOnUnitLabel;
        private System.Windows.Forms.Label GradientLabel;
        private System.Windows.Forms.Label InterceptLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label FootnoteLabel;
        private System.Windows.Forms.TableLayoutPanel ButtonArea;
        private System.Windows.Forms.TextBox CustomUnitNameInput;
        private System.Windows.Forms.TextBox GradientInput;
        private System.Windows.Forms.TextBox InterceptInput;
        private System.Windows.Forms.ComboBox BasedOnUnitDropDown;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button AddAndCloseButton;
    }
}