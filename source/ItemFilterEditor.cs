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
    public partial class ItemFilterEditor : Form
    {
        private ItemFilter filter;
        public static List<ItemType> items = Enum.GetValues(typeof(ItemType)).Cast<ItemType>().OrderBy(type => type.ToString()).ToList();

        public ItemFilterEditor(Filter inFilter)
        {
            InitializeComponent();
            if (inFilter.Type != FilterType.Item)
                throw new Exception("Tried to edit a filter of type " + inFilter.Type + " in the item editor!");
            this.filter = (ItemFilter)inFilter;

            txtName.Text = filter.Name;
            txtMinLVL.Text = filter.MinLVL.ToString();

            if (string.IsNullOrWhiteSpace(filter.soundName) == false)
                txtSound.Text = filter.soundName;
            else
                txtSound.Text = "sound.wav";

            boxQuality.Items.AddRange(Enum.GetNames(typeof(ItemQuality)));
            boxQuality.SelectedItem = Enum.GetName(typeof(ItemQuality), filter.Quality);
            UpdateListBoxes();
        }

        private void UpdateListBoxes()
        {
            listEnabled.Items.Clear();
            listDisabled.Items.Clear();
            foreach (ItemType item in items)
            {
                if (filter.IsAllowed(item))
                    listEnabled.Items.Add(item);
                else
                    listDisabled.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckData() == false)
                return;

            System.Media.SoundPlayer sound = Sounds.GetSoundFromFileName(txtSound.Text);
            if (sound != null)
                filter.sound = Sounds.GetSoundFromFileName(txtSound.Text);
            else
            {
                MessageBox.Show("There was an error loading the sound file");
                return;
            }

            filter.soundName = txtSound.Text;
            filter.Name = txtName.Text;
            filter.MinLVL = int.Parse(txtMinLVL.Text);
            filter.Quality = (ItemQuality)Enum.Parse(typeof(ItemQuality), (string)boxQuality.SelectedItem);
            DialogResult = DialogResult.OK;
            Close();
        }

        private bool CheckData()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Must specify a name");
                return false;
            }

            int value;
            if (int.TryParse(txtMinLVL.Text, out value) == false)
            {
                MessageBox.Show("Invalid itemlevel input");
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (listEnabled.SelectedIndex != -1)
            {
                filter.SetAllowed((ItemType)listEnabled.SelectedItem, false);
                UpdateListBoxes();
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (listDisabled.SelectedIndex != -1)
            {
                filter.SetAllowed((ItemType)listDisabled.SelectedItem, true);
                UpdateListBoxes();
            }
        }

        private void btnAllRight_Click(object sender, EventArgs e)
        {
            foreach (ItemType item in items)
            {
                filter.SetAllowed(item, false);
            }
            UpdateListBoxes();
        }

        private void btnAllLeft_Click(object sender, EventArgs e)
        {
            foreach (ItemType item in items)
            {
                filter.SetAllowed(item, true);
            }
            UpdateListBoxes();
        }

        private void txtMinLVL_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}
