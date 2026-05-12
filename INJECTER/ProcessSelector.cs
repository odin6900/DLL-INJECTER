using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace INJECTER
{
    public partial class ProcessSelector : Form
    {
        private List<ProcessInfo> allProcesses = new List<ProcessInfo>();
        public string SelectedProcessName { get; set; } = "";

        private class ProcessInfo
        {
            public string Name { get; set; }
            public int PID { get; set; }
            public Icon Icon { get; set; }
        }

        public ProcessSelector()
        {
            InitializeComponent();
            LoadProcesses();
        }

        private void LoadProcesses()
        {
            try
            {
                allProcesses.Clear();
                Process[] processes = Process.GetProcesses();
                
                foreach (Process p in processes)
                {
                    try
                    {
                        Icon icon = null;
                        try
                        {
                            icon = Icon.ExtractAssociatedIcon(p.MainModule?.FileName);
                        }
                        catch { }

                        allProcesses.Add(new ProcessInfo
                        {
                            Name = p.ProcessName,
                            PID = p.Id,
                            Icon = icon
                        });
                    }
                    catch { }
                }

                allProcesses = allProcesses.OrderBy(x => x.Name).ToList();
                RefreshListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading processes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshListView()
        {
            string filterText = textBoxFilter.Text.ToLower();
            lvProcesses.Items.Clear();

            var filtered = string.IsNullOrEmpty(filterText)
                ? allProcesses
                : allProcesses.Where(p => p.Name.ToLower().Contains(filterText)).ToList();

            foreach (var proc in filtered)
            {
                ListViewItem item = new ListViewItem(proc.Name);
                item.SubItems.Add(proc.PID.ToString());
                item.Tag = proc;

                if (proc.Icon != null)
                {
                    imageList1.Images.Add(proc.Icon);
                    item.ImageIndex = imageList1.Images.Count - 1;
                }

                lvProcesses.Items.Add(item);
            }

            labelCount.Text = $"Processes: {filtered.Count} / {allProcesses.Count}";
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            RefreshListView();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lvProcesses.SelectedItems.Count > 0)
            {
                ProcessInfo selected = lvProcesses.SelectedItems[0].Tag as ProcessInfo;
                SelectedProcessName = selected.Name;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a process first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lvProcesses_DoubleClick(object sender, EventArgs e)
        {
            btnSelect_Click(null, null);
        }
    }
}
