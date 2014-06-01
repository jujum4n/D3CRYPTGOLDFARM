using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LootAlert.ItemFinding;

namespace LootAlert
{
    public partial class SelectFilterForm : Form
    {
        public FilterType Selected { get; private set; }

        public SelectFilterForm()
        {
            InitializeComponent();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Selected = FilterType.Item;
            Close();
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Selected = FilterType.Name;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
