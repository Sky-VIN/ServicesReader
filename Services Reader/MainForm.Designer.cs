namespace ServicesReader
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.lvMain = new System.Windows.Forms.ListView();
            this.chDisplayName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chServiceName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStartupType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.miDeselectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.miSelectInvert = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miCheckAll = new System.Windows.Forms.ToolStripMenuItem();
            this.miUncheckAll = new System.Windows.Forms.ToolStripMenuItem();
            this.miInvertChecking = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.miCheckSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.miUncheckSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.miChkAutoDelayed = new System.Windows.Forms.ToolStripMenuItem();
            this.miChkAuto = new System.Windows.Forms.ToolStripMenuItem();
            this.miChkDisabled = new System.Windows.Forms.ToolStripMenuItem();
            this.miChkManual = new System.Windows.Forms.ToolStripMenuItem();
            this.miChkUnknown = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lServicesName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lServicesCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lAutomaticDelayedName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lAutomaticDelayedCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lAutomaticName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lAutomaticCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lManualName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lManualCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lDisabledName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lDisabledCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lUnknownName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lUnknownCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.chbDescription = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvMain
            // 
            this.lvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvMain.CheckBoxes = true;
            this.lvMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDisplayName,
            this.chServiceName,
            this.chStartupType,
            this.chDescription});
            this.lvMain.ContextMenuStrip = this.contextMenuStrip;
            this.lvMain.FullRowSelect = true;
            this.lvMain.Location = new System.Drawing.Point(12, 44);
            this.lvMain.Name = "lvMain";
            this.lvMain.Size = new System.Drawing.Size(760, 469);
            this.lvMain.TabIndex = 0;
            this.lvMain.UseCompatibleStateImageBehavior = false;
            this.lvMain.View = System.Windows.Forms.View.Details;
            this.lvMain.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvMain_ColumnClick);
            // 
            // chDisplayName
            // 
            this.chDisplayName.Text = "Display Name";
            this.chDisplayName.Width = 375;
            // 
            // chServiceName
            // 
            this.chServiceName.Text = "Service Name";
            this.chServiceName.Width = 250;
            // 
            // chStartupType
            // 
            this.chStartupType.Text = "Startup Type";
            this.chStartupType.Width = 100;
            // 
            // chDescription
            // 
            this.chDescription.Text = "Description";
            this.chDescription.Width = 0;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSelectAll,
            this.miDeselectAll,
            this.miSelectInvert,
            this.toolStripSeparator1,
            this.miCheckAll,
            this.miUncheckAll,
            this.miInvertChecking,
            this.toolStripSeparator2,
            this.miCheckSelected,
            this.miUncheckSelected,
            this.toolStripSeparator3,
            this.miChkAutoDelayed,
            this.miChkAuto,
            this.miChkDisabled,
            this.miChkManual,
            this.miChkUnknown});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(263, 308);
            // 
            // miSelectAll
            // 
            this.miSelectAll.Name = "miSelectAll";
            this.miSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.miSelectAll.Size = new System.Drawing.Size(262, 22);
            this.miSelectAll.Text = "Select All";
            this.miSelectAll.Click += new System.EventHandler(this.miSelectAll_Click);
            // 
            // miDeselectAll
            // 
            this.miDeselectAll.Name = "miDeselectAll";
            this.miDeselectAll.Size = new System.Drawing.Size(262, 22);
            this.miDeselectAll.Text = "Deselect All";
            this.miDeselectAll.Click += new System.EventHandler(this.miDeselectAll_Click);
            // 
            // miSelectInvert
            // 
            this.miSelectInvert.Name = "miSelectInvert";
            this.miSelectInvert.Size = new System.Drawing.Size(262, 22);
            this.miSelectInvert.Text = "Invert Selection";
            this.miSelectInvert.Click += new System.EventHandler(this.miSelectInvert_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(259, 6);
            // 
            // miCheckAll
            // 
            this.miCheckAll.Name = "miCheckAll";
            this.miCheckAll.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.miCheckAll.Size = new System.Drawing.Size(262, 22);
            this.miCheckAll.Text = "Check All";
            this.miCheckAll.Click += new System.EventHandler(this.miCheckAll_Click);
            // 
            // miUncheckAll
            // 
            this.miUncheckAll.Name = "miUncheckAll";
            this.miUncheckAll.Size = new System.Drawing.Size(262, 22);
            this.miUncheckAll.Text = "Uncheck All";
            this.miUncheckAll.Click += new System.EventHandler(this.miUncheckAll_Click);
            // 
            // miInvertChecking
            // 
            this.miInvertChecking.Name = "miInvertChecking";
            this.miInvertChecking.Size = new System.Drawing.Size(262, 22);
            this.miInvertChecking.Text = "Invert Checking";
            this.miInvertChecking.Click += new System.EventHandler(this.miInvertChecking_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(259, 6);
            // 
            // miCheckSelected
            // 
            this.miCheckSelected.Name = "miCheckSelected";
            this.miCheckSelected.Size = new System.Drawing.Size(262, 22);
            this.miCheckSelected.Text = "Check Selected";
            this.miCheckSelected.Click += new System.EventHandler(this.miCheckSelected_Click);
            // 
            // miUncheckSelected
            // 
            this.miUncheckSelected.Name = "miUncheckSelected";
            this.miUncheckSelected.Size = new System.Drawing.Size(262, 22);
            this.miUncheckSelected.Text = "Uncheck Selected";
            this.miUncheckSelected.Click += new System.EventHandler(this.miUncheckSelected_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(259, 6);
            // 
            // miChkAutoDelayed
            // 
            this.miChkAutoDelayed.Name = "miChkAutoDelayed";
            this.miChkAutoDelayed.Size = new System.Drawing.Size(262, 22);
            this.miChkAutoDelayed.Text = "Check only Automatic (Delayed Start)";
            this.miChkAutoDelayed.Click += new System.EventHandler(this.miChkAutoDelayed_Click);
            // 
            // miChkAuto
            // 
            this.miChkAuto.Name = "miChkAuto";
            this.miChkAuto.Size = new System.Drawing.Size(262, 22);
            this.miChkAuto.Text = "Check only Automatic";
            this.miChkAuto.Click += new System.EventHandler(this.miChkAuto_Click);
            // 
            // miChkDisabled
            // 
            this.miChkDisabled.Name = "miChkDisabled";
            this.miChkDisabled.Size = new System.Drawing.Size(262, 22);
            this.miChkDisabled.Text = "Check only Disabled";
            this.miChkDisabled.Click += new System.EventHandler(this.miChkDisabled_Click);
            // 
            // miChkManual
            // 
            this.miChkManual.Name = "miChkManual";
            this.miChkManual.Size = new System.Drawing.Size(262, 22);
            this.miChkManual.Text = "Check only Manual";
            this.miChkManual.Click += new System.EventHandler(this.miChkManual_Click);
            // 
            // miChkUnknown
            // 
            this.miChkUnknown.Name = "miChkUnknown";
            this.miChkUnknown.Size = new System.Drawing.Size(262, 22);
            this.miChkUnknown.Text = "Check only Unknown";
            this.miChkUnknown.Click += new System.EventHandler(this.miChkUnknown_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lServicesName,
            this.lServicesCount,
            this.lAutomaticDelayedName,
            this.lAutomaticDelayedCount,
            this.lAutomaticName,
            this.lAutomaticCount,
            this.lManualName,
            this.lManualCount,
            this.lDisabledName,
            this.lDisabledCount,
            this.lUnknownName,
            this.lUnknownCount});
            this.statusStrip.Location = new System.Drawing.Point(0, 540);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 22);
            this.statusStrip.TabIndex = 4;
            // 
            // lServicesName
            // 
            this.lServicesName.Name = "lServicesName";
            this.lServicesName.Size = new System.Drawing.Size(50, 17);
            this.lServicesName.Text = "Services:";
            // 
            // lServicesCount
            // 
            this.lServicesCount.Margin = new System.Windows.Forms.Padding(0, 3, 10, 2);
            this.lServicesCount.Name = "lServicesCount";
            this.lServicesCount.Size = new System.Drawing.Size(13, 17);
            this.lServicesCount.Text = "0";
            // 
            // lAutomaticDelayedName
            // 
            this.lAutomaticDelayedName.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lAutomaticDelayedName.Name = "lAutomaticDelayedName";
            this.lAutomaticDelayedName.Size = new System.Drawing.Size(143, 17);
            this.lAutomaticDelayedName.Text = "Automatic (Delayed Start):";
            // 
            // lAutomaticDelayedCount
            // 
            this.lAutomaticDelayedCount.Margin = new System.Windows.Forms.Padding(0, 3, 10, 2);
            this.lAutomaticDelayedCount.Name = "lAutomaticDelayedCount";
            this.lAutomaticDelayedCount.Size = new System.Drawing.Size(13, 17);
            this.lAutomaticDelayedCount.Text = "0";
            // 
            // lAutomaticName
            // 
            this.lAutomaticName.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lAutomaticName.Name = "lAutomaticName";
            this.lAutomaticName.Size = new System.Drawing.Size(66, 17);
            this.lAutomaticName.Text = "Automatic:";
            // 
            // lAutomaticCount
            // 
            this.lAutomaticCount.Margin = new System.Windows.Forms.Padding(0, 3, 10, 2);
            this.lAutomaticCount.Name = "lAutomaticCount";
            this.lAutomaticCount.Size = new System.Drawing.Size(13, 17);
            this.lAutomaticCount.Text = "0";
            // 
            // lManualName
            // 
            this.lManualName.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lManualName.Name = "lManualName";
            this.lManualName.Size = new System.Drawing.Size(53, 17);
            this.lManualName.Text = "Manual:";
            // 
            // lManualCount
            // 
            this.lManualCount.Margin = new System.Windows.Forms.Padding(0, 3, 10, 2);
            this.lManualCount.Name = "lManualCount";
            this.lManualCount.Size = new System.Drawing.Size(13, 17);
            this.lManualCount.Text = "0";
            // 
            // lDisabledName
            // 
            this.lDisabledName.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lDisabledName.Name = "lDisabledName";
            this.lDisabledName.Size = new System.Drawing.Size(59, 17);
            this.lDisabledName.Text = "Disabled:";
            // 
            // lDisabledCount
            // 
            this.lDisabledCount.Margin = new System.Windows.Forms.Padding(0, 3, 10, 2);
            this.lDisabledCount.Name = "lDisabledCount";
            this.lDisabledCount.Size = new System.Drawing.Size(13, 17);
            this.lDisabledCount.Text = "0";
            // 
            // lUnknownName
            // 
            this.lUnknownName.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lUnknownName.Name = "lUnknownName";
            this.lUnknownName.Size = new System.Drawing.Size(65, 17);
            this.lUnknownName.Text = "Unknown:";
            // 
            // lUnknownCount
            // 
            this.lUnknownCount.Name = "lUnknownCount";
            this.lUnknownCount.Size = new System.Drawing.Size(13, 17);
            this.lUnknownCount.Text = "0";
            // 
            // btnRefresh
            // 
            this.btnRefresh.AccessibleDescription = "";
            this.btnRefresh.Location = new System.Drawing.Point(12, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(30, 30);
            this.btnRefresh.TabIndex = 1;
            this.toolTip.SetToolTip(this.btnRefresh, "Refresh");
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(742, 8);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(30, 30);
            this.btnGenerate.TabIndex = 3;
            this.toolTip.SetToolTip(this.btnGenerate, "Generate CMD file");
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // info
            // 
            this.info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.info.AutoSize = true;
            this.info.Enabled = false;
            this.info.Location = new System.Drawing.Point(645, 525);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(136, 13);
            this.info.TabIndex = 2579;
            this.info.Text = "Daniel Swan © 2017, 2022";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Windows Command Script (*.cmd)|*.cmd|All files (*.*)|*.*";
            // 
            // chbDescription
            // 
            this.chbDescription.AutoSize = true;
            this.chbDescription.Location = new System.Drawing.Point(57, 16);
            this.chbDescription.Name = "chbDescription";
            this.chbDescription.Size = new System.Drawing.Size(107, 17);
            this.chbDescription.TabIndex = 2;
            this.chbDescription.Text = "Show description";
            this.chbDescription.UseVisualStyleBackColor = true;
            this.chbDescription.CheckedChanged += new System.EventHandler(this.chbDescription_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.chbDescription);
            this.Controls.Add(this.info);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.lvMain);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIN: Services Reader";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvMain;
        private System.Windows.Forms.ColumnHeader chDisplayName;
        private System.Windows.Forms.ColumnHeader chServiceName;
        private System.Windows.Forms.ColumnHeader chStartupType;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lServicesName;
        private System.Windows.Forms.ToolStripStatusLabel lServicesCount;
        private System.Windows.Forms.ToolStripStatusLabel lAutomaticName;
        private System.Windows.Forms.ToolStripStatusLabel lAutomaticDelayedName;
        private System.Windows.Forms.ToolStripStatusLabel lAutomaticDelayedCount;
        private System.Windows.Forms.ToolStripStatusLabel lAutomaticCount;
        private System.Windows.Forms.ToolStripStatusLabel lManualName;
        private System.Windows.Forms.ToolStripStatusLabel lManualCount;
        private System.Windows.Forms.ToolStripStatusLabel lDisabledName;
        private System.Windows.Forms.ToolStripStatusLabel lDisabledCount;
        private System.Windows.Forms.ToolStripStatusLabel lUnknownName;
        private System.Windows.Forms.ToolStripStatusLabel lUnknownCount;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem miSelectAll;
        private System.Windows.Forms.ToolStripMenuItem miDeselectAll;
        private System.Windows.Forms.ToolStripMenuItem miSelectInvert;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miCheckAll;
        private System.Windows.Forms.ToolStripMenuItem miUncheckAll;
        private System.Windows.Forms.ToolStripMenuItem miInvertChecking;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem miCheckSelected;
        private System.Windows.Forms.ToolStripMenuItem miUncheckSelected;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem miChkAutoDelayed;
        private System.Windows.Forms.ToolStripMenuItem miChkAuto;
        private System.Windows.Forms.ToolStripMenuItem miChkDisabled;
        private System.Windows.Forms.ToolStripMenuItem miChkManual;
        private System.Windows.Forms.ToolStripMenuItem miChkUnknown;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ColumnHeader chDescription;
        private System.Windows.Forms.CheckBox chbDescription;





    }
}

