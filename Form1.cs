using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker
{
    public partial class Hydr0 : Form
    {
        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        private static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);


        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        public Hydr0()
        {
            InitializeComponent();
        }

        private void CPSTrackbar_Scroll(object sender, ScrollEventArgs e)
        {
            CPSValue.Text = (CPSTrackbar.Value.ToString() + " CPS");
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (btnToggle.Text.Contains("disable"))
            {
                btnToggle.Text = "enable";
            }
            else if (btnToggle.Text.Contains("enable"))
            {
                btnToggle.Text = "disable";
            }
        }

        private void btnToggle_TextChanged(object sender, EventArgs e)
        {
            if (btnToggle.Text.Contains("disable"))
            {
                Autoclicker.Start();
            }
            else
            {
                Autoclicker.Stop();
            }

            if (btnToggle.Text.Contains("enable"))
            {
                btnToggle.ForeColor = Color.FromArgb(255, 255, 255);
                btnToggle.FillColor = Color.DodgerBlue;
            }
            else if (btnToggle.Text.Contains("disable"))
            {
                btnToggle.ForeColor = Color.DodgerBlue;
                btnToggle.FillColor = Color.FromArgb(255, 255, 255);
            }
        }

        int min;
        int max;
        IntPtr hWnd;

        public string getActiveWindowName()
        {
            try
            {
                var activateHandle = GetForegroundWindow();

                Process[] processes = Process.GetProcesses();
                foreach (Process clsProcess in processes)
                {
                    if (activateHandle == clsProcess.MainWindowHandle)
                    {
                        string processName = clsProcess.ProcessName;
                        return processName;
                    }
                }
            }
            catch { }
            return null;
        }

        private void Random_Tick(object sender, EventArgs e)
        {
            if (btnToggle.Text.Contains("enable"))
            {
                min = CPSTrackbar.Value - 6;
                max = CPSTrackbar.Value + 6;
                Random rand = new Random();
                randomTB.Value = (rand.Next(min, max));
            }
        }

        private async Task Autoclicker_TickAsync(object sender, EventArgs e)
        {
            try
            {
                Autoclicker.Interval = 1000 / randomTB.Value;
            }
            catch { }
            if (btnToggle.Text.Contains("enable"))
            {
                Process[] processes = Process.GetProcessesByName("javaw");
                foreach (Process process in processes)
                {
                    hWnd = FindWindow(null, process.MainWindowTitle);
                }

                string currentwindow = getActiveWindowName();
                if (currentwindow == null)
                {
                    return;
                }

                if (currentwindow.Contains("javaw"))
                {
                    if (MouseButtons == MouseButtons.Left)
                    {
                        PostMessage(hWnd, 0x0201, 0, 0);
                        await Task.Delay(30);
                        PostMessage(hWnd, 0x0202, 0, 0);
                    }
                }
            }
        }

        private void bindBtn_Click(object sender, EventArgs e)
        {
            bindBtn.Text = "...";
        }

        KeysConverter Key = new KeysConverter();

        private void Binding_Tick(object sender, EventArgs e)
        {
            if (bindBtn.Text != "none" && bindBtn.Text != "...")
            {
                Keys binding = (Keys)Key.ConvertFromString(bindBtn.Text.Replace("...", ""));
                if (GetAsyncKeyState(binding) < 0)
                {

                    while (GetAsyncKeyState(binding) < 0)
                    {
                        Thread.Sleep(20);
                    }
                    if (btnToggle.Text.Contains("enable"))
                    {
                        btnToggle.Text = "disable";
                    }
                    else if (btnToggle.Text.Contains("disable"))
                    {
                        btnToggle.Text = "enable";
                    }

                    return;
                }
            }
        }

        private void bindBtn_KeyDown(object sender, KeyEventArgs e)
        {
            {
                string keydata = e.KeyData.ToString();
                if (!keydata.Contains("Alt"))
                {
                    if (GetAsyncKeyState(Keys.Escape) < 0)
                    {
                        bindBtn.Text = "none";
                    }
                    else
                    {
                        bindBtn.Text = keydata;
                    }
                }
            }
            KeysConverter Key = new KeysConverter();
        }
    }
}