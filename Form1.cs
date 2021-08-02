using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Runtime.InteropServices;
using System.Windows.Input;

namespace TarkovOverlay
{
    public partial class Form1 : Form
    {
        //x and y for screen size
        int x, y;

        //status
        bool raidStatus = false;
        bool mapShown = false;
        bool ammoShow = false;
        bool devMode = false;

        dev dev = new dev();

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsIconic(IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsZoomed(IntPtr hWnd);

        enum WinState
        {
            None,
            Maximized,
            Minimized,
            Normal,
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //gets screen dims.
            x = Screen.PrimaryScreen.Bounds.Width;
            y = Screen.PrimaryScreen.Bounds.Height;

            //sets overlay size
            this.Size = new System.Drawing.Size(x, y);

            MessageBox.Show("Select map in the bottom right for map to appear on screen, you can then toggle from the show map button. Be sure to set the game to borderless window in the game settings or else this wont work", "Escapee - Start Message");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //sets raidstatus = !raidstatus
            switchRaidStatus();
        }

        public void switchRaidStatus()
        {
            raidStatus = !raidStatus;
            toggleRaidStatus.Text = "Raid Status: " + raidStatus;

            if(!raidStatus)
            {
                foreach (Control control in Controls)
                {
                    if (control.Name != "toggleRaidStatus")
                    {
                        if (control.Name != "showmapBtn")
                        {
                            if(control.Name != "mapPicture")
                            {
                                control.Visible = true;
                            }
                        }
                    }
                }
            }
            else if(raidStatus)
            {
                //doing something for each control in the form
                foreach (Control control in Controls)
                {
                    
                    //if the control isnt the toggleraid button
                    if (control.Name != "toggleRaidStatus")
                    {
                        //if the control isnt the show map btn
                        if (control.Name != "showmapBtn")
                        {
                            //if the control isnt the map picture
                            if (control.Name != "mapPicture")
                            {
                                control.Visible = false;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("How? How did you manage to fucking cause this to be null?", "Escapee");
            }
        }

        private void showmapBtn_Click(object sender, EventArgs e)
        {
            if(guna2ComboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a map first", "Escapee");
            }
            else
            {
                //sets the map picture with this handy dandy fazey wazey function wunction
                setMapPicture();

                //toggles if the map is show (duh)
                mapShown = !mapShown;

                if (mapShown)
                {
                    mapPicture.Visible = true;
                }
                else
                {
                    mapPicture.Visible = false;
                }
            }
        }

        public void setMapPicture()
        {
            //simple, and efficient, way to change the map image
            switch (guna2ComboBox1.SelectedIndex)
            {
                case 1:
                    mapPicture.Image = Properties.Resources.CustomsLootAndExtracts;
                    break;

                case 2:
                    mapPicture.Image = Properties.Resources.Woods_Map;
                    break;

                case 3:
                    mapPicture.Image = Properties.Resources.Reserve_Map_scaled;
                    break;
            }
            dev.outputConsole("Info", "Set Map Picture");
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            //this needs LOTS of work, but it should be fine for now.
            if (!mapShown)
            {
                mapPicture.Visible = !mapPicture.Visible;
                mapShown = !mapShown;
                ammoShow = !ammoShow;

                if (ammoShow)
                {
                    mapPicture.Image = Properties.Resources.ammoChart;
                }
                else if(!ammoShow)
                {
                    setMapPicture();
                }
            }
            else
            {
                dev.outputConsole("Info", "Ammo chart fallback");

                mapPicture.Visible = !mapPicture.Visible;
                mapShown = !mapShown;

                setMapPicture();
            }
        }

        private void guna2ComboBox1_DropDownClosed(object sender, EventArgs e)
        {
            setMapPicture();
        }

        private static WinState GetWindowState(IntPtr hWnd)
        {
            WinState winState = WinState.None;
            if (hWnd != IntPtr.Zero)
            {
                if (IsIconic(hWnd))
                {
                    winState = WinState.Minimized;
                }
                else if (IsZoomed(hWnd))
                {
                    winState = WinState.Maximized;
                }
                else
                {
                    winState = WinState.Normal;
                }
            }

            return winState;
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            
        }

        private static WinState GetWindowState(string windowCaption)
        {
            return GetWindowState((IntPtr)FindWindow(null, windowCaption));
        }
    }
}

