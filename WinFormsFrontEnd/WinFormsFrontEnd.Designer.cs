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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noRoundingOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wholeNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalPlacesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalPlacesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalPlacesToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalPlacesToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalPlacesToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalPlacesToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalPlacesToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalPlacesToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalPlacesToolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalPlacesToolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUnitConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.GlobalArea = new System.Windows.Forms.TableLayoutPanel();
            this.MainArea.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.GlobalArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainArea
            // 
            this.MainArea.ColumnCount = 3;
            this.MainArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
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
            this.MainArea.Location = new System.Drawing.Point(3, 3);
            this.MainArea.Name = "MainArea";
            this.MainArea.RowCount = 3;
            this.MainArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.MainArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainArea.Size = new System.Drawing.Size(458, 149);
            this.MainArea.TabIndex = 0;
            // 
            // SwapButton
            // 
            this.SwapButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SwapButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwapButton.Location = new System.Drawing.Point(307, 121);
            this.SwapButton.Name = "SwapButton";
            this.SwapButton.Size = new System.Drawing.Size(148, 25);
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
            this.QuantityPicker.Size = new System.Drawing.Size(146, 143);
            this.QuantityPicker.TabIndex = 0;
            this.QuantityPicker.SelectedIndexChanged += new System.EventHandler(this.QuantityPicker_SelectedIndexChanged);
            // 
            // FromUnitPicker
            // 
            this.FromUnitPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FromUnitPicker.FormattingEnabled = true;
            this.FromUnitPicker.Location = new System.Drawing.Point(155, 3);
            this.FromUnitPicker.Name = "FromUnitPicker";
            this.FromUnitPicker.Size = new System.Drawing.Size(146, 83);
            this.FromUnitPicker.TabIndex = 1;
            this.FromUnitPicker.SelectedIndexChanged += new System.EventHandler(this.FromUnitPicker_SelectedIndexChanged);
            // 
            // ToUnitPicker
            // 
            this.ToUnitPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToUnitPicker.FormattingEnabled = true;
            this.ToUnitPicker.Location = new System.Drawing.Point(307, 3);
            this.ToUnitPicker.Name = "ToUnitPicker";
            this.ToUnitPicker.Size = new System.Drawing.Size(148, 83);
            this.ToUnitPicker.TabIndex = 2;
            this.ToUnitPicker.SelectedIndexChanged += new System.EventHandler(this.ToUnitPicker_SelectedIndexChanged);
            // 
            // InputBox
            // 
            this.InputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputBox.Location = new System.Drawing.Point(155, 93);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(146, 21);
            this.InputBox.TabIndex = 3;
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // OutputBox
            // 
            this.OutputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputBox.Location = new System.Drawing.Point(307, 93);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(148, 21);
            this.OutputBox.TabIndex = 4;
            // 
            // ClearButton
            // 
            this.ClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(155, 121);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(146, 25);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "&Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(464, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noRoundingOffToolStripMenuItem,
            this.wholeNumberToolStripMenuItem,
            this.decimalPlacesToolStripMenuItem1,
            this.decimalPlacesToolStripMenuItem2,
            this.decimalPlacesToolStripMenuItem3,
            this.decimalPlacesToolStripMenuItem4,
            this.decimalPlacesToolStripMenuItem5,
            this.decimalPlacesToolStripMenuItem6,
            this.decimalPlacesToolStripMenuItem7,
            this.decimalPlacesToolStripMenuItem8,
            this.decimalPlacesToolStripMenuItem9,
            this.decimalPlacesToolStripMenuItem10});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // noRoundingOffToolStripMenuItem
            // 
            this.noRoundingOffToolStripMenuItem.Checked = true;
            this.noRoundingOffToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.noRoundingOffToolStripMenuItem.Name = "noRoundingOffToolStripMenuItem";
            this.noRoundingOffToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.N)));
            this.noRoundingOffToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.noRoundingOffToolStripMenuItem.Text = "&No Rounding Off";
            this.noRoundingOffToolStripMenuItem.Click += new System.EventHandler(this.noRoundingOffToolStripMenuItem_Click);
            // 
            // wholeNumberToolStripMenuItem
            // 
            this.wholeNumberToolStripMenuItem.Name = "wholeNumberToolStripMenuItem";
            this.wholeNumberToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.W)));
            this.wholeNumberToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.wholeNumberToolStripMenuItem.Text = "&Whole Number";
            this.wholeNumberToolStripMenuItem.Click += new System.EventHandler(this.wholeNumberToolStripMenuItem_Click);
            // 
            // decimalPlacesToolStripMenuItem1
            // 
            this.decimalPlacesToolStripMenuItem1.Name = "decimalPlacesToolStripMenuItem1";
            this.decimalPlacesToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D1)));
            this.decimalPlacesToolStripMenuItem1.Size = new System.Drawing.Size(234, 22);
            this.decimalPlacesToolStripMenuItem1.Text = "&1 Decimal Place";
            this.decimalPlacesToolStripMenuItem1.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem1_Click);
            // 
            // decimalPlacesToolStripMenuItem2
            // 
            this.decimalPlacesToolStripMenuItem2.Name = "decimalPlacesToolStripMenuItem2";
            this.decimalPlacesToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D2)));
            this.decimalPlacesToolStripMenuItem2.Size = new System.Drawing.Size(234, 22);
            this.decimalPlacesToolStripMenuItem2.Text = "&2 Decimal Places";
            this.decimalPlacesToolStripMenuItem2.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem2_Click);
            // 
            // decimalPlacesToolStripMenuItem3
            // 
            this.decimalPlacesToolStripMenuItem3.Name = "decimalPlacesToolStripMenuItem3";
            this.decimalPlacesToolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D3)));
            this.decimalPlacesToolStripMenuItem3.Size = new System.Drawing.Size(234, 22);
            this.decimalPlacesToolStripMenuItem3.Text = "&3 Decimal Places";
            this.decimalPlacesToolStripMenuItem3.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem3_Click);
            // 
            // decimalPlacesToolStripMenuItem4
            // 
            this.decimalPlacesToolStripMenuItem4.Name = "decimalPlacesToolStripMenuItem4";
            this.decimalPlacesToolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D4)));
            this.decimalPlacesToolStripMenuItem4.Size = new System.Drawing.Size(234, 22);
            this.decimalPlacesToolStripMenuItem4.Text = "&4 Decimal Places";
            this.decimalPlacesToolStripMenuItem4.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem4_Click);
            // 
            // decimalPlacesToolStripMenuItem5
            // 
            this.decimalPlacesToolStripMenuItem5.Name = "decimalPlacesToolStripMenuItem5";
            this.decimalPlacesToolStripMenuItem5.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D5)));
            this.decimalPlacesToolStripMenuItem5.Size = new System.Drawing.Size(234, 22);
            this.decimalPlacesToolStripMenuItem5.Text = "&5 Decimal Places";
            this.decimalPlacesToolStripMenuItem5.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem5_Click);
            // 
            // decimalPlacesToolStripMenuItem6
            // 
            this.decimalPlacesToolStripMenuItem6.Name = "decimalPlacesToolStripMenuItem6";
            this.decimalPlacesToolStripMenuItem6.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D6)));
            this.decimalPlacesToolStripMenuItem6.Size = new System.Drawing.Size(234, 22);
            this.decimalPlacesToolStripMenuItem6.Text = "&6 Decimal Places";
            this.decimalPlacesToolStripMenuItem6.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem6_Click);
            // 
            // decimalPlacesToolStripMenuItem7
            // 
            this.decimalPlacesToolStripMenuItem7.Name = "decimalPlacesToolStripMenuItem7";
            this.decimalPlacesToolStripMenuItem7.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D7)));
            this.decimalPlacesToolStripMenuItem7.Size = new System.Drawing.Size(234, 22);
            this.decimalPlacesToolStripMenuItem7.Text = "&7 Decimal Places";
            this.decimalPlacesToolStripMenuItem7.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem7_Click);
            // 
            // decimalPlacesToolStripMenuItem8
            // 
            this.decimalPlacesToolStripMenuItem8.Name = "decimalPlacesToolStripMenuItem8";
            this.decimalPlacesToolStripMenuItem8.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D8)));
            this.decimalPlacesToolStripMenuItem8.Size = new System.Drawing.Size(234, 22);
            this.decimalPlacesToolStripMenuItem8.Text = "&8 Decimal Places";
            this.decimalPlacesToolStripMenuItem8.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem8_Click);
            // 
            // decimalPlacesToolStripMenuItem9
            // 
            this.decimalPlacesToolStripMenuItem9.Name = "decimalPlacesToolStripMenuItem9";
            this.decimalPlacesToolStripMenuItem9.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D9)));
            this.decimalPlacesToolStripMenuItem9.Size = new System.Drawing.Size(234, 22);
            this.decimalPlacesToolStripMenuItem9.Text = "&9 Decimal Places";
            this.decimalPlacesToolStripMenuItem9.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem9_Click);
            // 
            // decimalPlacesToolStripMenuItem10
            // 
            this.decimalPlacesToolStripMenuItem10.Name = "decimalPlacesToolStripMenuItem10";
            this.decimalPlacesToolStripMenuItem10.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.O)));
            this.decimalPlacesToolStripMenuItem10.Size = new System.Drawing.Size(234, 22);
            this.decimalPlacesToolStripMenuItem10.Text = "1&0 Decimal Places";
            this.decimalPlacesToolStripMenuItem10.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem10_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUnitConverterToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // aboutUnitConverterToolStripMenuItem
            // 
            this.aboutUnitConverterToolStripMenuItem.Name = "aboutUnitConverterToolStripMenuItem";
            this.aboutUnitConverterToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.aboutUnitConverterToolStripMenuItem.Text = "&About Unit Converter";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 179);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(464, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // GlobalArea
            // 
            this.GlobalArea.ColumnCount = 1;
            this.GlobalArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalArea.Controls.Add(this.MainArea, 0, 0);
            this.GlobalArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalArea.Location = new System.Drawing.Point(0, 24);
            this.GlobalArea.Name = "GlobalArea";
            this.GlobalArea.RowCount = 1;
            this.GlobalArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GlobalArea.Size = new System.Drawing.Size(464, 155);
            this.GlobalArea.TabIndex = 3;
            // 
            // WinFormsFrontEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 201);
            this.Controls.Add(this.GlobalArea);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WinFormsFrontEnd";
            this.Text = "Unit Converter";
            this.MainArea.ResumeLayout(false);
            this.MainArea.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GlobalArea.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noRoundingOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wholeNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decimalPlacesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem decimalPlacesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem decimalPlacesToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem decimalPlacesToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem decimalPlacesToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem decimalPlacesToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem decimalPlacesToolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem decimalPlacesToolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem decimalPlacesToolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem decimalPlacesToolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUnitConverterToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TableLayoutPanel GlobalArea;
    }
}

