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
    public partial class NameFilterEditor : Form
    {
        private NameFilter NFilter;

        public NameFilterEditor(Filter filter)
        {
            InitializeComponent();

            if (filter.Type != FilterType.Name)
                throw new Exception("Tried to edit a filter with type " + filter.Type + " as a name");
            NFilter = (NameFilter)filter;

            if (string.IsNullOrWhiteSpace(NFilter.soundName))
                txtSound.Text = "sound.wav";
            else
                txtSound.Text = NFilter.soundName;

            txtName.Text = NFilter.Name;
            txtNameFilter.Text = NFilter.nameFilter;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) == true ||
                string.IsNullOrWhiteSpace(txtNameFilter.Text) == true)
            {
                MessageBox.Show("Must enter valid names");
                return;
            }

            System.Media.SoundPlayer sound = Sounds.GetSoundFromFileName(txtSound.Text);
            if (sound != null)
                NFilter.sound = Sounds.GetSoundFromFileName(txtSound.Text);
            else
            {
                MessageBox.Show("There was an error loading the sound file");
                return;
            }

            NFilter.Name = txtName.Text;
            NFilter.nameFilter = txtNameFilter.Text;
            NFilter.soundName = txtSound.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
