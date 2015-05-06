using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BF2_M0dd3r
{
    public partial class copyingMod : Form
    {
        string fromPath = "";
        string toPath     = "";

        public copyingMod(string from, string to)
        {
            InitializeComponent();

            fromPath = from;
            toPath     = to;
        }

        private void copyingMod_Load(object sender, EventArgs e)
        {
            try
            {

                
                if (File.Exists(toPath))
                {
                    //file already exists...ask to overwrite...
                    DialogResult mm = MessageBox.Show("A m0d with the same name already exists. Replace it?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                    if (mm == DialogResult.Yes)
                    {
                        //clicked yes...

                        File.Delete(toPath);

                        copyFile("");
                    }
                    else if (mm == DialogResult.No)
                    {
                        //ask to rename...
                        DialogResult sv = MessageBox.Show("Would you still like to save the m0d?", Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                        if (sv == DialogResult.Yes)
                        {
                            // show the form

                            saveAsNewMod newMod = new saveAsNewMod(toPath);
                            DialogResult blah = newMod.ShowDialog();
                            newMod.Dispose();

                            if (blah == DialogResult.OK)
                            {
                                string newModName = newMod.getModName();

                                if (newModName == "")
                                {

                                }
                                else
                                    copyFile(newModName);

                                //omg....
                            }
                            else
                            {
                                this.Close();
                            }

                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else if (mm == DialogResult.Cancel)
                    {
                        this.Close();
                    }
                }
                else
                {
                    copyFile("");
                }
                

                this.Close();
            }
            catch (Exception ex)
            {
                ex.ToString();

                MessageBox.Show("There has been an error copying the mod. Please try again" + ex.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void copyFile(string modName)
        {
            if (modName != "")
            {
                toPath = @"C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\mods\Objects_server(" + modName + ").zip";

                byte[] buffer = File.ReadAllBytes(fromPath);

                progressBar.Maximum = buffer.Length;

                this.Visible = true;

                this.Focus();

                // got the buffer, now write bytes to fromPath...

                if (File.Exists(toPath))
                    File.Delete(toPath); //delete cuz they didnt want a new mod...

                Stream sw = new FileStream(toPath, FileMode.CreateNew);

                foreach (byte bufferByte in buffer)
                {
                    
                    progressBar.Increment(1);


                    sw.WriteByte(bufferByte);
                    this.Focus();
                }

                sw.Close();
            }
            else
            {
                byte[] buffer = File.ReadAllBytes(fromPath);

                progressBar.Maximum = buffer.Length;

                this.Visible = true;

                this.Focus();

                // got the buffer, now write bytes to fromPath...

                Stream sw = new FileStream(toPath, FileMode.CreateNew);

                foreach (byte bufferByte in buffer)
                {
                    this.Focus();
                    progressBar.Increment(1);


                    sw.WriteByte(bufferByte);
                    this.Focus();
                }

                sw.Close();
            }
        }
    }
}