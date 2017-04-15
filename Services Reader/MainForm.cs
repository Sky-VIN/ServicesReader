using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.ServiceProcess;
using Microsoft.Win32;

namespace Services_Reader
{
    public partial class MainForm : Form
    {
        private int automaticDelayedCount = 0;
        private int automaticCount = 0;
        private int manualCount = 0;
        private int disabledCount = 0;
        private int unknownCount = 0;

        private ServiceController[] services = ServiceController.GetServices();
        private ListViewColumnSorter lvColumnSorter = new ListViewColumnSorter();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lvMain.ListViewItemSorter = lvColumnSorter;

            foreach (ServiceController sc in services)
            {
                lvMain.Items.Add(new ListViewItem(new String[] { sc.DisplayName, sc.ServiceName, getStartupType(sc.ServiceName) })).Checked = true;
            }

            lServicesCount.Text = services.Length.ToString() + "    ";
            lAutomaticDelayedCount.Text = automaticDelayedCount.ToString() + "    ";
            lAutomaticCount.Text = automaticCount.ToString() + "    ";
            lManualCount.Text = manualCount.ToString() + "    ";
            lDisabledCount.Text = disabledCount.ToString() + "    ";
            lUnknownCount.Text = unknownCount.ToString();

            lvMain_ColumnClick(chStartupType, new ColumnClickEventArgs(chStartupType.Index));
        }

        private string getStartupType(string serviceName)
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\" + serviceName);
            switch ((int)key.GetValue("Start"))
            {
                case 2:
                    try
                    {
                        if ((int)key.GetValue("DelayedAutostart") == 1)
                        {
                            automaticDelayedCount++;
                            return "Automatic (Delayed Start)";
                        }
                        else
                        {
                            automaticCount++;
                            return "Automatic";
                        }
                    }
                    catch
                    {
                        automaticCount++;
                        return "Automatic";
                    }

                case 3:
                    manualCount++;
                    return "Manual";

                case 4:
                    disabledCount++;
                    return "Disabled";

                default:
                    unknownCount++;
                    return "Unknown";
            }

            key.Close();
        }

        private void lvMain_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvColumnSorter.SortColumn)
            {
                if (lvColumnSorter.Order == SortOrder.Ascending)
                {
                    lvColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                lvColumnSorter.SortColumn = e.Column;
                lvColumnSorter.Order = SortOrder.Ascending;
            }

            lvMain.Sort();
            lvMain.SetSortIcon(lvColumnSorter.SortColumn, lvColumnSorter.Order);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            automaticDelayedCount = 0;
            automaticCount = 0;
            manualCount = 0;
            disabledCount = 0;
            unknownCount = 0;

            lvMain.Items.Clear();

            MainForm_Load(sender, e);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sWriter = new StreamWriter(saveFileDialog.FileName);
                sWriter.WriteLine("@echo off");
                sWriter.WriteLine("CLS\n");
                foreach (ListViewItem item in lvMain.Items)
                    if (item.Checked)
                        sWriter.WriteLine(generateServiceScript(item.SubItems[1].Text, item.SubItems[2].Text));

                sWriter.WriteLine("\nchoice /M \"Do you want restart copmuter\"");

                sWriter.WriteLine("\nif errorlevel 2 goto END");
                sWriter.WriteLine("if errorlevel 1 goto RESTART\n");

                sWriter.WriteLine(":RESTART");
                sWriter.WriteLine("shutdown -r -t 00");
                sWriter.WriteLine("goto END\n");

                sWriter.WriteLine(":END");

                sWriter.Close();

                if (MessageBox.Show("File " + saveFileDialog.FileName + " created successfully! :)" + "\nDo you want open folder location?", "VIN: Services Reader", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    string argument = "/select, \"" + saveFileDialog.FileName + "\"";
                    Process.Start("explorer.exe", argument);
                }
            }
        }

        private string generateServiceScript(string serviceName, string startupType)
        {
            switch (startupType)
            {
                case "Automatic (Delayed Start)":
                    return "sc config \"" + serviceName + "\" start= delayed-auto";
                case "Automatic":
                    return "sc config \"" + serviceName + "\" start= auto";
                case "Manual":
                    return "sc config \"" + serviceName + "\" start= demand";
                case "Disabled":
                    return "sc config \"" + serviceName + "\" start= disabled";
                default:
                    return "sc config \"" + serviceName + "\" start= disabled";
            }
        }

        private void miSelectAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMain.Items)
                item.Selected = true;
        }

        private void miDeselectAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMain.Items)
                item.Selected = false;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMain.Items)
                if (item.Selected) item.Selected = false;
                else item.Selected = true;
        }

        private void miCheckAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMain.Items)
                item.Checked = true;
        }

        private void miUncheckAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMain.Items)
                item.Checked = false;
        }

        private void miInvertChecking_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMain.Items)
                if (item.Checked) item.Checked = false;
                else item.Checked = true;
        }

        private void miCheckSelected_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMain.Items)
                if (item.Selected) item.Checked = true;
        }

        private void miUncheckSelected_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMain.Items)
                if (item.Selected) item.Checked = false;
        }

        private void miChkAutoDelayed_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMain.Items)
                if (item.SubItems[2].Text.Equals("Automatic (Delayed Start)")) item.Checked = true;
                else item.Checked = false;
        }

        private void miChkAuto_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMain.Items)
                if (item.SubItems[2].Text.Equals("Automatic")) item.Checked = true;
                else item.Checked = false;
        }

        private void miChkDisabled_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMain.Items)
                if (item.SubItems[2].Text.Equals("Disabled")) item.Checked = true;
                else item.Checked = false;
        }

        private void miChkManual_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMain.Items)
                if (item.SubItems[2].Text.Equals("Manual")) item.Checked = true;
                else item.Checked = false;
        }

        private void miChkUnknown_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMain.Items)
                if (item.SubItems[2].Text.Equals("Unknown")) item.Checked = true;
                else item.Checked = false;
        }
    }
}
