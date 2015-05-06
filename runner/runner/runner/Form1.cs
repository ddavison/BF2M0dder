using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace runner
{
    public partial class frmRunner : Form
    {

        Point mPrevPos = new Point();

        public frmRunner()
        {
            InitializeComponent();
        }

        BF2_M0dd3r.BF2MConstants _const = new BF2_M0dd3r.BF2MConstants();

        string bf2path;
        string confFile;

        private void frmRunner_Load(object sender, EventArgs e)
        {

            confFile = _const.InstallPath + "\\custom_dimensions.cfg";
            

            if (File.Exists(confFile))
            {
                string[] dimensions = File.ReadAllLines(confFile);

                resx.Text = dimensions[0];
                resy.Text = dimensions[1];
                isUsingCustomDimensions.Checked = true;
            }
            else
            {

            }

            try
            {
                bf2path = File.ReadAllText(_const.fileConfigFile);
            }
            catch
            {
                MessageBox.Show("Please use BF2 Modder Before using the runner associated with it.");
            }
        }

        private void fillMaxRes_Click(object sender, EventArgs e)
        {
            int maxWidth = Screen.PrimaryScreen.Bounds.Width;
            int maxHeight = Screen.PrimaryScreen.Bounds.Height;

            if (isUsingCustomDimensions.Checked)
            {

            }
            else
            {
                isUsingCustomDimensions.Checked = true;
            }

            resx.Value = maxWidth;
            resy.Value = maxHeight;

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if (isUsingCustomDimensions.Checked)
            {
                if (!File.Exists(confFile))
                {
                    string[] lin = new string[2];
                    lin[0] = resx.Text;
                    lin[1] = resy.Text;

                    File.WriteAllLines(confFile, lin);
                }
                
            }

            runGame(resx.Text, resy.Text);

        }

        private void runGame(string resX, string resY)
        {
            Process runProc = new Process();
            //filename can be, "C:\Program Files\BF2 \mods\pr\ pr.exe"
            
            string customParams = addPara.Text;

            string additionalParameters = File.ReadAllText(_const.InstallPath + "\\add_para.cfg");

            if (isUsingCustomDimensions.Checked)
            {
                if (resX != "")
                {
                    if (resY == "")
                        resy.Focus();
                    else
                    {
                        //do stuff here...

                    }
                }
                else
                    resx.Focus();
            }

            runProc.StartInfo.FileName = (bf2path + "\\BF2.exe");

            runProc.StartInfo.Arguments = " +szx " + resX + " +szy " + resY + " " + additionalParameters + "  " + customParams;
            
            runProc.StartInfo.WorkingDirectory = bf2path;

            runProc.StartInfo.UseShellExecute = true;

            runProc.Start();
            

            this.WindowState = FormWindowState.Minimized;

            runProc.WaitForExit();



            this.Close();
        }

        private void isUsingCustomDimensions_CheckedChanged(object sender, EventArgs e)
        {
            if (isUsingCustomDimensions.Checked)
            {
                resx.Enabled = true;
                resy.Enabled = true;
            }
            else
            {
                resx.Enabled = false;
                resy.Enabled = false;
            }
        }

        private void panelEx2_MouseMove(object sender, MouseEventArgs e)
        {
            Size delta = new Size(e.X - mPrevPos.X, e.Y - mPrevPos.Y);

            if (e.Button == MouseButtons.Left)
            {
                this.Location += delta;
                mPrevPos = e.Location - delta;
            }
            else
                mPrevPos = e.Location;
        }

        private void chkWindowed_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWindowed.Checked)
            {
                // they want it windowed...
                string newStr = addPara.Text;
                newStr += " +fullscreen 0";
                addPara.Text = newStr;
            }
            else
            {
                string newStr = addPara.Text;
                newStr = newStr.Replace(" +fullscreen 0", "");
                addPara.Text = newStr;
            }
        }
    }
}
