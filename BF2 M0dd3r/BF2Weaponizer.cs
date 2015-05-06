using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib;

namespace BF2_M0dd3r
{
    public partial class BF2Weaponizer : Form
    {
        string configFile = @"C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\bf2path.cfg";

        public BF2Weaponizer()
        {
            InitializeComponent();
        }

        private void BF2Weaponizer_Load(object sender, EventArgs e)
        {
            if (!File.Exists(configFile))
            {
                MessageBox.Show("You must load the archive before launching BF2 Weaponizer", "BF2 Weaponizer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                //read...
                string instPath = File.ReadAllText(configFile);

                if (instPath == "")
                {
                    MessageBox.Show("You must load the archive before launching BF2 Weaponizer", "BF2 Weaponizer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    //continue...
                }
            }
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            //on change, load the appropriate file
        }

        private void u1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void u2_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
