using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace POEZoomHack
{
    public partial class MainForm : Form
    {
      

        private float Zoom = 0.0f;
        private const float ZoomStep = 10.0f;

        private readonly IntPtr ObjMgr = new IntPtr(0x01543B9C); // 1.0.4.11327

        private const int baseOffset = 2260;
        private const int zoomOffset = 208;

        public MainForm()
        {
            InitializeComponent();
        }

        private void zoomTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Zoom = -zoomTrackBar.Value / ZoomStep;
            zoomLabel.Text = (-Zoom).ToString();

            try
            {
                SetZoom();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void processComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Memory.SelectProcess(processComboBox.SelectedIndex);
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            var processes = Process.GetProcessesByName("Client");
            Memory.SetProcesses(processes);

            processComboBox.Items.Clear();

            foreach (Process p in processes)
                processComboBox.Items.Add(String.Format("{0} ({1})", p.ProcessName, p.Id));

            if (processes.Length > 0)
            {
                if (processComboBox.SelectedIndex == -1)
                    processComboBox.SelectedIndex = 0;

                if (processComboBox.SelectedIndex >= processes.Length)
                {
                    processComboBox.SelectedIndex = 0;
                    Memory.SelectProcess(0);
                }
            }

            try
            {

                if (GetZoom() != Zoom)
                {
                    try
                    {
                        SetZoom();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {

            }
        }

        private float GetZoom()
        {
            IntPtr offset0 = Memory.Read<IntPtr>(ObjMgr);
            if (offset0 == IntPtr.Zero)
                return 0.0f;
            IntPtr offset1 = Memory.Read<IntPtr>(offset0 + baseOffset);
            if (offset1 == IntPtr.Zero)
                return 0.0f;

            return Memory.Read<float>(offset1 + zoomOffset);
        }

        private void SetZoom()
        {
            IntPtr offset0 = Memory.Read<IntPtr>(ObjMgr);
            if (offset0 == IntPtr.Zero)
                return;

            IntPtr offset1 = Memory.Read<IntPtr>(offset0 + baseOffset);
            if (offset1 == IntPtr.Zero)
                return;

            Memory.Write<float>(offset1 + zoomOffset, Zoom);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
