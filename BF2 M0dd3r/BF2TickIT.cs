using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib;

namespace BF2_M0dd3r
{
    public partial class BF2TickIT : Form
    {
        string selPath = "";
        string tmpPath = @"C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\tmp";
        string configfile = @"C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\bf2path.cfg";
        string zipPath = "";

        bool levelLoaded = false;

        string overPath = "";

        public BF2TickIT()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
                
        }

        void loadLevel(object sender, EventArgs e)
        {
            try
            {
                //enable the group box...

                this.Text = sender.ToString() + " - BF2 TickIT";

                //load the archive TODO
                zipPath = @"C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\tmp\server.zip";
                overPath = selPath + "\\mods\\bf2modder\\Levels\\" + sender.ToString() + "\\server.zip";

                //copy the file..
                File.Copy(overPath, zipPath, true);

                extract(zipPath, tmpPath, "Init.con");
            }
            catch (Exception x)
            {
                x.ToString();
                MessageBox.Show("Could not load level!", "BF2 TickIT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void extract(string sArchiveIn, string outFolder, string selectName) //archive in will always be zipPath, outfolder will always be tmp and selectName will be the nodes.SelectedNode.Text.
        {
            ZipFile zf = null;
            try
            {
                FileStream fs = File.OpenRead(sArchiveIn);
                zf = new ZipFile(fs);

                foreach (ZipEntry theEntry in zf)
                {
                    if (!theEntry.IsFile)
                    {
                        continue;
                    }

                    String entryFileName = Path.GetFileName(theEntry.Name);

                    if (String.Compare(entryFileName, selectName, true) != 0)
                        continue;

                    byte[] buffer = new byte[30000];


                    Stream zipStream = zf.GetInputStream(theEntry);

                    int fileSize = zipStream.Read(buffer, 0, buffer.Length);

                    String fullZipToPath = Path.Combine(outFolder, entryFileName);

                    using (FileStream streamWriter = File.Create(fullZipToPath))
                    {
                        //writ eht buffer...
                        streamWriter.Write(buffer, 0, fileSize);
                    }
                }

                StreamReader sr = File.OpenText(tmpPath + "\\Init.con");
                string ss = sr.ReadToEnd();
                sr.Close();

                string fileContents = ss;
                ed.Text = fileContents;
            }
            finally
            {
                if (zf != null)
                {
                    zf.IsStreamOwner = true;
                    zf.Close();

                    levelLoaded = true; //the level successfully loaded...
                }
            }
        }

        private void setTickets()
        {
            try
            {

                
            }
            catch (Exception x)
            {
                x.ToString();

                MessageBox.Show("There was an error applying the changes, please try again.");
                this.Close();
            }
        }

        private void BF2TickIT_Load(object sender, EventArgs e)
        {
            if (File.Exists(configfile))
            {
                selPath = File.ReadAllText(configfile);

                if (selPath == "")
                {
                    MessageBox.Show("You need to import the archive before launching BF2 TickIT", "BF2 TickIT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    DirectoryInfo di = new DirectoryInfo(selPath + "\\mods\\bf2modder\\Levels");

                    foreach (DirectoryInfo dir in di.GetDirectories())
                    {
                        //add the thingy, and create an event for it...

                        ToolStripItem blah = lvlSelect.DropDownItems.Add(dir.Name.ToUpper());

                        blah.Click += new System.EventHandler(this.loadLevel);

                    }
                }

            }
            else
            {
                MessageBox.Show("You need to import the archive before launching BF2 TickIT", "BF2 TickIT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        void apply()
        {
            try
            {
                //copy the server.zip into the level that they selected...overwrite true...

                //File.Delete(tmpPath + "\\Init.con");

                ////now replace the text...

                string team1Num = (numTicketsTeam1.Value / 2).ToString();
                string team2Num = (numTicketsTeam2.Value / 2).ToString();


                //int selStart = ed.Find("gameLogic.setDefaultNumberOfTicketsEx ");

                //ed.Select(selStart, "gameLogic.setDefaultNumberOfTicketsEx 16 1 300gameLogic.setDefaultNumberOfTicketsEx 16 2 400gameLogic.setDefaultNumberOfTicketsEx 32 1 400gameLogic.setDefaultNumberOfTicketsEx 32 2 400gameLogic.setDefaultNumberOfTicketsEx 64 1 400gameLogic.setDefaultNumberOfTicketsEx 128 1 200gameLogic.setDefaultNumberOfTicketsEx 128 2 200gameLogic.setDefaultNumberOfTicketsEx 64 2 400".Length + 7);

                //ed.Focus();

                //if ( ed.Focused )
                //    SendKeys.Send("{DEL}");

                //if ( ed.Focused )
                //    SendKeys.Send(set + "16 1 " + team1Num + "{ENTER}");
                
                //if ( ed.Focused )
                //    SendKeys.Send(set + "16 2 " + team2Num + "{ENTER}");

                //if ( ed.Focused )
                //    SendKeys.Send(set + "32 1 " + team1Num + "{ENTER}");

                //if ( ed.Focused )
                //    SendKeys.Send(set + "32 2 " + team2Num + "{ENTER}");

                //if (ed.Focused)
                //    SendKeys.Send(set + "64 1 " + team1Num + "{ENTER}");

                //if (ed.Focused)
                //    SendKeys.Send(set + "646 2 " + team2Num + "{ENTER}");

                //if (ed.Focused)
                //    SendKeys.Send(set + "128 1 " + team1Num + "{ENTER}");

                //if (ed.Focused)
                //    SendKeys.Send(set + "128 2 " + team2Num);


                

                //File.WriteAllText(tmpPath + "\\Init.con", ed.Text);
                //k now it's edited...

                //doIt();
                
                //this.Close();

                string[] code = ed.Lines;

                for (int i = 0 ; i < code.Length ; i++)
                {
                    if (code[i].StartsWith("gameLogic.setDefaultNumberOfTicketsEx"))
                    {
                        code[i] = "gameLogic.setDefaultNumberOfTicketsEx 16 1 " + team1Num;
                        code[i + 1] = "gameLogic.setDefaultNumberOfTicketsEx 16 2 " + team2Num;
                        code[i + 2] = "gameLogic.setDefaultNumberOfTicketsEx 32 1 " + team1Num;
                        code[i + 3] = "gameLogic.setDefaultNumberOfTicketsEx 32 2 " + team2Num;
                        code[i + 4] = "gameLogic.setDefaultNumberOfTicketsEx 64 1 " + team1Num;
                        code[i + 5] = "gameLogic.setDefaultNumberOfTicketsEx 64 2 " + team2Num;
                        code[i + 6] = "gameLogic.setDefaultNumberOfTicketsEx 128 1 " + team1Num;
                        code[i + 7] = "gameLogic.setDefaultNumberOfTicketsEx 128 2 " + team2Num;

                        ed.Lines = code;

                        break;
                    }
                    else
                    {
                    }
                }

                File.WriteAllText(tmpPath + "\\Init.con", ed.Text);

                doIt();

            }
            catch (Exception x)
            {
                x.ToString();
                MessageBox.Show("There was an error applying your changes, please try again.");
                this.Close();
            }
        }

        private void doIt()
        {
            File.WriteAllText(tmpPath + "\\Init.con", ed.Text);

            ZipFile zipFile = new ZipFile(zipPath);
            zipFile.UseZip64 = UseZip64.Off;

            zipFile.BeginUpdate();

            zipFile.Add(tmpPath + "\\Init.con", "\\Init.con");

            zipFile.CommitUpdate();

            zipFile.Close();


            //then copy the file...

            File.Copy(zipPath, overPath, true);


            DONE done = new DONE();
            done.ShowDialog();

            this.Close();
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            //delete the file...
            if (File.Exists(tmpPath + "\\Init.con"))
                File.Delete(tmpPath + "\\Init.con");

            if (File.Exists(tmpPath + "\\server.zip"))
                File.Delete(tmpPath + "\\server.zip");
        }

        private void applyChanges_Click(object sender, EventArgs e)
        {
            apply();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("If you play the game, you notice that the single player levels by default have a value of 200 for both sides. \n The default value if you manually read the Init.con file inside of the level, you will see that it says 100, the value is multiplied by 2 for the tickets.", "BF2 TickIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadedTimer_Tick(object sender, EventArgs e)
        {
            if (levelLoaded)
            {
                numTicketsTeam1.Enabled = true;
                numTicketsTeam2.Enabled = true;
                applyChanges.Enabled = true;
            }
            else
            {
                numTicketsTeam1.Enabled = false;
                numTicketsTeam2.Enabled = false;
                applyChanges.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            apply();
        }

        private void levelGroup_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
