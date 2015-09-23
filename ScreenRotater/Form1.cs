using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Runtime.InteropServices;
using DisplaySettingsSample;

namespace ScreenRotater
{
    public partial class Form1 : Form
    {
        private int[] orientationValues = new int[4]{NativeMethods.DMDO_DEFAULT,
														NativeMethods.DMDO_90,
														NativeMethods.DMDO_180,
														NativeMethods.DMDO_270};
        public Form1()
        {
            InitializeComponent();
        }

        private int GetSettings(ref DEVMODE dm)
        {
            // helper to obtain current settings
            return GetSettings(ref dm, NativeMethods.ENUM_CURRENT_SETTINGS);
        }

        private int GetSettings(ref DEVMODE dm, int iModeNum)
        {
            // helper to wrap EnumDisplaySettings Win32 API
            return NativeMethods.EnumDisplaySettings(null, iModeNum, ref dm);
        }
        private void ChangeSettings(DEVMODE dm)
        {
            // helper to wrap ChangeDisplaySettings Win32 API
            //if (DialogResult.Yes == MessageBox.Show("Are you sure you want to change your display setings?", "", MessageBoxButtons.YesNo))
            {
                int iRet = NativeMethods.ChangeDisplaySettings(ref dm, 0);
                switch (iRet)
                {
                    case NativeMethods.DISP_CHANGE_SUCCESSFUL:
                        break;
                    case NativeMethods.DISP_CHANGE_RESTART:
                        MessageBox.Show("Please restart your system");
                        break;
                    case NativeMethods.DISP_CHANGE_FAILED:
                        MessageBox.Show("ChangeDisplaySettigns API failed");
                        break;
                    case NativeMethods.DISP_CHANGE_BADDUALVIEW:
                        MessageBox.Show("The settings change was unsuccessful because system is DualView capable.");
                        break;
                    case NativeMethods.DISP_CHANGE_BADFLAGS:
                        MessageBox.Show("An invalid set of flags was passed in.");
                        break;
                    case NativeMethods.DISP_CHANGE_BADPARAM:
                        MessageBox.Show("An invalid parameter was passed in. This can include an invalid flag or combination of flags.");
                        break;
                    case NativeMethods.DISP_CHANGE_NOTUPDATED:
                        MessageBox.Show("Unable to write settings to the registry.");
                        break;
                    default:
                        MessageBox.Show("Unknown return value from ChangeDisplaySettings API");
                        break;
                }
            }
        }
        private void RotateClockwise()
        {
            DEVMODE dm = NativeMethods.CreateDevmode();
            GetSettings(ref dm);

            //swap height and width
            int temp = dm.dmPelsHeight;
            dm.dmPelsHeight = dm.dmPelsWidth;
            dm.dmPelsWidth = temp;

            // set the orientation value to what's next clockwise
            int index = Array.IndexOf(orientationValues, (object)dm.dmDisplayOrientation);
            int newIndex = (index == 0) ? 3 : index - 1;
            dm.dmDisplayOrientation = orientationValues[newIndex];

            // switch to new settings
            ChangeSettings(dm);		
            
        }

        private void RotateAntiClockwise()
        {
            // obtain current settings
            DEVMODE dm = NativeMethods.CreateDevmode();
            GetSettings(ref dm);

            // swap height and width
            int temp = dm.dmPelsHeight;
            dm.dmPelsHeight = dm.dmPelsWidth;
            dm.dmPelsWidth = temp;

            // set the orientation value to what's next anti-clockwise
            int index = Array.IndexOf(orientationValues, (object)dm.dmDisplayOrientation);
            int newIndex = (index == 3) ? 0 : index + 1;
            dm.dmDisplayOrientation = orientationValues[newIndex];

            // switch to new settings
            ChangeSettings(dm);
        }

        private void buttonClockwise_Click(object sender, EventArgs e)
        {
            RotateClockwise();
        }

        private void buttonAntiClockwise_Click(object sender, EventArgs e)
        {
            RotateAntiClockwise();
        }
    }
}
