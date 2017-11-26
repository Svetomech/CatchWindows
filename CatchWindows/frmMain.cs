using Svetomech.Utilities;
using Svetomech.Utilities.Types;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CatchWindows
{
    public partial class frmMain : Form
    {
        private Graphics graphics;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnFindProcessWindows_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtProcess.Text)) return;

            lstProcessWindows.Items.Clear();
            progressFind.Value = 0;

            var windows = SimpleProcess.GetAllWindows(txtProcess.Text);
            int windowsCount = windows.Count();
            if (windowsCount == 0)
            {
                Size = new Size(MinimumSize.Width, MinimumSize.Height);  // resizing
                return;
            }

            progressFind.Step = 100 / windowsCount;

            var itemWidths = new List<int>();  // resizing
            foreach (var window in windows)
            {
                if (window.Handle != IntPtr.Zero && window.Visible) lstProcessWindows.Items.Add(window);
                progressFind.PerformStep();

                itemWidths.Add((int)graphics.MeasureString(window.ToString(), Font).Width);  // resizing
            }
            Size = new Size(itemWidths.Max() + 66, Height);  // resizing

            progressFind.Value = 100;
        }
        private void txtProcess_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnFindProcessWindows.PerformClick();
                e.Handled = true;
            }
        }
        private void lstProcessWindows_DoubleClick(object sender, EventArgs e)
        {
            if (lstProcessWindows.SelectedItem != null)
                WindowFactory.Create(((IWindow)lstProcessWindows.SelectedItem).Handle).SetPosition(0, 0);
        }
        private void lstProcessWindows_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                lstProcessWindows_DoubleClick(sender, e);
                e.Handled = true;
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Width, MaximumSize.Height);
            graphics = CreateGraphics();
        }
    }
}
