using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace BF2_M0dd3r
{
    public partial class creatingModFolder : Form
    {
        string frm, dest;
        string appDir;
        bool justdoingafterstuff;

        Process myProcess = new Process();
        BF2MConstants _const = new BF2MConstants();

        public creatingModFolder(string from, string to, bool justAfterStuff)
        {
            InitializeComponent();

            frm = from;
            dest = to;

            appDir = _const.InstallPath;
            justdoingafterstuff = justAfterStuff;
        }

        void copyFolder(string sourceFolder, string destFolder)
        {
            try
            {
                if (!justdoingafterstuff)
                {
                    if (!File.Exists(appDir + @"\createMod.bat"))
                    {
                        string[] contents = { "@echo off", "Title Please Wait... Initalizing BF2 Modder...", "color 71", "xcopy \"" + sourceFolder + "\" \"" + destFolder + "\" /I /E", "echo hello>\"tmp.min\"" };

                        File.WriteAllLines(appDir + @"\createMod.bat", contents);
                    }

                    ProcessStartInfo si = new ProcessStartInfo(appDir + @"\createMod.bat");

                    myProcess.StartInfo = si;

                    myProcess.Start();
                    myProcess.WaitForExit();

                    doAfterStuff(destFolder);
                    this.Close();
                }
                else
                    doAfterStuff(destFolder);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void doAfterStuff(string destFolder)
        {
            try
            {
                File.WriteAllText(appDir + @"\tmp\Mod Comments.tweak", "(put your mod comments in here)");

                File.Copy(frm + "\\Objects_server.zip", appDir + @"\tmp\Objects_server.zip", true);
                File.Copy(frm + "\\Objects_server.zip", appDir + @"\_restore_\Objects_server(_Original_).zip", true);

                //ok right here, after they click load archive, were gonna put the M0d Comments.tweak inside of / :)

                ZipFile zipFile = new ZipFile(appDir + @"\tmp\Objects_server.zip");

                zipFile.UseZip64 = UseZip64.Off;

                zipFile.BeginUpdate();

                zipFile.Add(appDir + @"\tmp\Mod Comments.tweak", "Mod Comments.tweak");

                zipFile.CommitUpdate();

                zipFile.Close();



                File.Delete(appDir + @"\tmp\Mod Comments.tweak");

                File.WriteAllText(appDir + @"\modCreated.cfg", "true");

                File.Copy(appDir + @"\welcome.bik", destFolder + "\\Movies\\welcome.bik", true);
                File.Copy(appDir + @"\bf2cursor.ani", destFolder + "\\menu\\external\\FlashMenu\\Cursor\\cursor_arrow.ani", true);
                // now that the vid is copied for startup, edit the Init.con file to show welcome.bik :)

                string[] flTxt = { "rem -- Generated using BF2 Modder --", "bf2Engine.playMovie Movies\\welcome.bik 1" };
                File.WriteAllLines(destFolder + "\\Init.con", flTxt);

                File.Delete(appDir + @"\createMod.bat");

                MessageBox.Show("Import Process Complete!\n\nYou may now begin making mods.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("There was an error ! An explanation follows, please report this error.\n\n\t" +x.Message);
            }
        }

        private void creatingModFolder_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "Please Wait...";
            label1.Text = "The Initialization process has started, please standby...";
            button1.Enabled = false;
            copyFolder(frm, dest);
        }

        private void process1_Exited(object sender, EventArgs e)
        {
            
        }

    }
}
