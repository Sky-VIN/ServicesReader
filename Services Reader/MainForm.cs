using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;


namespace ServicesReader
{
    public partial class MainForm : Form
    {
        private CmdHelper CMD = new CmdHelper();
        private ServiceHelper serviceHelper = new ServiceHelper();
        private ListViewColumnSorter lvColumnSorter = new ListViewColumnSorter();


        public MainForm()
        {
            InitializeComponent();

            /* making app size smaller by icon size */
            Icon = Resources.MainIcon;

            /* insert images into buttons */
            btnRefresh.Image = Resources.RefreshImage;
            btnGenerate.Image = Resources.SaveImage;

            /* sort list by Status Type */
            lvMain_ColumnClick(chStartupType, new ColumnClickEventArgs(chStartupType.Index));
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            lvMain.ListViewItemSorter = lvColumnSorter;

            /* filling and checking the list */
            lvMain.Items.AddRange(serviceHelper.GetServicesList());
            miCheckAll_Click(sender, e);

            /* filling the service type counters */
            lServicesCount.Text = serviceHelper.GetAllServicesCount().ToString();
            lAutomaticDelayedCount.Text = serviceHelper.GetAutomaticDelayedCount().ToString();
            lAutomaticCount.Text = serviceHelper.GetAutomaticCount().ToString();
            lManualCount.Text = serviceHelper.GetManualCount().ToString();
            lDisabledCount.Text = serviceHelper.GetDisabledCount().ToString();
            lUnknownCount.Text = serviceHelper.GetUnknownCount().ToString();
        }


        /* List sort method */
        private void lvMain_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvColumnSorter.SortColumn)
            {
                if (lvColumnSorter.Order == SortOrder.Ascending) lvColumnSorter.Order = SortOrder.Descending;
                else lvColumnSorter.Order = SortOrder.Ascending;
            }
            else
            {
                lvColumnSorter.SortColumn = e.Column;
                lvColumnSorter.Order = SortOrder.Ascending;
            }

            lvMain.Sort();
            lvMain.SetSortIcon(lvColumnSorter.SortColumn, lvColumnSorter.Order);
        }


        /* Refresh button method */
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lvMain.Items.Clear();
            serviceHelper.ResetCounters();
            MainForm_Load(sender, e);
        }


        /* Show or Hide Services description method */
        private void chbDescription_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDescription.Checked) lvMain.Columns[chDescription.Index].Width = -2;
            else lvMain.Columns[chDescription.Index].Width = 0;
        }


        /* Generate button method */
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            /* opening Save dialog */
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<ListViewItem> Items = new List<ListViewItem>();

                /* creating list by checked items */
                foreach (ListViewItem item in lvMain.Items)
                    if (item.Checked)
                        Items.Add(new ListViewItem(new string[] { item.SubItems[1].Text, item.SubItems[2].Text }));

                /* generate CMD file */
                string result = CMD.Generate(saveFileDialog.FileName, Items);

                /* checking generation result */
                if (result == null)
                {
                    string successMessage = String.Format(Resources.SuccessMessage, saveFileDialog.FileName);

                    /* open containing folder if necessary */
                    if (MessageBox.Show(successMessage, Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        string file = String.Format(Resources.FileSelect, saveFileDialog.FileName);
                         Process.Start("explorer.exe", file);
                    }
                }
                else MessageBox.Show(result, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* MRC - Mouse Right Click */

        /* MRC Select All */
        private void miSelectAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMain.Items)
                item.Selected = true;
        }


        /* MRC Deselect All */
        private void miDeselectAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMain.Items)
                item.Selected = false;
        }


        /* MRC Invert Selection */
        private void miSelectInvert_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMain.Items)
                if (item.Selected) item.Selected = false;
                else item.Selected = true;
        }


        /* MRC Check All */
        private void miCheckAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMain.Items)
                item.Checked = true;
        }


        /* MRC Uncheck All */
        private void miUncheckAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMain.Items)
                item.Checked = false;
        }


        /* MRC Invert Checking */
        private void miInvertChecking_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMain.Items)
                if (item.Checked) item.Checked = false;
                else item.Checked = true;
        }


        /* MRC Check Selected */
        private void miCheckSelected_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMain.Items)
                if (item.Selected) item.Checked = true;
        }


        /* MRC Uncheck Selected */
        private void miUncheckSelected_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMain.Items)
                if (item.Selected) item.Checked = false;
        }


        /* MRC Check only Automatic (Delayed Start) */
        private void miChkAutoDelayed_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMain.Items)
                if (item.SubItems[2].Text.Equals(Resources.Type_AutoDelayed)) item.Checked = true;
                else item.Checked = false;
        }


        /* MRC Check only Automatic */
        private void miChkAuto_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMain.Items)
                if (item.SubItems[2].Text.Equals(Resources.Type_Auto)) item.Checked = true;
                else item.Checked = false;
        }


        /* MRC Check only Disabled */
        private void miChkDisabled_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMain.Items)
                if (item.SubItems[2].Text.Equals(Resources.Type_Disabled)) item.Checked = true;
                else item.Checked = false;
        }


        /* MRC Check only Manual */
        private void miChkManual_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMain.Items)
                if (item.SubItems[2].Text.Equals(Resources.Type_Manual)) item.Checked = true;
                else item.Checked = false;
        }


        /* MRC Check only Unknown */
        private void miChkUnknown_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMain.Items)
                if (item.SubItems[2].Text.Equals(Resources.Type_Unknown)) item.Checked = true;
                else item.Checked = false;
        }
    }
}
