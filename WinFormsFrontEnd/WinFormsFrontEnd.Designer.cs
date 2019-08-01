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
            this.MainBoxMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keepWindowFloatingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separatorToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
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
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.GlobalArea = new System.Windows.Forms.TableLayoutPanel();
            this.MainArea.SuspendLayout();
            this.MainBoxMenuStrip.SuspendLayout();
            this.StatusBar.SuspendLayout();
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
            this.SwapButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SwapButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwapButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SwapButton.FlatAppearance.BorderSize = 0;
            this.SwapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SwapButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwapButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SwapButton.Location = new System.Drawing.Point(308, 122);
            this.SwapButton.Margin = new System.Windows.Forms.Padding(4);
            this.SwapButton.Name = "SwapButton";
            this.SwapButton.Size = new System.Drawing.Size(146, 23);
            this.SwapButton.TabIndex = 6;
            this.SwapButton.Text = "&Swap";
            this.SwapButton.UseVisualStyleBackColor = false;
            this.SwapButton.Click += new System.EventHandler(this.SwapButton_Click);
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
            this.QuantityPicker.Size = new System.Drawing.Size(146, 143);
            this.QuantityPicker.TabIndex = 0;
            this.QuantityPicker.SelectedIndexChanged += new System.EventHandler(this.QuantityPicker_SelectedIndexChanged);
            // 
            // FromUnitPicker
            // 
            this.FromUnitPicker.BackColor = System.Drawing.Color.Gray;
            this.FromUnitPicker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FromUnitPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FromUnitPicker.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FromUnitPicker.FormattingEnabled = true;
            this.FromUnitPicker.Location = new System.Drawing.Point(155, 3);
            this.FromUnitPicker.Name = "FromUnitPicker";
            this.FromUnitPicker.Size = new System.Drawing.Size(146, 83);
            this.FromUnitPicker.Sorted = true;
            this.FromUnitPicker.TabIndex = 1;
            this.FromUnitPicker.SelectedIndexChanged += new System.EventHandler(this.FromUnitPicker_SelectedIndexChanged);
            // 
            // ToUnitPicker
            // 
            this.ToUnitPicker.BackColor = System.Drawing.Color.Gray;
            this.ToUnitPicker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ToUnitPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToUnitPicker.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToUnitPicker.FormattingEnabled = true;
            this.ToUnitPicker.Location = new System.Drawing.Point(307, 3);
            this.ToUnitPicker.Name = "ToUnitPicker";
            this.ToUnitPicker.Size = new System.Drawing.Size(148, 83);
            this.ToUnitPicker.Sorted = true;
            this.ToUnitPicker.TabIndex = 2;
            this.ToUnitPicker.SelectedIndexChanged += new System.EventHandler(this.ToUnitPicker_SelectedIndexChanged);
            // 
            // InputBox
            // 
            this.InputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InputBox.Location = new System.Drawing.Point(155, 93);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(146, 21);
            this.InputBox.TabIndex = 3;
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // OutputBox
            // 
            this.OutputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OutputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OutputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputBox.ForeColor = System.Drawing.SystemColors.Window;
            this.OutputBox.Location = new System.Drawing.Point(307, 93);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(148, 21);
            this.OutputBox.TabIndex = 4;
            this.OutputBox.TabStop = false;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClearButton.Location = new System.Drawing.Point(156, 122);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(144, 23);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "&Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // MainBoxMenuStrip
            // 
            this.MainBoxMenuStrip.BackColor = System.Drawing.SystemColors.MenuBar;
            this.MainBoxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MainBoxMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainBoxMenuStrip.Name = "MainBoxMenuStrip";
            this.MainBoxMenuStrip.Size = new System.Drawing.Size(464, 24);
            this.MainBoxMenuStrip.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuBar;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUnitToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // addNewUnitToolStripMenuItem
            // 
            this.addNewUnitToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.addNewUnitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addNewUnitToolStripMenuItem.Name = "addNewUnitToolStripMenuItem";
            this.addNewUnitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addNewUnitToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.addNewUnitToolStripMenuItem.Text = "Add &New Custom Unit...";
            this.addNewUnitToolStripMenuItem.Click += new System.EventHandler(this.addNewUnitToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.deleteToolStripMenuItem.Text = "&Delete Custom Unit";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuBar;
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keepWindowFloatingToolStripMenuItem,
            this.separatorToolStripMenuItem,
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
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // keepWindowFloatingToolStripMenuItem
            // 
            this.keepWindowFloatingToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.keepWindowFloatingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.keepWindowFloatingToolStripMenuItem.Name = "keepWindowFloatingToolStripMenuItem";
            this.keepWindowFloatingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.keepWindowFloatingToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.keepWindowFloatingToolStripMenuItem.Text = "Keep &Window Floating";
            this.keepWindowFloatingToolStripMenuItem.Click += new System.EventHandler(this.keepWindowFloatingToolStripMenuItem_Click);
            // 
            // separatorToolStripMenuItem
            // 
            this.separatorToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.separatorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.separatorToolStripMenuItem.Name = "separatorToolStripMenuItem";
            this.separatorToolStripMenuItem.Size = new System.Drawing.Size(231, 6);
            // 
            // noRoundingOffToolStripMenuItem
            // 
            this.noRoundingOffToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.noRoundingOffToolStripMenuItem.Checked = true;
            this.noRoundingOffToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.noRoundingOffToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.noRoundingOffToolStripMenuItem.Name = "noRoundingOffToolStripMenuItem";
            this.noRoundingOffToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.N)));
            this.noRoundingOffToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.noRoundingOffToolStripMenuItem.Text = "&No Rounding Off";
            this.noRoundingOffToolStripMenuItem.Click += new System.EventHandler(this.noRoundingOffToolStripMenuItem_Click);
            // 
            // wholeNumberToolStripMenuItem
            // 
            this.wholeNumberToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.wholeNumberToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.wholeNumberToolStripMenuItem.Name = "wholeNumberToolStripMenuItem";
            this.wholeNumberToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.W)));
            this.wholeNumberToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.wholeNumberToolStripMenuItem.Text = "&Whole Number";
            this.wholeNumberToolStripMenuItem.Click += new System.EventHandler(this.wholeNumberToolStripMenuItem_Click);
            // 
            // decimalPlacesToolStripMenuItem1
            // 
            this.decimalPlacesToolStripMenuItem1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.decimalPlacesToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.decimalPlacesToolStripMenuItem1.Name = "decimalPlacesToolStripMenuItem1";
            this.decimalPlacesToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D1)));
            this.decimalPlacesToolStripMenuItem1.Size = new System.Drawing.Size(234, 22);
            this.decimalPlacesToolStripMenuItem1.Text = "&1 Decimal Place";
            this.decimalPlacesToolStripMenuItem1.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem1_Click);
            // 
            // decimalPlacesToolStripMenuItem2
            // 
            this.decimalPlacesToolStripMenuItem2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.decimalPlacesToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.decimalPlacesToolStripMenuItem2.Name = "decimalPlacesToolStripMenuItem2";
            this.decimalPlacesToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D2)));
            this.decimalPlacesToolStripMenuItem2.Size = new System.Drawing.Size(234, 22);
            this.decimalPlacesToolStripMenuItem2.Text = "&2 Decimal Places";
            this.decimalPlacesToolStripMenuItem2.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem2_Click);
            // 
            // decimalPlacesToolStripMenuItem3
            // 
            this.decimalPlacesToolStripMenuItem3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.decimalPlacesToolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.decimalPlacesToolStripMenuItem3.Name = "decimalPlacesToolStripMenuItem3";
            this.decimalPlacesToolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D3)));
            this.decimalPlacesToolStripMenuItem3.Size = new System.Drawing.Size(234, 22);
            this.decimalPlacesToolStripMenuItem3.Text = "&3 Decimal Places";
            this.decimalPlacesToolStripMenuItem3.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem3_Click);
            // 
            // decimalPlacesToolStripMenuItem4
            // 
            this.decimalPlacesToolStripMenuItem4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.decimalPlacesToolStripMenuItem4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.decimalPlacesToolStripMenuItem4.Name = "decimalPlacesToolStripMenuItem4";
            this.decimalPlacesToolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D4)));
            this.decimalPlacesToolStripMenuItem4.Size = new System.Drawing.Size(234, 22);
            this.decimalPlacesToolStripMenuItem4.Text = "&4 Decimal Places";
            this.decimalPlacesToolStripMenuItem4.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem4_Click);
            // 
            // decimalPlacesToolStripMenuItem5
            // 
            this.decimalPlacesToolStripMenuItem5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.decimalPlacesToolStripMenuItem5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.decimalPlacesToolStripMenuItem5.Name = "decimalPlacesToolStripMenuItem5";
            this.decimalPlacesToolStripMenuItem5.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D5)));
            this.decimalPlacesToolStripMenuItem5.Size = new System.Drawing.Size(234, 22);
            this.decimalPlacesToolStripMenuItem5.Text = "&5 Decimal Places";
            this.decimalPlacesToolStripMenuItem5.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem5_Click);
            // 
            // decimalPlacesToolStripMenuItem6
            // 
            this.decimalPlacesToolStripMenuItem6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.decimalPlacesToolStripMenuItem6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.decimalPlacesToolStripMenuItem6.Name = "decimalPlacesToolStripMenuItem6";
            this.decimalPlacesToolStripMenuItem6.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D6)));
            this.decimalPlacesToolStripMenuItem6.Size = new System.Drawing.Size(234, 22);
            this.decimalPlacesToolStripMenuItem6.Text = "&6 Decimal Places";
            this.decimalPlacesToolStripMenuItem6.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem6_Click);
            // 
            // decimalPlacesToolStripMenuItem7
            // 
            this.decimalPlacesToolStripMenuItem7.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.decimalPlacesToolStripMenuItem7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.decimalPlacesToolStripMenuItem7.Name = "decimalPlacesToolStripMenuItem7";
            this.decimalPlacesToolStripMenuItem7.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D7)));
            this.decimalPlacesToolStripMenuItem7.Size = new System.Drawing.Size(234, 22);
            this.decimalPlacesToolStripMenuItem7.Text = "&7 Decimal Places";
            this.decimalPlacesToolStripMenuItem7.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem7_Click);
            // 
            // decimalPlacesToolStripMenuItem8
            // 
            this.decimalPlacesToolStripMenuItem8.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.decimalPlacesToolStripMenuItem8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.decimalPlacesToolStripMenuItem8.Name = "decimalPlacesToolStripMenuItem8";
            this.decimalPlacesToolStripMenuItem8.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D8)));
            this.decimalPlacesToolStripMenuItem8.Size = new System.Drawing.Size(234, 22);
            this.decimalPlacesToolStripMenuItem8.Text = "&8 Decimal Places";
            this.decimalPlacesToolStripMenuItem8.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem8_Click);
            // 
            // decimalPlacesToolStripMenuItem9
            // 
            this.decimalPlacesToolStripMenuItem9.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.decimalPlacesToolStripMenuItem9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.decimalPlacesToolStripMenuItem9.Name = "decimalPlacesToolStripMenuItem9";
            this.decimalPlacesToolStripMenuItem9.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D9)));
            this.decimalPlacesToolStripMenuItem9.Size = new System.Drawing.Size(234, 22);
            this.decimalPlacesToolStripMenuItem9.Text = "&9 Decimal Places";
            this.decimalPlacesToolStripMenuItem9.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem9_Click);
            // 
            // decimalPlacesToolStripMenuItem10
            // 
            this.decimalPlacesToolStripMenuItem10.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.decimalPlacesToolStripMenuItem10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.decimalPlacesToolStripMenuItem10.Name = "decimalPlacesToolStripMenuItem10";
            this.decimalPlacesToolStripMenuItem10.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.O)));
            this.decimalPlacesToolStripMenuItem10.Size = new System.Drawing.Size(234, 22);
            this.decimalPlacesToolStripMenuItem10.Text = "1&0 Decimal Places";
            this.decimalPlacesToolStripMenuItem10.Click += new System.EventHandler(this.decimalPlacesToolStripMenuItem10_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuBar;
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUnitConverterToolStripMenuItem});
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // aboutUnitConverterToolStripMenuItem
            // 
            this.aboutUnitConverterToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.aboutUnitConverterToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.aboutUnitConverterToolStripMenuItem.Name = "aboutUnitConverterToolStripMenuItem";
            this.aboutUnitConverterToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutUnitConverterToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.aboutUnitConverterToolStripMenuItem.Text = "&About Unit Converter";
            this.aboutUnitConverterToolStripMenuItem.Click += new System.EventHandler(this.aboutUnitConverterToolStripMenuItem_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.BackColor = System.Drawing.Color.Transparent;
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.StatusBar.Location = new System.Drawing.Point(0, 179);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(464, 22);
            this.StatusBar.TabIndex = 2;
            this.StatusBar.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(88, 17);
            this.StatusLabel.Text = "Status Message";
            // 
            // GlobalArea
            // 
            this.GlobalArea.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.GlobalArea.ColumnCount = 1;
            this.GlobalArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalArea.Controls.Add(this.MainArea, 0, 0);
            this.GlobalArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalArea.ForeColor = System.Drawing.SystemColors.Window;
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
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(464, 201);
            this.Controls.Add(this.GlobalArea);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.MainBoxMenuStrip);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainMenuStrip = this.MainBoxMenuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 400);
            this.MinimumSize = new System.Drawing.Size(480, 240);
            this.Name = "WinFormsFrontEnd";
            this.Text = "Unit Converter";
            this.MainArea.ResumeLayout(false);
            this.MainArea.PerformLayout();
            this.MainBoxMenuStrip.ResumeLayout(false);
            this.MainBoxMenuStrip.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
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
        private System.Windows.Forms.MenuStrip MainBoxMenuStrip;
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
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.TableLayoutPanel GlobalArea;
        private System.Windows.Forms.ToolStripMenuItem addNewUnitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keepWindowFloatingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator separatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
    }
}

