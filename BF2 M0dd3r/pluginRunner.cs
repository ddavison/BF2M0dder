using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace BF2_M0dd3r
{
    public partial class pluginRunner : Form
    {
        public pluginRunner(string pluginToSearchFor)
        {
            InitializeComponent();

            runPlugin(pluginToSearchFor);
        }

        private void pluginRunner_Load(object sender, EventArgs e)
        {

        }

        void runPlugin(string plugin)
        {
            // search for the plugin...
                DirectoryInfo pluginDir = new DirectoryInfo(@"C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\_plugins_");

            try
            {
                foreach (DirectoryInfo di in pluginDir.GetDirectories())
                {
                    if (di.Name.Contains(plugin))
                    {
                        string exePath = di.FullName + "\\" + di.Name + ".exe";

                        MessageBox.Show(exePath);
                        if (File.Exists(exePath))
                        {
                            //run it...

                            Process pluginProc = new Process();
                            pluginProc.StartInfo.FileName = exePath;

                            pluginProc.Start();
                            pluginProc.WaitForExit();

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("You have specified an invalid plugin!", "BF2 M0dd3r", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("You have specified an invalid plugin!", "BF2 M0dd3r", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Close();
                    }
                }
            }
            catch  (Exception x)
            {
                MessageBox.Show(x.Message);
                this.Close();
            }
        }
    }
}
