using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace LootAlert
{
    public partial class SelectProcessDialog : Form
    {
        private int id;

        public SelectProcessDialog(Process[] processes)
        {
            InitializeComponent();

            foreach (Process p in processes)
            {
                comboBoxProcs.Items.Add(p.Id);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (comboBoxProcs.SelectedIndex != -1)
            {
                id = (int)comboBoxProcs.SelectedItem;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        public int GetID()
        {
            return id;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
