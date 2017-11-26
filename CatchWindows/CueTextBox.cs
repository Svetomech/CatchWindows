using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CatchWindows
{
    class CueTextBox : TextBox
    {
        private string _cue;

        public string Cue
        {
            get
            {
                return _cue;
            }
            set
            {
                _cue = value;
                UpdateCue();
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            UpdateCue();
        }
        private void UpdateCue()
        {
            if (IsHandleCreated && _cue != null)
            {
                NativeMethods.SendMessage(Handle, NativeMethods.EM_SETCUEBANNER, (IntPtr)1, _cue);
            }
        }

        private static class NativeMethods
        {
            internal const uint EM_SETCUEBANNER = ECM_FIRST + 1;
            private const uint ECM_FIRST = 0x1500;

            [DllImport("user32.dll", CharSet = CharSet.Unicode)]
            internal static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, string lParam);
        }
    }
}
