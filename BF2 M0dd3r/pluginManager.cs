using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using ICSharpCode.SharpZipLib;
using ICSharpCode.SharpZipLib.Zip;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using DevComponents.DotNetBar;

namespace BF2_M0dd3r
{
    public partial class pluginManager : Form
    {

        string plugPath;
        BF2MConstants _const = new BF2MConstants();

        public pluginManager()
        {
            InitializeComponent();
            plugPath = _const.InstallPath + "\\_plugins_";
        }

        private void cd_FileOk(object sender, CancelEventArgs e)
        {
            if (File.Exists(cd.FileName))
            {
                pluginPath.Text = cd.FileName;
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
        }

        private void pluginPath_Click(object sender, EventArgs e)
        {
           
        }

        //private void installPluginButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (File.Exists(pluginPath.Text))
        //        {
        //            if (pluginName.Text == "")
        //            {
        //                MessageBox.Show("Please name your plugin...");
        //                pluginName.Focus();
        //            }
        //            else
        //            {
        //                // install the plugin,

        //                if (Directory.Exists(plugPath + "\\" + pluginName.Text))
        //                {
        //                    if (MessageBox.Show("There is already a plugin with this name. Would you like to overwrite?", "BF2 M0dd3r Plugin Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //                    {
        //                        Directory.Delete(plugPath + "\\" + pluginName.Text, true);

        //                        Directory.CreateDirectory(plugPath + "\\" + pluginName.Text);

        //                        string newPath = plugPath + "\\" + pluginName.Text;

        //                        File.Copy(pluginPath.Text, newPath + "\\" + pluginName.Text + ".exe");
        //                        File.WriteAllText(newPath + "\\" + pluginName.Text + ".cfg", "");

        //                        MessageBox.Show(pluginName.Text + " BF2 M0dd3r Plugin Installed!", "BF2 M0dd3r Plugin Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                        timer1.Enabled = true;
        //                    }
        //                    else
        //                    {
        //                        //dont do anything.
        //                    }
                            
        //                }
        //                else
        //                {
        //                    Directory.CreateDirectory(plugPath + "\\" + pluginName.Text);

        //                    string newPath = plugPath + "\\" + pluginName.Text;

        //                    File.Copy(pluginPath.Text, newPath + "\\" + pluginName.Text + ".exe");
        //                    File.WriteAllText(newPath + "\\" + pluginName.Text + ".cfg", "");

        //                    MessageBox.Show(pluginName.Text + " BF2 M0dd3r Plugin Installed!", "BF2 M0dd3r Plugin Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    timer1.Enabled = true;
        //                }
        //            }
        //        }

        //        else
        //        {
        //            MessageBox.Show("Please select an existant plugin...");
        //        }
        //    }
        //    catch (Exception x)
        //    {
        //        MessageBox.Show("Could not Install Plugin!\n\n" + x.Message);
        //    }
        //}

        private void installPluginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(pluginPath.Text))
                {
                    if (pluginPath.Text == "")
                    {
                        MessageBox.Show("Please provide the path to the plugin...");
                        pluginPath.Focus();
                    }
                    else
                    {
                        // install the plugin

                        string plugin = pluginPath.Text; // the whole thing,

                        string pluginName = Path.GetFileName(plugin); // the Mod Name.zip

                        string realPluginName = pluginName.Remove(pluginName.Length - 4, 4); // Mod Name

                        bool isExeGood = false;
                        bool isCfgGood = false;

                        FileStream fs = File.OpenRead(plugin);

                        ZipFile zf = new ZipFile(fs);

                        //there should only be 2 files...

                        try
                        {
                            ZipEntry theEXE = new ZipEntry(realPluginName + ".exe");

                            //create the {bf2m plugins dir}\Mod Name
                            
                            if (!Directory.Exists(plugPath + "\\" + realPluginName))
                                Directory.CreateDirectory(plugPath + "\\" + realPluginName);

                            // ---

                            //extract the exe.

                            byte[] buffer = new byte[4096];

                            Stream zipStream = zf.GetInputStream(theEXE);


                            string thenewexepath = plugPath + "\\" + realPluginName + "\\" + realPluginName + ".exe";

                            using (FileStream streamWriter = File.Create(thenewexepath))
                            {
                                ICSharpCode.SharpZipLib.Core.StreamUtils.Copy(zipStream, streamWriter, buffer);
                            }

                            if (File.Exists(thenewexepath))
                            {
                                FileVersionInfo theexe =FileVersionInfo.GetVersionInfo(thenewexepath);

                                if ( theexe.ProductVersion != Application.ProductVersion )
                                {
                                    MessageBoxEx.Show("The plugin that you have chosen to install is for a different version of BF2 Modder. This plugin might not work.\n\nPlease visit the download page for an update for BF2 Modder Version " + this.ProductVersion + ".", "BF2 Modder Plugin Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                
                                
                                isExeGood = true;
                            }
                        }
                        catch ( Exception x)
                        {
                            MessageBox.Show("You have selected an invalid plugin.", x.Message);
                            
                        }

                        ///    

                        try
                        {
                            ZipEntry theCFG = new ZipEntry(realPluginName + ".cfg");
                            
                            if (!Directory.Exists(plugPath + "\\" + realPluginName))
                                Directory.CreateDirectory(plugPath + "\\" + realPluginName);

                            // ---

                            //extract the exe.

                            byte[] buffer = new byte[30000];

                            Stream zipStream = zf.GetInputStream(theCFG);

                            int fileSize = zipStream.Read(buffer, 0, buffer.Length);

                            string thenewcfgpath  = plugPath + "\\" + realPluginName + "\\" + realPluginName + ".cfg";

                            FileStream streamWriter = File.Create(thenewcfgpath);

                            streamWriter.Write(buffer, 0, fileSize);

                            if ( File.Exists(thenewcfgpath) )
                                isCfgGood = true;
                        }
                        catch
                        {
                            MessageBox.Show("You have selected an invalid plugin.");
                        }

                        if (isExeGood && isCfgGood)
                        {
                            timer1.Enabled = true;
                        }
                        else
                            MessageBox.Show("There was an error installing the plugin.");
                    }
                }
            }
            catch (Exception x)
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(plugPath);

            installedPlugins.Items.Clear();

            foreach (DirectoryInfo d in di.GetDirectories())
            {
                if (File.Exists(d.FullName + "\\" + d.Name + ".exe"))
                {
                    installedPlugins.Items.Add(d.Name);
                }
                else
                {

                }
            }

            timer1.Enabled = false;

        }

        private void installedPlugins_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //this will delete the plugin.;

            try
            {

                if (MessageBox.Show("Are you sure you would like to uninstall the plugin, " + installedPlugins.SelectedItem.ToString(), "BF2 M0dd3r Plugin Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Directory.Delete(plugPath + "\\" + installedPlugins.SelectedItem.ToString(), true);
                }
                else
                {
                    // do nothing.
                }

            }
            catch (Exception x)
            {
                MessageBox.Show("Could not delete the plugin!\n\n\t " + x.Message);
            }
            timer1.Enabled = true;
        }
    }
}
