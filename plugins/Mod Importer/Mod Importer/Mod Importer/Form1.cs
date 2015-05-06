using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Mod_Importer
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        bool clickedOnce = false;

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            cd.ShowDialog();
        }

        private void modName_Click(object sender, EventArgs e)
        {
            if (!clickedOnce)
            {
                clickedOnce = true;

                cd.ShowDialog();

            }
        }

        private void cd_FileOk(object sender, CancelEventArgs e)
        {
            modName.Text = cd.FileName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (modName.Text != "")
            {
                if (txtModName.Text != "")
                {
                    string destFolder = Path.GetFullPath("..\\..\\mods"); // out of Mod Importer, and out of _plugins_ is the root path...
                    string from = modName.Text.Trim();

                    try
                    {
                        if (File.Exists(destFolder + "\\Objects_server(" + txtModName.Text + ").zip"))
                        {
                            if (MessageBox.Show("Overwrite existing?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                File.Copy(from, destFolder + "\\Objects_server(" + txtModName.Text + ").zip", true);

                        }
                        else
                        {
                            File.Copy(from, destFolder + "\\Objects_server(" + txtModName.Text + ").zip");
                        }

                        if (File.Exists(destFolder + "\\Objects_server(" + txtModName.Text + ").zip"))
                            MessageBox.Show("Mod Imported!");
                        else
                            MessageBox.Show("There was an error!");

                        this.Close();
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("There was an error, \n\n\t" + x.Message);
                    }
                }
                else
                    MessageBox.Show("Please name your mod.");
            }
            else
                MessageBox.Show("Please fill out, or browse to, the mod you would like to import.");
        }
    }
}
