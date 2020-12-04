using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace StretchBreak
{
    public class FlashWindows
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FlashWindowEx(ref FLASHWINFO pwfi);

        [StructLayout(LayoutKind.Sequential)]
        public struct FLASHWINFO
        {
            public UInt32 cbSize;
            public IntPtr hwnd;
            public UInt32 dwFlags;
            public UInt32 uCount;
            public UInt32 dwTimeout;
        }

        public enum FlashWindow : uint
        {
            /// <summary>
            /// Stop flashing. The system restores the window to its original state.
            /// </summary>    
            FLASHW_STOP = 0,

            /// <summary>
            /// Flash the window caption
            /// </summary>
            FLASHW_CAPTION = 1,

            /// <summary>
            /// Flash the taskbar button.
            /// </summary>
            FLASHW_TRAY = 2,

            /// <summary>
            /// Flash both the window caption and taskbar button.
            /// This is equivalent to setting the FLASHW_CAPTION | FLASHW_TRAY flags.
            /// </summary>
            FLASHW_ALL = 3,

            /// <summary>
            /// Flash continuously, until the FLASHW_STOP flag is set.
            /// </summary>
            FLASHW_TIMER = 4,

            /// <summary>
            /// Flash continuously until the window comes to the foreground.
            /// </summary>
            FLASHW_TIMERNOFG = 12
        }
        /// Minor adjust to the code above
        /// <summary>
        /// Flashes a window until the window comes to the foreground
        /// Receives the form that will flash
        /// </summary>
        /// <param name="hWnd">The handle to the window to flash</param>
        /// <returns>whether or not the window needed flashing</returns>
        public static bool FlashWindowEx(Form frm)
        {
            IntPtr hWnd = frm.Handle;
            FLASHWINFO fInfo = new FLASHWINFO();

            fInfo.cbSize = Convert.ToUInt32(Marshal.SizeOf(fInfo));
            fInfo.hwnd = hWnd;
            fInfo.dwFlags = (uint)(FlashWindow.FLASHW_TRAY | FlashWindow.FLASHW_TIMERNOFG);           
            fInfo.uCount = UInt32.MaxValue;
            fInfo.dwTimeout = 0;

            return FlashWindowEx(ref fInfo);
        }
    }
}
