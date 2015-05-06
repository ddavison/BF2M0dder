using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using BF2_M0dd3r;

namespace BF2_M0dd3r
{
    public partial class ModName : Form
    {

        BF2MConstants _const = new BF2MConstants();

        string zipPath = @"C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\tmp\Objects_server.zip";
        string modPath = @"C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\mods";
        
        string modName;

        string appDir;

        int newHeight = 330;

        int oldHeight = 83;

        public ModName(string nm)
        {
            InitializeComponent();
            appDir = _const.InstallPath;

            zipPath = appDir + "\\tmp\\Objects_server.zip";
            modPath = appDir + "\\mods";

            modName = nm.Replace("Objects_server(", "");
            modName = modName.Remove(modName.Length - 5, 5);

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtModName.Text == "")
            {
                MessageBox.Show("Enter a mod name", "BF2 M0dd3r", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtModName.Focus();
            }
            else
            {
                saveMod(txtModName.Text);
            }
        }

        void saveMod(string modName)
        {
            if ( File.Exists(modPath + "\\Objects_server(" + modName + ").zip" ))
            {
                DialogResult over = MessageBox.Show("Overwrite?", "BF2 M0dd3r", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                switch ( over )
                {
                    case DialogResult.Yes:
                        File.Copy(zipPath, modPath + "\\Objects_server(" + modName + ").zip", true);
                        break;
                    case DialogResult.No:
                        MessageBox.Show("Enter a new mod name...");
                        break;
                    case DialogResult.Cancel:
                        this.Close();
                        break;
                }

            }
            else
            {
                File.Copy(zipPath, modPath + "\\Objects_server(" + modName + ").zip");

                DONE sdlk = new DONE();
                sdlk.ShowDialog();
                this.Close();
            }
        }

        private void ModName_Load(object sender, EventArgs e)
        {
            populateMods();

            if ( modName == "" )
            {

            }
            else if (modName == "Defaul")
            {

            }
            else
                txtModName.Text = modName;
        }

        private void modTimer_Tick(object sender, EventArgs e)
        {
            if (createNew.Checked)
            {
                //make sure height is oldHeight.
                this.Height = oldHeight;
                modList.Enabled = false;
            }
            else
            {
                //it's unchecked...
                this.Height = newHeight;
                modList.Enabled = true;
            }


        }

        void populateMods()
        {
            DirectoryInfo di = new DirectoryInfo(modPath);
            try
            {
                foreach (FileInfo fi in di.GetFiles("*.zip"))
                {
                    if (modList.Items.Contains(fi.Name))
                    {
                        //already exists...dont add it..
                    }
                    else
                        modList.Items.Add(fi.Name);
                }
            }
            catch (Exception x)
            {
                x.ToString();
            }
        }

        private void createNew_CheckedChanged(object sender, EventArgs e)
        {
            if (createNew.Checked)
            {
                //they uncheck it...populate
                populateMods();
            }
            else
            {

            }
        }

        private void modList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = modList.SelectedItem.ToString();
            // Objects_server
            string blah = "Objects_server";

            //remove the Objects_server...
            name = name.Remove(0, (blah.Length + 1 /*get rid of the (*/));

            name = name.Replace(").zip", "");


            txtModName.Text = name;
        }

        private void modList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string name = modList.Text;
            // Objects_server
            string blah = "Objects_server";

            //remove the Objects_server...
            name = name.Remove(0, (blah.Length + 1 /*get rid of the (*/));

            name = name.Replace(").zip", "");
            
            saveMod(name);

        }
    }
}
