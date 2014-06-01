using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;

using LootAlert.ItemFinding;

namespace LootAlert
{
    public partial class LootAlert : Form
    {
        private const string version = "1.0.5";
        private Timer timer;
        private bool Running;
        private ItemFinder finder;

        public LootAlert()
        {
            InitializeComponent();
            this.Text += " " + version;

            timer = new Timer();
            timer.Enabled = false;
            timer.Interval = 250;
            timer.Tick += new EventHandler(timer_Tick);
            UpdateFilters();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                ACDActor acd = finder.FindBestItem();
                if (acd != null)
                {
                    Settings.PlaySoundForActor(acd);
                }
            }
            catch (Exception ex)
            {
                SetStatus(false);
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void UpdateFilters()
        {
            boxFilters.Items.Clear();
            List<Filter> filters = Settings.filters;
            foreach (Filter t in filters)
            {
                boxFilters.Items.Add(t, t.Enabled);
            }
        }

        private void btnTestSound_Click(object sender, EventArgs e)
        {
            if (boxFilters.SelectedIndex != -1)
            {
                Settings.filters[boxFilters.SelectedIndex].sound.Play();
            }
        }

        private bool SetStatus(bool status)
        {
            if (status == true)
            {
                try
                {
                    Process[] processes = Process.GetProcessesByName("Diablo III");
                    if (processes.Length > 1)
                    {
                        SelectProcessDialog dialog = new SelectProcessDialog(processes);
                        if (dialog.ShowDialog(this) == DialogResult.OK)
                        {
                            finder = new ItemFinder(dialog.GetID());
                        }
                        else
                            return false;
                    }
                    else
                    {
                        finder = new ItemFinder();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not find the diablo process!");
                    return false;
                }
                timer.Enabled = true;
            }

            if (status == false)
            {
                try
                {
                    finder.Dispose();
                }
                catch (Exception)
                {
                }
                timer.Enabled = false;
            }

            return true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Running == false)
            {
                if (SetStatus(true))
                {
                    btnStart.Text = "Stop";
                    Running = true;
                }
            }
            else
            {
                if (SetStatus(false))
                {
                    btnStart.Text = "Start";
                    Running = false;
                }
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (boxFilters.SelectedIndex != -1)
            {
                Filter selected = (Filter)boxFilters.SelectedItem;
                Form form = null;
                if (selected.Type == FilterType.Item)
                    form = new ItemFilterEditor((ItemFilter)selected);
                else if (selected.Type == FilterType.Name)
                    form = new NameFilterEditor((NameFilter)selected);
                form.ShowDialog();
                UpdateFilters();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form form = null;
            Filter filter = null;

            SelectFilterForm select = new SelectFilterForm();
            if (select.ShowDialog(this) == DialogResult.OK)
            {
                switch (select.Selected)
                {
                    case FilterType.Item:
                        {
                            filter = new ItemFilter();
                            form = new ItemFilterEditor(filter);
                            break;
                        }
                    case FilterType.Name:
                        {
                            filter = new NameFilter();
                            form = new NameFilterEditor(filter);
                            break;
                        }
                }
            }
            else
                return;

            if (form.ShowDialog(this) == DialogResult.OK)
                Settings.filters.Add(filter);
            UpdateFilters();
        }

        private void bntRemove_Click(object sender, EventArgs e)
        {
            if (boxFilters.SelectedIndex != -1)
            {
                Settings.filters.Remove((Filter)boxFilters.SelectedItem);
                UpdateFilters();
            }
        }

        private bool ignoreCheck;
        private void boxFilters_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (ignoreCheck)
                e.NewValue = e.CurrentValue;
            else
                Settings.filters[e.Index].Enabled = e.NewValue == CheckState.Checked;
        }

        private void boxFilters_MouseClick(object sender, MouseEventArgs e)
        {
            ignoreCheck = e.X > SystemInformation.MenuCheckSize.Width;
        }

        private void boxFilters_MouseUp(object sender, MouseEventArgs e)
        {
            ignoreCheck = false;
        }
    }
}
