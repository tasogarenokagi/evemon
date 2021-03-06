using EVEMon.Common.Controls;

namespace EVEMon.ImplantControls
{
    sealed partial class ImplantSetsWindow
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbSlot10 = new EVEMon.Common.Controls.DropDownMouseMoveComboBox();
            this.cbSlot9 = new EVEMon.Common.Controls.DropDownMouseMoveComboBox();
            this.cbSlot8 = new EVEMon.Common.Controls.DropDownMouseMoveComboBox();
            this.cbSlot7 = new EVEMon.Common.Controls.DropDownMouseMoveComboBox();
            this.cbSlot6 = new EVEMon.Common.Controls.DropDownMouseMoveComboBox();
            this.cbSlot5 = new EVEMon.Common.Controls.DropDownMouseMoveComboBox();
            this.cbSlot4 = new EVEMon.Common.Controls.DropDownMouseMoveComboBox();
            this.cbSlot3 = new EVEMon.Common.Controls.DropDownMouseMoveComboBox();
            this.cbSlot2 = new EVEMon.Common.Controls.DropDownMouseMoveComboBox();
            this.cbSlot1 = new EVEMon.Common.Controls.DropDownMouseMoveComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblImplant2 = new System.Windows.Forms.Label();
            this.lblImplant1 = new System.Windows.Forms.Label();
            this.setsGrid = new EVEMon.Common.Controls.IntuitiveDataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImplantSetsLabel = new System.Windows.Forms.Label();
            this.ImplantsLabel = new System.Windows.Forms.Label();
            this.deleteRowInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.setsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerLabel.AutoSize = true;
            this.headerLabel.Location = new System.Drawing.Point(14, 198);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(377, 13);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "{0} has the skill for {1} Jump Clones (plus 1 for the implants in your active bod" +
    "y)";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(459, 533);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(378, 533);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbSlot10
            // 
            this.cbSlot10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSlot10.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbSlot10.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSlot10.DropDownHeight = 1;
            this.cbSlot10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSlot10.FormattingEnabled = true;
            this.cbSlot10.IntegralHeight = false;
            this.cbSlot10.Location = new System.Drawing.Point(69, 501);
            this.cbSlot10.Name = "cbSlot10";
            this.cbSlot10.Size = new System.Drawing.Size(464, 21);
            this.cbSlot10.TabIndex = 29;
            this.cbSlot10.ToolTip = null;
            this.cbSlot10.DropDownClosed += new System.EventHandler(this.cbSlotN_DropDownClosed);
            // 
            // cbSlot9
            // 
            this.cbSlot9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSlot9.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbSlot9.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSlot9.DropDownHeight = 1;
            this.cbSlot9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSlot9.FormattingEnabled = true;
            this.cbSlot9.IntegralHeight = false;
            this.cbSlot9.Location = new System.Drawing.Point(69, 474);
            this.cbSlot9.Name = "cbSlot9";
            this.cbSlot9.Size = new System.Drawing.Size(464, 21);
            this.cbSlot9.TabIndex = 28;
            this.cbSlot9.ToolTip = null;
            this.cbSlot9.DropDownClosed += new System.EventHandler(this.cbSlotN_DropDownClosed);
            // 
            // cbSlot8
            // 
            this.cbSlot8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSlot8.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbSlot8.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSlot8.DropDownHeight = 1;
            this.cbSlot8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSlot8.FormattingEnabled = true;
            this.cbSlot8.IntegralHeight = false;
            this.cbSlot8.Location = new System.Drawing.Point(70, 447);
            this.cbSlot8.Name = "cbSlot8";
            this.cbSlot8.Size = new System.Drawing.Size(464, 21);
            this.cbSlot8.TabIndex = 27;
            this.cbSlot8.ToolTip = null;
            this.cbSlot8.DropDownClosed += new System.EventHandler(this.cbSlotN_DropDownClosed);
            // 
            // cbSlot7
            // 
            this.cbSlot7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSlot7.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbSlot7.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSlot7.DropDownHeight = 1;
            this.cbSlot7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSlot7.FormattingEnabled = true;
            this.cbSlot7.IntegralHeight = false;
            this.cbSlot7.Location = new System.Drawing.Point(69, 420);
            this.cbSlot7.Name = "cbSlot7";
            this.cbSlot7.Size = new System.Drawing.Size(464, 21);
            this.cbSlot7.TabIndex = 26;
            this.cbSlot7.ToolTip = null;
            this.cbSlot7.DropDownClosed += new System.EventHandler(this.cbSlotN_DropDownClosed);
            // 
            // cbSlot6
            // 
            this.cbSlot6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSlot6.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbSlot6.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSlot6.DropDownHeight = 1;
            this.cbSlot6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSlot6.FormattingEnabled = true;
            this.cbSlot6.IntegralHeight = false;
            this.cbSlot6.Location = new System.Drawing.Point(70, 393);
            this.cbSlot6.Name = "cbSlot6";
            this.cbSlot6.Size = new System.Drawing.Size(464, 21);
            this.cbSlot6.TabIndex = 25;
            this.cbSlot6.ToolTip = null;
            this.cbSlot6.DropDownClosed += new System.EventHandler(this.cbSlotN_DropDownClosed);
            // 
            // cbSlot5
            // 
            this.cbSlot5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSlot5.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbSlot5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSlot5.DropDownHeight = 1;
            this.cbSlot5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSlot5.FormattingEnabled = true;
            this.cbSlot5.IntegralHeight = false;
            this.cbSlot5.Location = new System.Drawing.Point(70, 366);
            this.cbSlot5.Name = "cbSlot5";
            this.cbSlot5.Size = new System.Drawing.Size(464, 21);
            this.cbSlot5.TabIndex = 24;
            this.cbSlot5.ToolTip = null;
            this.cbSlot5.DropDownClosed += new System.EventHandler(this.cbSlotN_DropDownClosed);
            // 
            // cbSlot4
            // 
            this.cbSlot4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSlot4.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbSlot4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSlot4.DropDownHeight = 1;
            this.cbSlot4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSlot4.FormattingEnabled = true;
            this.cbSlot4.IntegralHeight = false;
            this.cbSlot4.Location = new System.Drawing.Point(70, 339);
            this.cbSlot4.Name = "cbSlot4";
            this.cbSlot4.Size = new System.Drawing.Size(464, 21);
            this.cbSlot4.TabIndex = 23;
            this.cbSlot4.ToolTip = null;
            this.cbSlot4.DropDownClosed += new System.EventHandler(this.cbSlotN_DropDownClosed);
            // 
            // cbSlot3
            // 
            this.cbSlot3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSlot3.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbSlot3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSlot3.DropDownHeight = 1;
            this.cbSlot3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSlot3.FormattingEnabled = true;
            this.cbSlot3.IntegralHeight = false;
            this.cbSlot3.Location = new System.Drawing.Point(70, 312);
            this.cbSlot3.Name = "cbSlot3";
            this.cbSlot3.Size = new System.Drawing.Size(464, 21);
            this.cbSlot3.TabIndex = 22;
            this.cbSlot3.ToolTip = null;
            this.cbSlot3.DropDownClosed += new System.EventHandler(this.cbSlotN_DropDownClosed);
            // 
            // cbSlot2
            // 
            this.cbSlot2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSlot2.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbSlot2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSlot2.DropDownHeight = 1;
            this.cbSlot2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSlot2.FormattingEnabled = true;
            this.cbSlot2.IntegralHeight = false;
            this.cbSlot2.Location = new System.Drawing.Point(70, 285);
            this.cbSlot2.Name = "cbSlot2";
            this.cbSlot2.Size = new System.Drawing.Size(464, 21);
            this.cbSlot2.TabIndex = 21;
            this.cbSlot2.ToolTip = null;
            this.cbSlot2.DropDownClosed += new System.EventHandler(this.cbSlotN_DropDownClosed);
            // 
            // cbSlot1
            // 
            this.cbSlot1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSlot1.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbSlot1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSlot1.DropDownHeight = 1;
            this.cbSlot1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSlot1.FormattingEnabled = true;
            this.cbSlot1.IntegralHeight = false;
            this.cbSlot1.Location = new System.Drawing.Point(70, 258);
            this.cbSlot1.Name = "cbSlot1";
            this.cbSlot1.Size = new System.Drawing.Size(464, 21);
            this.cbSlot1.TabIndex = 20;
            this.cbSlot1.ToolTip = null;
            this.cbSlot1.DropDownClosed += new System.EventHandler(this.cbSlotN_DropDownClosed);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 504);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Slot 10";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 477);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Slot 9";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 450);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Slot 8";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 423);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Slot 7";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 396);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Slot 6";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 369);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Slot 5";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 342);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Slot 4";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 315);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Slot 3";
            // 
            // lblImplant2
            // 
            this.lblImplant2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImplant2.AutoSize = true;
            this.lblImplant2.Location = new System.Drawing.Point(14, 288);
            this.lblImplant2.Name = "lblImplant2";
            this.lblImplant2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblImplant2.Size = new System.Drawing.Size(37, 13);
            this.lblImplant2.TabIndex = 11;
            this.lblImplant2.Text = "Slot 2";
            // 
            // lblImplant1
            // 
            this.lblImplant1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImplant1.AutoSize = true;
            this.lblImplant1.Location = new System.Drawing.Point(14, 262);
            this.lblImplant1.Name = "lblImplant1";
            this.lblImplant1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblImplant1.Size = new System.Drawing.Size(37, 13);
            this.lblImplant1.TabIndex = 10;
            this.lblImplant1.Text = "Slot 1";
            // 
            // setsGrid
            // 
            this.setsGrid.AllowUserToResizeColumns = false;
            this.setsGrid.AllowUserToResizeRows = false;
            this.setsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setsGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.setsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.setsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.setsGrid.ColumnHeadersVisible = false;
            this.setsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn});
            this.setsGrid.Location = new System.Drawing.Point(15, 35);
            this.setsGrid.MultiSelect = false;
            this.setsGrid.Name = "setsGrid";
            this.setsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.setsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.setsGrid.ShowEditingIcon = false;
            this.setsGrid.Size = new System.Drawing.Size(519, 131);
            this.setsGrid.TabIndex = 8;
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            // 
            // ImplantSetsLabel
            // 
            this.ImplantSetsLabel.AutoSize = true;
            this.ImplantSetsLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ImplantSetsLabel.Location = new System.Drawing.Point(13, 13);
            this.ImplantSetsLabel.Name = "ImplantSetsLabel";
            this.ImplantSetsLabel.Size = new System.Drawing.Size(68, 13);
            this.ImplantSetsLabel.TabIndex = 9;
            this.ImplantSetsLabel.Text = "Implants sets";
            // 
            // ImplantsLabel
            // 
            this.ImplantsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImplantsLabel.AutoSize = true;
            this.ImplantsLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ImplantsLabel.Location = new System.Drawing.Point(13, 227);
            this.ImplantsLabel.Name = "ImplantsLabel";
            this.ImplantsLabel.Size = new System.Drawing.Size(46, 13);
            this.ImplantsLabel.TabIndex = 10;
            this.ImplantsLabel.Text = "Implants";
            // 
            // deleteRowInfo
            // 
            this.deleteRowInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteRowInfo.AutoSize = true;
            this.deleteRowInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.deleteRowInfo.Location = new System.Drawing.Point(14, 169);
            this.deleteRowInfo.Name = "deleteRowInfo";
            this.deleteRowInfo.Size = new System.Drawing.Size(361, 13);
            this.deleteRowInfo.TabIndex = 30;
            this.deleteRowInfo.Text = "* to delete a custom set select it and press the \"Del\" key on your keyboard.";
            // 
            // ImplantSetsWindow
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(546, 568);
            this.Controls.Add(this.deleteRowInfo);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbSlot10);
            this.Controls.Add(this.ImplantsLabel);
            this.Controls.Add(this.cbSlot9);
            this.Controls.Add(this.ImplantSetsLabel);
            this.Controls.Add(this.cbSlot8);
            this.Controls.Add(this.setsGrid);
            this.Controls.Add(this.cbSlot7);
            this.Controls.Add(this.cbSlot6);
            this.Controls.Add(this.cbSlot5);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.cbSlot4);
            this.Controls.Add(this.lblImplant1);
            this.Controls.Add(this.cbSlot3);
            this.Controls.Add(this.lblImplant2);
            this.Controls.Add(this.cbSlot2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSlot1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ImplantSetsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "Jump Clone";
            this.Text = "Jump Clones";
            this.Load += new System.EventHandler(this.ImpGroups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.setsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblImplant1;
        private System.Windows.Forms.Label lblImplant2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DropDownMouseMoveComboBox cbSlot10;
        private DropDownMouseMoveComboBox cbSlot9;
        private DropDownMouseMoveComboBox cbSlot8;
        private DropDownMouseMoveComboBox cbSlot7;
        private DropDownMouseMoveComboBox cbSlot6;
        private DropDownMouseMoveComboBox cbSlot5;
        private DropDownMouseMoveComboBox cbSlot4;
        private DropDownMouseMoveComboBox cbSlot3;
        private DropDownMouseMoveComboBox cbSlot2;
        private DropDownMouseMoveComboBox cbSlot1;
        private IntuitiveDataGridView setsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.Label ImplantSetsLabel;
        private System.Windows.Forms.Label ImplantsLabel;
        private System.Windows.Forms.Label deleteRowInfo;
    }
}
